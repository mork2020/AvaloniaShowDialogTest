using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using NSShowDialogTest.ViewModels;

namespace NSShowDialogTest.Views
{
    public class MainWindow : ReactiveWindow<MainWindowViewModel>
    {        
        public MainWindow()
        {            
            this.WindowState = WindowState.FullScreen;
            this.SystemDecorations = SystemDecorations.None;
          
            InitializeComponent();
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
