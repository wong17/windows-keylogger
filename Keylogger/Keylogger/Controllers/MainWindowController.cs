using Keylogger.Helpers.Enums;
using Keylogger.Hooks;
using Keylogger.Services;
using Keylogger.Views;
using Keylogger.WMI;
using static Keylogger.Helpers.InputMessageHelper;
using static Keylogger.Helpers.KeyFilterHelper;
using static Keylogger.Helpers.MouseButtonFilterHelper;

namespace Keylogger.Controllers
{
    internal class MainWindowController
    {
        private readonly MainWindow _mainWindow;

        private readonly HookService _hookService = new();

        private KeyFilter _selectedKeyFilter = KeyFilter.PrintableCharacters;
        private MouseButtonFilter _selectedMouseButtonFilter = MouseButtonFilter.All;

        public MainWindowController(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;

            SetupEvents();

            _mainWindow.ToolStripStatusLbl.Text = $"{Environment.MachineName} | {Win32OperatingSystem.GetOSVersion()}";

            SetupKeyboardHookControls();
            SetupMouseHookControls();

            KeyboardHook.LogKeyCallback = LogKeyboardHook;
            MouseHook.LogMouseButtonsCallback = LogMouseButtons;
            MouseHook.LogMousePositionCallback = LogMousePosition;
        }

        private void SetupEvents()
        {
            _mainWindow.Load += (_, _) => _hookService.InstallHooks();
            _mainWindow.FormClosing += (_, _) => _hookService.UninstallHooks();

            _mainWindow.CmbBoxKeyboardEvents.SelectedIndexChanged += (_, _) => UpdateSelectedKeyboardEventPredicate();
            _mainWindow.CmbBoxKeyFilter.SelectedIndexChanged += (_, _) => UpdateSelectedKeyFilter();
            _mainWindow.CmbBoxCaptureMouseButtons.SelectedIndexChanged += (_, _) => UpdateSelectedMouseButtonFilter();
            _mainWindow.CmbBoxMouseEvents.SelectedIndexChanged += (_, _) => UpdateSelectedMouseEventPredicate();
        }

        private void SetupKeyboardHookControls()
        {
            _mainWindow.CmbBoxKeyboardEvents.Items.AddRange([.. KeyboardEvents.Keys.Take(2)]);
            _mainWindow.CmbBoxKeyboardEvents.SelectedIndex = 0; // Default to "Key Down"
            UpdateSelectedKeyboardEventPredicate();

            _mainWindow.CmbBoxKeyFilter.Items.AddRange([.. KeyFilters.Keys]);
            _mainWindow.CmbBoxKeyFilter.SelectedIndex = 1; // Default to "Printable characters"
        }

        private void SetupMouseHookControls()
        {
            _mainWindow.CmbBoxMouseEvents.Items.AddRange([.. MouseEvents]);
            _mainWindow.CmbBoxMouseEvents.SelectedIndex = 0; // Default to "Mouse Up & Down"
            UpdateSelectedMouseEventPredicate();

            _mainWindow.CmbBoxCaptureMouseButtons.Items.AddRange([.. MouseButtonFilters.Keys]);
            _mainWindow.CmbBoxCaptureMouseButtons.SelectedIndex = 0; // Default to "All"
        }

        private void LogKeyboardHook(string message, string key, KeyType keyType)
        {
            if (ShouldDisplayKey(key, keyType, _selectedKeyFilter))
            {
                _mainWindow.RichTxtKeyboard.AppendText($"{key}");
            }
        }

        private void LogMouseButtons(string mouseButton, string position, string processName)
        {
            if (ShouldDisplayMouseButton(mouseButton, _selectedMouseButtonFilter))
            {
                var time = DateTime.Now.ToString("dd-MM-yy hh:mm:ss tt");
                _mainWindow.DgViewMouseButtons.Rows.Add(time, mouseButton, position, processName);
                ScrollToLastRow(_mainWindow.DgViewMouseButtons);
            }
        }

        private void LogMousePosition(string message, string position, string processName)
        {
            var time = DateTime.Now.ToString("dd-MM-yy hh:mm:ss tt");
            _mainWindow.RichTxtMousePosition.AppendText(Environment.NewLine + $"{time} | {message} | {position} | {processName}");
        }

        private void UpdateSelectedKeyboardEventPredicate()
        {
            var selectedKey = _mainWindow.CmbBoxKeyboardEvents.SelectedItem?.ToString();
            if (selectedKey is not null && KeyboardEvents.TryGetValue(selectedKey, out var predicate))
            {
                KeyboardHook.SelectedKeyboardEventPredicate = predicate;
            }
        }

        private void UpdateSelectedKeyFilter()
        {
            var selectedKey = _mainWindow.CmbBoxKeyFilter.SelectedItem?.ToString();
            if (selectedKey is not null && KeyFilters.TryGetValue(selectedKey, out var filter))
            {
                _selectedKeyFilter = filter;
                _mainWindow.CmbBoxKeyboardEvents.Items.Clear();

                if (filter == KeyFilter.FunctionKeys || filter == KeyFilter.ModifierKeys)
                {
                    _mainWindow.CmbBoxKeyboardEvents.Items.AddRange([.. KeyboardEvents.Keys.TakeLast(2)]);
                    _mainWindow.CmbBoxKeyboardEvents.SelectedIndex = 0; // Default to "Key Down & Sys Key Down"
                    UpdateSelectedKeyboardEventPredicate();
                    return;
                }

                if (filter == KeyFilter.PrintableCharacters || filter == KeyFilter.NonPrintableKeys)
                {
                    _mainWindow.CmbBoxKeyboardEvents.Items.AddRange([.. KeyboardEvents.Keys.Take(2)]);
                    _mainWindow.CmbBoxKeyboardEvents.SelectedIndex = 0; // Default to "Key Down"
                    UpdateSelectedKeyboardEventPredicate();
                    return;
                }

                _mainWindow.CmbBoxKeyboardEvents.Items.AddRange([.. KeyboardEvents.Keys]);
                _mainWindow.CmbBoxKeyboardEvents.SelectedIndex = 0; // Default to "Key Down"
                UpdateSelectedKeyboardEventPredicate();
            }
        }

        private void UpdateSelectedMouseButtonFilter()
        {
            var selectedKey = _mainWindow.CmbBoxCaptureMouseButtons.SelectedItem?.ToString();
            if (selectedKey is not null && MouseButtonFilters.TryGetValue(selectedKey, out var filter))
            {
                _selectedMouseButtonFilter = filter;
            }
        }

        private void UpdateSelectedMouseEventPredicate()
        {
            var selectedKey = _mainWindow.CmbBoxMouseEvents.SelectedItem?.ToString();
            if (selectedKey is not null &&
                MouseEventPredicates.TryGetValue((_selectedMouseButtonFilter, selectedKey), out var predicate))
            {
                MouseHook.SelectedMouseEventPredicate = predicate;
            }
        }

        private static void ScrollToLastRow(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.Rows.Count - 1;
                dataGridView.ClearSelection();
                dataGridView.Rows[^1].Selected = true;
            }
        }
    }
}