using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace DataGridPreview
{
    public class LooksFine : UserControl
    {
        public LooksFine()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
