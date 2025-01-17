using Keylogger.Controllers;

namespace Keylogger.Views
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            _ = new MainWindowController(this);
        }
    }
}