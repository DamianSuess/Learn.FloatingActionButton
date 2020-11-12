using App2.Views;
using Prism.Commands;
using Prism.Navigation;

namespace App2.ViewModels
{
  public class MainPageViewModel : ViewModelBase
  {
    public MainPageViewModel(INavigationService nav) : base(nav)
    {
      Title = "Main Page";
    }

    public DelegateCommand CmdNavigatePage2 => new DelegateCommand(OnNavigatePage2);

    private async void OnNavigatePage2()
    {
      await NavigationService.NavigateAsync(nameof(ContentPage2));
    }
  }
}
