using Keylogger.Helpers.Enums;
using System.Globalization;
using static Keylogger.Interop.Win32Api;

namespace Keylogger.Helpers
{
    internal static class KeyFilterHelper
    {
        private static readonly TextInfo TextInfo = new CultureInfo("en-US", false).TextInfo;

        public static Dictionary<string, KeyFilter> KeyFilters = new()
        {
            { "All Keys", KeyFilter.AllKeys },
            { "Printable characters", KeyFilter.PrintableCharacters },
            { "Non-printable keys", KeyFilter.NonPrintableKeys },
            { "Function keys (F1 - F12)", KeyFilter.FunctionKeys },
            { "Modifier keys (Ctrl, Shift, Alt, Win)", KeyFilter.ModifierKeys }
        };

        private static readonly HashSet<string> SpecialPrintableKeys =
        [
            "[Space]", "[Enter]", "[Backspace]"
        ];

        private static readonly HashSet<string> FunctionKeys =
        [
            "[F1]", "[F2]", "[F3]", "[F4]", "[F5]", "[F6]",
            "[F7]", "[F8]", "[F9]", "[F10]", "[F11]", "[F12]"
        ];

        private static readonly HashSet<string> Modifiers =
        [
            "[Shift]", "[Left Shift]", "[Right Shift]",
            "[Ctrl]", "[Left Ctrl]", "[Right Ctrl]",
            "[Alt]", "[Left Alt]", "[Right Alt]",
            "[Windows]", "[Left Windows]", "[Right Windows]"
        ];

        public static string GetVirtualKeyName(uint vkCode)
        {
            return vkCode switch
            {
                (uint)VirtualKeyCode.VK_RETURN => "Enter",
                (uint)VirtualKeyCode.VK_BACK => "Backspace",
                (uint)VirtualKeyCode.VK_ESCAPE => "Esc",
                (uint)VirtualKeyCode.VK_LSHIFT => "Left Shift",
                (uint)VirtualKeyCode.VK_RSHIFT => "Right Shift",
                (uint)VirtualKeyCode.VK_LCONTROL => "Left Ctrl",
                (uint)VirtualKeyCode.VK_RCONTROL => "Right Ctrl",
                (uint)VirtualKeyCode.VK_LMENU => "Left Alt",
                (uint)VirtualKeyCode.VK_RMENU => "Right Alt",
                (uint)VirtualKeyCode.VK_PRIOR => "Page Up",
                (uint)VirtualKeyCode.VK_NEXT => "Page Down",
                (uint)VirtualKeyCode.VK_LWIN => "Left Windows",
                (uint)VirtualKeyCode.VK_RWIN => "Right Windows",
                (uint)VirtualKeyCode.VK_SNAPSHOT => "Print Screen",
                (uint)VirtualKeyCode.VK_CAPITAL => "Caps Lock",
                (uint)VirtualKeyCode.VK_SPACE => "Space",
                _ => TextInfo.ToTitleCase(Enum.GetName(typeof(VirtualKeyCode), vkCode)?.Replace("VK_", "").ToLower() ?? "Unknown Key")
            };
        }

        public static bool IsNonPrintableKey(uint vkCode)
        {
            return vkCode == (uint)VirtualKeyCode.VK_RETURN ||
                   vkCode == (uint)VirtualKeyCode.VK_BACK ||
                   vkCode == (uint)VirtualKeyCode.VK_TAB ||
                   vkCode == (uint)VirtualKeyCode.VK_SPACE ||
                   vkCode == (uint)VirtualKeyCode.VK_ESCAPE;
        }

        public static bool ShouldDisplayKey(string key, KeyType keyType, KeyFilter keyFilter)
        {
            return keyFilter switch
            {
                KeyFilter.AllKeys => true,
                KeyFilter.PrintableCharacters => IsPrintableKey(key, keyType),
                KeyFilter.NonPrintableKeys => keyType == KeyType.NonPrintableKey,
                KeyFilter.FunctionKeys => IsFunctionKey(key, keyType),
                KeyFilter.ModifierKeys => IsModifier(key, keyType),
                _ => false
            };
        }

        private static bool IsPrintableKey(string key, KeyType keyType) =>
            keyType == KeyType.PrintableKey || SpecialPrintableKeys.Contains(key);

        private static bool IsFunctionKey(string key, KeyType keyType) =>
            keyType == KeyType.NonPrintableKey && FunctionKeys.Contains(key);

        private static bool IsModifier(string key, KeyType keyType) =>
            keyType == KeyType.NonPrintableKey && Modifiers.Contains(key);

        public static string ReplaceKey(string key)
        {
            return key switch
            {
                "[Space]" => " ",
                "[Enter]" => Environment.NewLine,
                _ => key
            };
        }
    }
}