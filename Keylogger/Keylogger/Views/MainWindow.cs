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

            CmbBoxKeyboardEvents.Items.AddRange([.. KeyboardEvents.Keys.Take(2)]);
            CmbBoxKeyboardEvents.SelectedIndex = 0; // Default to "Key Down"
            UpdateSelectedKeyboardEventPredicate();

            CmbBoxKeyFilter.Items.AddRange([.. KeyFilters.Keys]);
            CmbBoxKeyFilter.SelectedIndex = 1; // Default to "Printable characters"

            CmbBoxMouseEvents.Items.AddRange([.. MouseEvents]);
            CmbBoxMouseEvents.SelectedIndex = 0; // Default to "Mouse Up & Down"
            UpdateSelectedMouseEventPredicate();

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

        private void LogMouseButtons(string mouseButton, string position, string processName)
        {
            if (ShouldDisplayMouseButton(mouseButton, _selectedMouseButtonFilter))
            {
                var time = DateTime.Now.ToString("hh:mm:ss tt");
                var format = "{0,-15}{1,-21}{2,18}{3,30}";
                var finalMessage = string.Format(format, time, mouseButton, position, processName);

                RichTxtMouseButtons.AppendText(finalMessage + Environment.NewLine);
            }
        }

        private void LogMousePosition(string message, string position, string processName)
        {
            string time = DateTime.Now.ToString("hh:mm:ss tt");
            var format = "{0,-15}{1,-13}{2,18}{3,30}";
            var finalMessage = string.Format(format, time, message, position, processName);

            RichTxtMousePosition.AppendText(finalMessage + Environment.NewLine);
        }

        private void UpdateSelectedKeyboardEventPredicate()
        {
            var selectedKey = CmbBoxKeyboardEvents.SelectedItem?.ToString();
            if (selectedKey is not null && KeyboardEvents.TryGetValue(selectedKey, out var predicate))
            {
                KeyboardHook.SelectedKeyboardEventPredicate = predicate;
            }
        }

        private void UpdateSelectedKeyFilter()
        {
            var selectedKey = CmbBoxKeyFilter.SelectedItem?.ToString();
            if (selectedKey is not null && KeyFilters.TryGetValue(selectedKey, out var filter))
            {
                _selectedKeyFilter = filter;
                CmbBoxKeyboardEvents.Items.Clear();

                if (filter == KeyFilter.FunctionKeys || filter == KeyFilter.ModifierKeys)
                {
                    CmbBoxKeyboardEvents.Items.AddRange([.. KeyboardEvents.Keys.TakeLast(2)]);
                    CmbBoxKeyboardEvents.SelectedIndex = 0; // Default to "Key Down & Sys Key Down"
                    UpdateSelectedKeyboardEventPredicate();
                    return;
                }

                if (filter == KeyFilter.PrintableCharacters || filter == KeyFilter.NonPrintableKeys)
                {
                    CmbBoxKeyboardEvents.Items.AddRange([.. KeyboardEvents.Keys.Take(2)]);
                    CmbBoxKeyboardEvents.SelectedIndex = 0; // Default to "Key Down"
                    UpdateSelectedKeyboardEventPredicate();
                    return;
                }

                CmbBoxKeyboardEvents.Items.AddRange([.. KeyboardEvents.Keys]);
                CmbBoxKeyboardEvents.SelectedIndex = 0; // Default to "Key Down"
                UpdateSelectedKeyboardEventPredicate();
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

        private void UpdateSelectedMouseEventPredicate()
        {
            var selectedKey = CmbBoxMouseEvents.SelectedItem?.ToString();
            if (selectedKey is not null &&
                MouseEventPredicates.TryGetValue((_selectedMouseButtonFilter, selectedKey), out var predicate))
            {
                MouseHook.SelectedMouseEventPredicate = predicate;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e) => _hookService.InstallHooks();

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) => _hookService.UninstallHooks();

        private void CmbBoxKeyboardEvents_SelectedIndexChanged(object sender, EventArgs e) => UpdateSelectedKeyboardEventPredicate();

        private void CmbBoxKeyFilter_SelectedIndexChanged(object sender, EventArgs e) => UpdateSelectedKeyFilter();

        private void CmbBoxCaptureMouseButtons_SelectedIndexChanged(object sender, EventArgs e) => UpdateSelectedMouseButtonFilter();

        private void CmbBoxMouseEvents_SelectedIndexChanged(object sender, EventArgs e) => UpdateSelectedMouseEventPredicate();
    }
}