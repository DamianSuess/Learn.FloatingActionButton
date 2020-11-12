using System;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using App2.ViewModels;
using App2.Views;

namespace App2
{
  public partial class App // : Application
  {
    public App() : this(null)
    {
    }

    public App(IPlatformInitializer initializer) : base(initializer)
    {
    }

    protected override async void OnInitialized()
    {
      InitializeComponent();

      var nav = await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}");
      if (!nav.Success)
      {
        // Log the message, break, or throw an exception
        Console.WriteLine(nav.Exception.Message);
        System.Diagnostics.Debugger.Break();

        throw new System.Exception(nav.Exception.Message);
      }
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      // Navigation
      containerRegistry.RegisterForNavigation<NavigationPage>();
      containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
      containerRegistry.RegisterForNavigation<ContentPage2, ContentPage2ViewModel>();
    }

    protected override void OnResume()
    {
      base.OnResume();

      // TODO: Refresh network data, perform UI updates, and reacquire resources like cameras, I/O devices, etc.
    }

    protected override void OnSleep()
    {
      base.OnSleep();

      // TODO: This is the time to save app data in case the process is terminated.
      // This is the perfect timing to release exclusive resources (camera, I/O devices, etc...)
    }

    ////public App()
    ////{
    ////  InitializeComponent();
    ////  MainPage = new MainPage();
    ////}
  }
}
