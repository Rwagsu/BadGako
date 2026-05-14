using System.Collections.Generic;
using BadGako.Models.Classes.ViewClasses;
using BadGako.Models.Data.ViewData;

namespace BadGako.Services.ViewServices;

public class MainWindowService {
    public List<MainNavViewItem> NavItems {
        get => MainWindowData.navItems;
        set => MainWindowData.navItems.AddRange(value);
    }
}