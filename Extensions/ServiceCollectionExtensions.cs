using BadGako.Services;
using BadGako.Services.ViewServices;
using BadGako.ViewModels.Pages;
using BadGako.ViewModels.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace BadGako.Extensions;

public static partial class ServiceCollectionExtensions {
    public static void AddCommonServices(this IServiceCollection collection) {
        collection.AddSingleton<PathService>();
        
        // UIServices
        collection.AddSingleton<MainWindowService>();
        
        // ViewModels
        collection.AddSingleton<MainWindowViewModel>();
    }
}