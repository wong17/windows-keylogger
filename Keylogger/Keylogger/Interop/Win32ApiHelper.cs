using System.Runtime.InteropServices;
using static Keylogger.Interop.Win32Api;

namespace Keylogger.Interop
{
    internal static class Win32ApiHelper
    {
        public static string GetLastErrorMessage()
        {
            var errorCode = Marshal.GetLastWin32Error();

            var msgCapacity = 256;
            var message = new string('\0', msgCapacity);

            var result = FormatMessageW(FORMAT_MESSAGE_FROM_SYSTEM, IntPtr.Zero, (uint)errorCode, 0, message, (uint)msgCapacity, IntPtr.Zero);
            if (result == 0)
            {
                return $"Unknown error code: {errorCode}";
            }

            return message.TrimEnd('\0').Trim();
        }

        public static string GetMouseMessageName(nuint wParam)
        {
            return wParam switch
            {
                (nuint)MouseMessage.WM_LBUTTONDOWN => "LEFT BUTTON DOWN",
                (nuint)MouseMessage.WM_LBUTTONUP => "LEFT BUTTON UP",
                (nuint)MouseMessage.WM_RBUTTONDOWN => "RIGHT BUTTON DOWN",
                (nuint)MouseMessage.WM_RBUTTONUP => "RIGHT BUTTON UP",
                (nuint)MouseMessage.WM_MBUTTONDOWN => "MIDDLE BUTTON DOWN",
                (nuint)MouseMessage.WM_MBUTTONUP => "MIDDLE BUTTON UP",
                (nuint)MouseMessage.WM_MOUSEMOVE => "MOUSE MOVE",
                (nuint)MouseMessage.WM_MOUSEWHEEL => "MOUSE WHEEL",
                _ => Enum.GetName(typeof(MouseMessage), wParam)?.Replace("WM_", "") ?? "Unknown message",
            };
        }

        public static string GetVirtualKeyName(uint vkCode)
        {
            return vkCode switch
            {
                (uint)VirtualKeyCode.VK_RETURN => "ENTER",
                (uint)VirtualKeyCode.VK_BACK => "BACKSPACE",
                (uint)VirtualKeyCode.VK_ESCAPE => "ESC",
                (uint)VirtualKeyCode.VK_LSHIFT => "LEFT SHIFT",
                (uint)VirtualKeyCode.VK_RSHIFT => "RIGHT SHIFT",
                (uint)VirtualKeyCode.VK_LCONTROL => "LEFT CTRL",
                (uint)VirtualKeyCode.VK_RCONTROL => "RIGHT CTRL",
                (uint)VirtualKeyCode.VK_LMENU => "LEFT ALT",
                (uint)VirtualKeyCode.VK_RMENU => "RIGHT ALT",
                (uint)VirtualKeyCode.VK_PRIOR => "PAGE UP",
                (uint)VirtualKeyCode.VK_NEXT => "PAGE DOWN",
                (uint)VirtualKeyCode.VK_LWIN => "LEFT WINDOWS",
                (uint)VirtualKeyCode.VK_RWIN => "RIGHT WINDOWS",
                (uint)VirtualKeyCode.VK_SNAPSHOT => "PRINT SCREEN",
                (uint)VirtualKeyCode.VK_CAPITAL => "CAPS LOCK",
                _ => Enum.GetName(typeof(VirtualKeyCode), vkCode)?.Replace("VK_", "") ?? "Unknown key",
            };
        }

        public static string GetKeyboardMessageName(nuint wParam)
        {
            return wParam switch
            {
                (nuint)KeyboardMessage.WM_KEYDOWN => "KEY DOWN",
                (nuint)KeyboardMessage.WM_KEYUP => "KEY UP",
                (nuint)KeyboardMessage.WM_SYSKEYDOWN => "SYS KEY DOWN",
                (nuint)KeyboardMessage.WM_SYSKEYUP => "SYS KEY UP",
                _ => Enum.GetName(typeof(KeyboardMessage), wParam)?.Replace("WM_", "") ?? "Unknown message",
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

        public static Dictionary<string, Predicate<KeyboardMessage>> KeyboardEvents = new()
        {
            { "Key down", kbmsg => kbmsg == KeyboardMessage.WM_KEYDOWN },
            { "Key up", kbmsg => kbmsg == KeyboardMessage.WM_KEYUP },
            { "System key down", kbmsg => kbmsg == KeyboardMessage.WM_SYSKEYDOWN },
            { "System key up", kbmsg => kbmsg == KeyboardMessage.WM_SYSKEYUP }
        };
    }
}