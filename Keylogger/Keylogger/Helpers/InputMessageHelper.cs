using Keylogger.Helpers.Enums;
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

        public static HashSet<string> MouseEvents =
        [
            "Mouse Up & Down", "Mouse Down", "Mouse Up"
        ];

        public static Dictionary<(MouseButtonFilter, string), Predicate<MouseMessage>> MouseEventPredicates = new()
        {
            // All buttons
            {
                (MouseButtonFilter.All, "Mouse Up & Down"), msg =>
                msg == MouseMessage.WM_LBUTTONDOWN || msg == MouseMessage.WM_LBUTTONUP ||
                msg == MouseMessage.WM_RBUTTONDOWN || msg == MouseMessage.WM_RBUTTONUP ||
                msg == MouseMessage.WM_MBUTTONDOWN || msg == MouseMessage.WM_MBUTTONUP ||
                msg == MouseMessage.WM_MOUSEWHEEL
            },
            {
                (MouseButtonFilter.All, "Mouse Down"), msg =>
                msg == MouseMessage.WM_LBUTTONDOWN || msg == MouseMessage.WM_RBUTTONDOWN ||
                msg == MouseMessage.WM_MBUTTONDOWN || msg == MouseMessage.WM_MOUSEWHEEL
            },
            {
                (MouseButtonFilter.All, "Mouse Up"), msg =>
                msg == MouseMessage.WM_LBUTTONUP || msg == MouseMessage.WM_RBUTTONUP ||
                msg == MouseMessage.WM_MBUTTONUP || msg == MouseMessage.WM_MOUSEWHEEL
            },
            // Left button
            {
                (MouseButtonFilter.LeftButton, "Mouse Up & Down"), msg =>
                msg == MouseMessage.WM_LBUTTONDOWN || msg == MouseMessage.WM_LBUTTONUP
            },
            {
                (MouseButtonFilter.LeftButton, "Mouse Down"), msg => msg == MouseMessage.WM_LBUTTONDOWN
            },
            {
                (MouseButtonFilter.LeftButton, "Mouse Up"), msg => msg == MouseMessage.WM_LBUTTONUP
            },
            // Right button
            {
                (MouseButtonFilter.RightButton, "Mouse Up & Down"), msg =>
                msg == MouseMessage.WM_RBUTTONDOWN || msg == MouseMessage.WM_RBUTTONUP
            },
            {
                (MouseButtonFilter.RightButton, "Mouse Down"), msg => msg == MouseMessage.WM_RBUTTONDOWN
            },
            {
                (MouseButtonFilter.RightButton, "Mouse Up"), msg => msg == MouseMessage.WM_RBUTTONUP
            },
            // Middle button
            {
                (MouseButtonFilter.MiddleButton, "Mouse Up & Down"), msg =>
                msg == MouseMessage.WM_MBUTTONDOWN || msg == MouseMessage.WM_MBUTTONUP
            },
            {
                (MouseButtonFilter.MiddleButton, "Mouse Down"), msg => msg == MouseMessage.WM_MBUTTONDOWN
            },
            {
                (MouseButtonFilter.MiddleButton, "Mouse Up"), msg => msg == MouseMessage.WM_MBUTTONUP
            },
            // Left and Right buttons
            {
                (MouseButtonFilter.LeftAndRightButton, "Mouse Up & Down"), msg =>
                msg == MouseMessage.WM_LBUTTONDOWN || msg == MouseMessage.WM_LBUTTONUP ||
                msg == MouseMessage.WM_RBUTTONDOWN || msg == MouseMessage.WM_RBUTTONUP
            },
            {
                (MouseButtonFilter.LeftAndRightButton, "Mouse Down"), msg =>
                msg == MouseMessage.WM_LBUTTONDOWN || msg == MouseMessage.WM_RBUTTONDOWN
            },
            {
                (MouseButtonFilter.LeftAndRightButton, "Mouse Up"), msg =>
                msg == MouseMessage.WM_LBUTTONUP || msg == MouseMessage.WM_RBUTTONUP
            },
            // Left and Middle buttons
            {
                (MouseButtonFilter.LeftAndMiddleButton, "Mouse Up & Down"), msg =>
                msg == MouseMessage.WM_LBUTTONDOWN || msg == MouseMessage.WM_LBUTTONUP ||
                msg == MouseMessage.WM_MBUTTONDOWN || msg == MouseMessage.WM_MBUTTONUP
            },
            {
                (MouseButtonFilter.LeftAndMiddleButton, "Mouse Down"), msg =>
                msg == MouseMessage.WM_LBUTTONDOWN || msg == MouseMessage.WM_MBUTTONDOWN
            },
            {
                (MouseButtonFilter.LeftAndMiddleButton, "Mouse Up"), msg =>
                msg == MouseMessage.WM_LBUTTONUP || msg == MouseMessage.WM_MBUTTONUP
            },
            // Right and Middle buttons
            {
                (MouseButtonFilter.RightAndMiddleButton, "Mouse Up & Down"), msg =>
                msg == MouseMessage.WM_RBUTTONDOWN || msg == MouseMessage.WM_RBUTTONUP ||
                msg == MouseMessage.WM_MBUTTONDOWN || msg == MouseMessage.WM_MBUTTONUP
            },
            {
                (MouseButtonFilter.RightAndMiddleButton, "Mouse Down"), msg =>
                msg == MouseMessage.WM_RBUTTONDOWN || msg == MouseMessage.WM_MBUTTONDOWN
            },
            {
                (MouseButtonFilter.RightAndMiddleButton, "Mouse Up"), msg =>
                msg == MouseMessage.WM_RBUTTONUP || msg == MouseMessage.WM_MBUTTONUP
            }
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