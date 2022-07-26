using Prism.Navigation;

namespace App2.ViewModels
{
  public class ContentPage2ViewModel : ViewModelBase
  {
    public ContentPage2ViewModel(INavigationService nav) : base(nav)
    {
      Title = "Sub Page 1";
    }
  }
}
