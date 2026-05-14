using Avalonia.Controls;
using BadGako.Models.Classes;
using BadGako.Models.Classes.Enums;
using BadGako.ViewModels.Windows;
using CommunityToolkit.Mvvm.Messaging;

namespace BadGako.Views.Windows;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        DataContext = App.GetService<MainWindowViewModel>();
        
        // Message
        // Navigate Message
        WeakReferenceMessenger.Default.Register<NavigateMessage, string>(this, nameof(NavigateionMessageEnum.MainFrameNavigate), NavigateToPage);
        
        // Go Back Message
        WeakReferenceMessenger.Default.Register<GoBackMessage, string>(this, nameof(NavigateionMessageEnum.MainFrameGoBack), FrameGoBack);
    }

    private void NavigateToPage(object recipient, NavigateMessage message) {
        MainFrame.Navigate(message.PageType);
    }

    private void FrameGoBack(object recipient, GoBackMessage message) {
        if (MainFrame.CanGoBack) {
            MainFrame.GoBack();
        }
    }
}