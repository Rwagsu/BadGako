using System;
using FluentAvalonia.UI.Controls;

namespace BadGako.Models.Classes.ViewClasses;

public class MainNavViewItem {
    
    // NavItem Title
    public required string Title { get; set; }
    
    // NavItem Icon
    public required FAIconSource Icon { get; set; }
    
    // The page to navigate to
    public required Type TargetPage  { get; set; }
}