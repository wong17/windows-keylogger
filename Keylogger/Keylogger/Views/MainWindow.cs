using Keylogger.Helpers.Enums;
using Keylogger.Hooks;
using Keylogger.Services;
using Keylogger.WMI;
using static Keylogger.Helpers.InputMessageHelper;
using static Keylogger.Helpers.KeyFilterHelper;
using static Keylogger.Helpers.MouseButtonFilterHelper;

namespace Keylogger.Views
{
    public partial class MainWindow : Form
    {
        private readonly HookService _hookService = new();

        private KeyFilter _selectedKeyFilter = KeyFilter.PrintableCharacters;
        private MouseButtonFilter _selectedMouseButtonFilter = MouseButtonFilter.All;

        public MainWindow()
        {
            InitializeComponent();

            ToolStripStatusLbl.Text = $"{Environment.MachineName} | {Win32OperatingSystem.GetOSVersion()}";

            CmbBoxEvents.Items.AddRange([.. KeyboardEvents.Keys.Take(2)]);
            CmbBoxEvents.SelectedIndex = 0; // Default to "Key Down"
            UpdateSelectedEventPredicate();

            CmbBoxKeyFilter.Items.AddRange([.. KeyFilters.Keys]);
            CmbBoxKeyFilter.SelectedIndex = 1; // Default to "Printable characters"

            CmbBoxCaptureMouseButtons.Items.AddRange([.. MouseButtonFilters.Keys]);
            CmbBoxCaptureMouseButtons.SelectedIndex = 0; // Default to "All"

            KeyboardHook.CallBackMethod = LogKeyboardHook;
            MouseHook.LogMouseButtonsCallback = LogMouseButtons;
            MouseHook.LogMousePositionCallback = LogMousePosition;
        }

        private void LogKeyboardHook(string message, string key, KeyType keyType)
        {
            if (ShouldDisplayKey(key, keyType, _selectedKeyFilter))
            {
                RichTxtKeyboard.AppendText($"{key}");
            }
        }

        private void LogMouseButtons(string mouseButton, string position)
        {
            if (ShouldDisplayMouseButton(mouseButton, _selectedMouseButtonFilter))
            {
                var time = DateTime.Now.ToString("hh:mm:ss tt");
                var format = "{0,-15}{1,-21}{2,18}";
                var finalMessage = string.Format(format, time, mouseButton, position);

                RichTxtMouseButtons.AppendText(finalMessage + Environment.NewLine);
            }
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

        private void UpdateSelectedKeyFilter()
        {
            var selectedKey = CmbBoxKeyFilter.SelectedItem?.ToString();
            if (selectedKey is not null && KeyFilters.TryGetValue(selectedKey, out var filter))
            {
                _selectedKeyFilter = filter;
                CmbBoxEvents.Items.Clear();

                if (filter == KeyFilter.FunctionKeys || filter == KeyFilter.ModifierKeys)
                {
                    CmbBoxEvents.Items.AddRange([.. KeyboardEvents.Keys.TakeLast(2)]);
                    CmbBoxEvents.SelectedIndex = 0; // Default to "Key Down & Sys Key Down" 
                    UpdateSelectedEventPredicate();
                    return;
                }

                if (filter == KeyFilter.PrintableCharacters || filter == KeyFilter.NonPrintableKeys)
                {
                    CmbBoxEvents.Items.AddRange([.. KeyboardEvents.Keys.Take(2)]);
                    CmbBoxEvents.SelectedIndex = 0; // Default to "Key Down" 
                    UpdateSelectedEventPredicate();
                    return;
                }

                CmbBoxEvents.Items.AddRange([.. KeyboardEvents.Keys]);
                CmbBoxEvents.SelectedIndex = 0; // Default to "Key Down"
                UpdateSelectedEventPredicate();
            }
        }

        private void UpdateSelectedMouseButtonFilter()
        {
            var selectedKey = CmbBoxCaptureMouseButtons.SelectedItem?.ToString();
            if (selectedKey is not null && MouseButtonFilters.TryGetValue(selectedKey, out var filter))
            {
                _selectedMouseButtonFilter = filter;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e) => _hookService.InstallHooks();

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) => _hookService.UninstallHooks();

        private void CmbBoxEvents_SelectedIndexChanged(object sender, EventArgs e) => UpdateSelectedEventPredicate();

        private void CmbBoxKeyFilter_SelectedIndexChanged(object sender, EventArgs e) => UpdateSelectedKeyFilter();

        private void CmbBoxCaptureMouseButtons_SelectedIndexChanged(object sender, EventArgs e) => UpdateSelectedMouseButtonFilter();
    }
}