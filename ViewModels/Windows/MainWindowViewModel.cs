
using System;
using System.Collections.Generic;
using System.Diagnostics;
using BadGako.Models.Classes;
using BadGako.Models.Classes.Enums;
using BadGako.Models.Classes.ViewClasses;
using BadGako.Services.ViewServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Newtonsoft.Json;

namespace BadGako.ViewModels.Windows;

public partial class MainWindowViewModel : ViewModelBase {
    private MainWindowService mainWindowService;
    public MainWindowViewModel() {
        mainWindowService = App.GetService<MainWindowService>();

        MainNavBarItems = mainWindowService.NavItems;
    }
    
    [ObservableProperty]
    public partial List<MainNavViewItem> MainNavBarItems { get; set; }
    
    [ObservableProperty]
    public partial int MainNavBarSelectedIndex { get; set; }

    [RelayCommand]
    private void NavigateToPage() {
        WeakReferenceMessenger.Default.Send(new NavigateMessage(MainNavBarItems[MainNavBarSelectedIndex].TargetPage), NavigateionMessageEnum.MainFrameNavigate.ToString());
    }
    
    
}