using static Keylogger.Interop.Win32Api;

namespace Keylogger.Helpers
{
    internal static class InputMessageHelper
    {
        public static Dictionary<string, Predicate<KeyboardMessage>> KeyboardEvents = new()
        {
            { "Key Down", kbmsg => kbmsg == KeyboardMessage.WM_KEYDOWN },
            { "Key Up", kbmsg => kbmsg == KeyboardMessage.WM_KEYUP },
            { "Sys Key Down", kbmsg => kbmsg == KeyboardMessage.WM_SYSKEYDOWN },
            { "Sys Key Up", kbmsg => kbmsg == KeyboardMessage.WM_SYSKEYUP },
            { "Key Down & Sys Key Down", kbmsg => kbmsg == KeyboardMessage.WM_KEYDOWN || kbmsg == KeyboardMessage.WM_SYSKEYDOWN },
            { "Key Up & Sys Key Up", kbmsg => kbmsg == KeyboardMessage.WM_KEYUP || kbmsg == KeyboardMessage.WM_SYSKEYUP }
        };

        public static string GetMouseMessageName(nuint wParam)
        {
            return wParam switch
            {
                (nuint)MouseMessage.WM_LBUTTONDOWN => "Left Button Down",
                (nuint)MouseMessage.WM_LBUTTONUP => "Left Button Up",
                (nuint)MouseMessage.WM_RBUTTONDOWN => "Right Button Down",
                (nuint)MouseMessage.WM_RBUTTONUP => "Right Button Up",
                (nuint)MouseMessage.WM_MBUTTONDOWN => "Middle Button Down",
                (nuint)MouseMessage.WM_MBUTTONUP => "Middle Button Up",
                (nuint)MouseMessage.WM_MOUSEMOVE => "Mouse Move",
                (nuint)MouseMessage.WM_MOUSEWHEEL => "Mouse Wheel",
                _ => Enum.GetName(typeof(MouseMessage), wParam)?.Replace("WM_", "") ?? "Unknown Message"
            };
        }

        public static string GetKeyboardMessageName(nuint wParam)
        {
            return wParam switch
            {
                (nuint)KeyboardMessage.WM_KEYDOWN => "Key Down",
                (nuint)KeyboardMessage.WM_KEYUP => "Key Up",
                (nuint)KeyboardMessage.WM_SYSKEYDOWN => "Sys Key Down",
                (nuint)KeyboardMessage.WM_SYSKEYUP => "Sys Key Up",
                _ => Enum.GetName(typeof(KeyboardMessage), wParam)?.Replace("WM_", "") ?? "Unknown message"
            };
        }
    }
}