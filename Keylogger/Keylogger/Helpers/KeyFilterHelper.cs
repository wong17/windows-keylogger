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
            { "Non-printable keys", KeyFilter.NonPrintableKeys }
        };

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
                KeyFilter.PrintableCharacters => keyType == KeyType.PrintableKey || IsSpecialPrintableKey(key),
                KeyFilter.NonPrintableKeys => keyType == KeyType.NonPrintableKey,
                _ => false
            };
        }

        private static bool IsSpecialPrintableKey(string key) => key is "[Space]" or "[Enter]" or "[Backspace]";
    }
}