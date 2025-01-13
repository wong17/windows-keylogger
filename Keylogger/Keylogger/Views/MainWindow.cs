using Keylogger.Hooks;
using Keylogger.Services;

namespace Keylogger.Views
{
    public partial class MainWindow : Form
    {
        private readonly HookService _hookService = new();

        public MainWindow()
        {
            InitializeComponent();
            KeyboardHook.CallBackMethod = LogKeyboardHook;
            MouseHook.CallBackMethod = LogMouseHook;
        }

        private void LogKeyboardHook(string message, string key)
        {
            TxtKeyboard.AppendText($"{key}");
        }

        private void LogMouseHook(string message, string position)
        {
            TxtMouse.AppendText($"{message}{position}\n");
        }

        private void MainWindow_Load(object sender, EventArgs e) => _hookService.InstallHooks();

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) => _hookService.UninstallHooks();
    }
}