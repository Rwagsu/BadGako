using Avalonia.Controls;
using BadGako.ViewModels;

namespace BadGako.Views;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        DataContext = new MainWindowViewModel();
    }
}