using System.Diagnostics;
using System.Runtime.InteropServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using BadGako.ViewModels;

namespace BadGako.Views.Windows;

public partial class MainWindow : Window {
    
    public MainWindow() {
        InitializeComponent();

        DataContext = new MainWindowViewModel();
    }
}