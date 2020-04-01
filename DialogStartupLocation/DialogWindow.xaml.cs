using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DialogStartupLocation
{
    public class DialogWindow : Window
    {
        public DialogWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
