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
                (nuint)MouseMessage.WM_LBUTTONDOWN => "Left button down",
                (nuint)MouseMessage.WM_LBUTTONUP => "Left button up",
                (nuint)MouseMessage.WM_RBUTTONDOWN => "Right button down",
                (nuint)MouseMessage.WM_RBUTTONUP => "Right button up",
                (nuint)MouseMessage.WM_MBUTTONDOWN => "Middle button down",
                (nuint)MouseMessage.WM_MBUTTONUP => "Middle button up",
                (nuint)MouseMessage.WM_MOUSEMOVE => "Mouse move",
                (nuint)MouseMessage.WM_MOUSEWHEEL => "Mouse wheel",
                _ => Enum.GetName(typeof(MouseMessage), wParam)?.Replace("WM_", "") ?? "Unknown message",
            };
        }

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
                _ => Enum.GetName(typeof(VirtualKeyCode), vkCode)?.Replace("VK_", "") ?? "Unknown key",
            };
        }

        public static string GetKeyboardMessageName(nuint wParam)
        {
            return wParam switch
            {
                (nuint)KeyboardMessage.WM_KEYDOWN => "Key down",
                (nuint)KeyboardMessage.WM_KEYUP => "Key up",
                (nuint)KeyboardMessage.WM_SYSKEYDOWN => "Sys key down",
                (nuint)KeyboardMessage.WM_SYSKEYUP => "Sys key up",
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