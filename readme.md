## Floating Action Button using Xamarin.Forms and Prism.Forms

This is an example of the [FloatingActionButton NuGet](https://github.com/cemozguraA/Xamarin.RisePlugin.Floatingactionbutton) using Xamarin.Forms and Prism.Forms.

## What is it
FAB is a button that will work on 'RootView' so you dont need set it to any page. If you want, you can add sub-elements and use it in 5 different ways

### Still Needs Work
Though this NuGet still needs some work, I like where the author is heading!  Can't wait to see future releases.

Currently, it does not support the following:
* Does not support Command Binding to your ViewModel
  * _Workaround provided in this sample_
* After navigating, the floating menu does not collapse
* Navigating back creates additional buttons
* Does not support Xamarin.Forms 4.8 - _Example uses v4.4_
* Does not support Prism.Forms 8.0 - _Must use 7.2 or lower_

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

### NugetPackage
[https://www.nuget.org/packages/Xamarin.RisePlugin.Floatingactionbutton](https://www.nuget.org/packages/Xamarin.RisePlugin.Floatingactionbutton)
- **Step1**

Add the following NuGet package to your solution.
- **Step2 (IOS)**

You must add this line to your AppDelegate.cs before you use Floatingactionbutton
 ```csharp
COAFloatingactionbutton.Init();
```
- **Step2 (ANDROID)**

You must add this code to your MainActivity.cs before you use Floatingactionbutton
 ```csharp
public override void SetContentView(Android.Views.View view)
{
  Xamarin.RisePlugin.Droid.Floatingactionbutton.RootView.View = (Android.Widget.RelativeLayout)view;
  base.SetContentView(view);
}
```



