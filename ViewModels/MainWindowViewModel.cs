using Avalonia.Controls.ApplicationLifetimes;
using NSShowDialogTest.Views;
using ReactiveUI;
using System;
using System.Reactive;

namespace NSShowDialogTest.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {        
        public ViewModelActivator Activator { get; }
       
        public ReactiveCommand<Unit, Unit> ExitButtonClicked { get; }
       

        public MainWindowViewModel()
        {         
            Activator = new ViewModelActivator();

            ExitButtonClicked = ReactiveCommand.CreateFromTask(async () =>
            {
                var yesNoConfirmDialog = new YesNoConfirmDialog();
                var yesNoConfirmDialogViewModel = new YesNoConfirmDialogViewModel();
                yesNoConfirmDialogViewModel.StringValue = "Exit?";
                yesNoConfirmDialog.DataContext = yesNoConfirmDialogViewModel;

                var mainWindow = (App.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.MainWindow;
                var result = await yesNoConfirmDialog.ShowDialog<Boolean>(mainWindow);
                if (result)
                {
                    (App.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime)?.Shutdown();
                }
            });
        }
    }
}
