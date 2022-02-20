using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
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

            try
            {
                {
                    using (TextReader tr = new StreamReader(@"Licenses.txt"))
                    {
                        string myText = tr.ReadToEnd();
                        _licenseText.Text = myText;
                    }
                }
            }
            catch (Exception e)
            {
                // ommitted
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            _licenseText = this.Find<TextBlock>("LicensesText");
        }
    }
}
