﻿using System.Runtime.InteropServices;
using static Keylogger.Interop.Win32Api;

namespace Keylogger.Helpers
{
    internal static class Win32ErrorHelper
    {
        public static string GetLastErrorMessage()
        {
            var errorCode = Marshal.GetLastWin32Error();

            const int msgCapacity = 256;
            var message = new string('\0', msgCapacity);

            var result = FormatMessageW(FORMAT_MESSAGE_FROM_SYSTEM, nint.Zero, (uint)errorCode, 0, message, (uint)msgCapacity, nint.Zero);
            return result == 0 ? $"Unknown error code: {errorCode}" : message.TrimEnd('\0').Trim();
        }
    }
}