using System.Collections.Generic;
using BadGako.Models.Classes.ViewClasses;
using BadGako.Views.Pages;
using FluentAvalonia.UI.Controls;

namespace BadGako.Models.Data.ViewData;

public static class MainWindowData {
    internal static List<MainNavViewItem> navItems = new List<MainNavViewItem>() {
        new MainNavViewItem() {
            Title = Strings.MainNavBarResources.MainPageTitle,
            Icon = new FASymbolIconSource() {Symbol = FASymbol.Home},
            TargetPage = typeof(MainPage)
        }
    };
}