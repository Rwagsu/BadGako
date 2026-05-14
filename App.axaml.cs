using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using BadGako.Extensions;
using BadGako.Views.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace BadGako;

public class App : Application {

    private ServiceProvider? Services { get; set; }
    
    public new static App? Current => (App?)Application.Current;
    
    public override void Initialize() {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted() {
        // Register all the services needed for the application to run
        var collection = new ServiceCollection();
        collection.AddCommonServices();

        // Creates a ServiceProvider containing services from the provided IServiceCollection
        Services = collection.BuildServiceProvider();
        
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) {
            desktop.MainWindow = new MainWindow();
        }

        base.OnFrameworkInitializationCompleted();
    }

    public static T GetService<T>() {
        if (Current?.Services != null) {
            var service = Current.Services.GetRequiredService<T>();

            if (service != null) {
                return service;
            }
        }

        throw new InvalidOperationException($"Service of type {typeof(T)} not found.");
    }
}