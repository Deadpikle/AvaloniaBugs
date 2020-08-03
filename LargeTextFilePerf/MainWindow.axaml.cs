using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.IO;

namespace LargeTextFilePerf
{
    public class MainWindow : Window
    {
        private TextBlock _licenseText;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            using (TextReader tr = new StreamReader(@"Licenses.txt"))
            {
                string myText = tr.ReadToEnd();
                _licenseText.Text = myText;
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            _licenseText = this.Find<TextBlock>("LicensesText");
        }
    }
}
