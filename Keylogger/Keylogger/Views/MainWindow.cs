using Keylogger.Hooks;
using Keylogger.Services;
using static Keylogger.Interop.Win32ApiHelper;

namespace Keylogger.Views
{
    public partial class MainWindow : Form
    {
        private readonly HookService _hookService = new();

        public MainWindow()
        {
            InitializeComponent();

            CmbBoxEvents.Items.AddRange([.. KeyboardEvents.Keys]);
            CmbBoxEvents.SelectedIndex = 0;
            UpdateSelectedEventPredicate();

            KeyboardHook.CallBackMethod = LogKeyboardHook;
            MouseHook.LogMouseButtonsCallback = LogMouseButtons;
            MouseHook.LogMousePositionCallback = LogMousePosition;
        }

        private void LogKeyboardHook(string message, string key)
        {
            RichTxtKeyboard.AppendText($"{key}");
        }

        private void LogMouseButtons(string message, string position)
        {
            RichTxtMouseButtons.AppendText($"{message}{position}\n");
        }

        private void LogMousePosition(string message, string position)
        {
            RichTxtMousePosition.AppendText($"{message}{position}\n");
        }

        private void UpdateSelectedEventPredicate()
        {
            var selectedKey = CmbBoxEvents.SelectedItem?.ToString();
            if (selectedKey is not null && KeyboardEvents.TryGetValue(selectedKey, out var predicate))
            {
                KeyboardHook.SelectedEventPredicate = predicate;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e) => _hookService.InstallHooks();

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) => _hookService.UninstallHooks();

        private void CmbBoxEvents_SelectedIndexChanged(object sender, EventArgs e) => UpdateSelectedEventPredicate();
    }
}