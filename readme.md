## Floating Action Button using Xamarin.Forms and Prism.Forms

This is an example of the [FloatingActionButton NuGet](https://github.com/cemozguraA/Xamarin.RisePlugin.Floatingactionbutton) using [Xamarin.Forms](https://dotnet.microsoft.com/apps/xamarin/xamarin-forms) and [Prism.Forms](https://github.com/PrismLibrary/Prism).

In this example, we'll be be demonstrating how you can still use MVVM and navigate to a new Page via the FAB's menu buttons.

## What is does
According to the author, _FAB is a button that will work on 'RootView' so you don't need set it to any page. If you want, you can add sub-elements and use it in 5 different ways._

### What it does not do
Though this package still needs some work, I like where the author is heading!  Can't wait to see future releases.

Currently, it does not support the following:
* Does not support Command Binding to your ViewModel
  * _Workaround provided in this sample_
* Does not support Xamarin.Forms 4.8 - _Example uses v4.4_
* Does not support Prism.Forms 8.0 - _Must use 7.2 or lower_
* After navigating, the floating menu does not collapse
* Navigating back creates additional menu-buttons

### Command Binding Workaround
To get around this lack of functionality:
1. Wire-up your ViewModel command as you normally would.
2. Next, slap in the ``CanExecute()`` and ``Execute()`` in the *Click event* like so

**MainPage.xaml.cs**
```cs
    private void BtnSub4_ClickActionButton(object sender, EventArgs e)
    {
      MainPageViewModel viewModel = (MainPageViewModel)this.BindingContext;
      if (viewModel.CmdNavigatePage2.CanExecute())
      {
        viewModel.CmdNavigatePage2.Execute();
      }
    }
```

**MainPageViewModel.cs**
```cs
    public DelegateCommand CmdNavigatePage2 => new DelegateCommand(OnNavigatePage2);

    private async void OnNavigatePage2()
    {
      await NavigationService.NavigateAsync(nameof(ContentPage2));
    }
```

## Specifications
![](https://github.com/cemozguraA/Xamarin.RisePlugin.Floatingactionbutton/blob/master/Images/CircleDroidGroup.gif?raw=true)
![](https://github.com/cemozguraA/Xamarin.RisePlugin.Floatingactionbutton/blob/master/Images/VerticalHorizDroid.gif?raw=true)


### Platform Support
As of v1.0.0, the following patforms are supported

| Platforms  |
| ------------- |
| IOS  |
| Android  |

### Properties
| Property  | What it does |
| ------------- | ------------|
| Open  | Adding 'Mainbutton' to the rootview. |
| Close  | Deletes 'Mainbutton' to the rootview. |
| CircleAngle  | Set the distance between the circle. |
| SubViewSpacing  | Set spacing between subviews |
| ActionOrientation  | MainButton position (left, center, right)|
| OpeningType  | Subviews opening type (Circle, VerticalTop, VerticalBottom, HorizontalLeft, HorizontalRight)|
| MainButtonView  | Set Mainbutton(Use ActionButtonView)|
| IsSubShowing  | Check SubViews|
| IsShowing  | Check Floatingactionbutton|
| SubViews  | List of subview |
| ShowSubView  | With animation |
| HideSubView  | With animation |

### Nuget Package
#### Step1
Add the NuGet package to your solution.
* [https://www.nuget.org/packages/Xamarin.RisePlugin.Floatingactionbutton](https://www.nuget.org/packages/Xamarin.RisePlugin.Floatingactionbutton)

#### Step2 (iOS)

You must add this line to your AppDelegate.cs before you use FloatingActionButton
```csharp
COAFloatingactionbutton.Init();
```
#### Step2 (ANDROID)
You must add this code to your ``MainActivity.cs`` before you use FloatingActionButton

```csharp
public override void SetContentView(Android.Views.View view)
{
  Xamarin.RisePlugin.Droid.Floatingactionbutton.RootView.View = (Android.Widget.RelativeLayout)view;
  base.SetContentView(view);
}
```



