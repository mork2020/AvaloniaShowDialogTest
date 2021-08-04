using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using NSShowDialogTest.ViewModels;

namespace NSShowDialogTest.Views
{
    public class YesNoConfirmDialog : ReactiveWindow<YesNoConfirmDialogViewModel>
    {
        public YesNoConfirmDialog()
        {           
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void BtYesClick(object sender, RoutedEventArgs args)
        {            
            Close(true);
        }

        public void BtNoClick(object sender, RoutedEventArgs args)
        {
            Close(false);
        }
    }
}
