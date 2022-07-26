using System;
using System.ComponentModel;
using App2.ViewModels;
using Xamarin.Forms;
using Xamarin.RisePlugin.Floatingactionbutton;
using Xamarin.RisePlugin.Floatingactionbutton.Enums;

namespace App2
{
  // Learn more about making custom code visible in the Xamarin.Forms previewer
  // by visiting https://aka.ms/xamarinforms-previewer
  [DesignTimeVisible(false)]
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      // Wireup();

    }

    protected override void OnAppearing()
    {
      Wireup();
    }

    private void Wireup()
    {
      var btn = new ActionButtonView() { BackgroundColor = Color.Aqua, SelectedColor = Color.Brown, HeightRequest = 50, Icon = "logo.png" };

      btn.Margin = new Thickness(20, 10, 10, Device.RuntimePlatform == Device.Android ? 160 : 10);
      var btnSub1 = new ActionButtonView() { BackgroundColor = Color.IndianRed, HeightRequest = 50, SelectedColor = Color.Pink, Icon = "tab_feed.png" };
      var btnSub2 = new ActionButtonView() { BackgroundColor = Color.Orange, HeightRequest = 50, SelectedColor = Color.Pink, Icon = "logo.png" };
      var btnSub3 = new ActionButtonView() { BackgroundColor = Color.OrangeRed, HeightRequest = 50, SelectedColor = Color.Pink, Icon = "logo.png" };
      var btnSub4 = new ActionButtonView() { BackgroundColor = Color.Maroon, HeightRequest = 50, SelectedColor = Color.Pink, Icon = "logo.png" };
      var btnSub5 = new ActionButtonView() { BackgroundColor = Color.Lime, HeightRequest = 50, SelectedColor = Color.Pink, Icon = "logo.png" };
      var btnSub6 = new ActionButtonView() { BackgroundColor = Color.LightGreen, SelectedColor = Color.Pink, Icon = "logo.png" };

      btnSub1.Click += BtnSub1_Click;
      btnSub2.Click += BtnSub2_Click;
      btnSub3.Click += BtnSub3_Click;
      btnSub4.Click += BtnSub4_Click;

      btnSub1.LongClick += BtnSub1_LongClick;

      COAFloatingactionbutton.Current.SubViews.Add(btnSub1);
      COAFloatingactionbutton.Current.SubViews.Add(btnSub2);
      COAFloatingactionbutton.Current.SubViews.Add(btnSub3);
      COAFloatingactionbutton.Current.SubViews.Add(btnSub4);
      COAFloatingactionbutton.Current.SubViews.Add(btnSub5);

      btn.Click += Btn_ClickActionButton;
      COAFloatingactionbutton.Current.ActionOrientation = StackActionOrientation.Center;
      COAFloatingactionbutton.Current.OpeningType = ActionOpeningType.Circle;
      COAFloatingactionbutton.Current.CircleAngle = 150;
      COAFloatingactionbutton.Current.MainButtonView = btn;
      COAFloatingactionbutton.Current.Open();
    }

    private void BtnSub1_LongClick(object sender, EventArgs e)
    {
      // Initiate long-click
      COAFloatingactionbutton.Current.ActionOrientation = StackActionOrientation.Center;
    }

    private void BtnSub1_Click(object sender, EventArgs e)
    {
      COAFloatingactionbutton.Current.ActionOrientation = StackActionOrientation.Center;
    }

    private void BtnSub2_Click(object sender, EventArgs e)
    {
      COAFloatingactionbutton.Current.ActionOrientation = StackActionOrientation.Right;
    }

    private void BtnSub3_Click(object sender, EventArgs e)
    {
      COAFloatingactionbutton.Current.ActionOrientation = StackActionOrientation.Left;
    }

    private void BtnSub4_Click(object sender, EventArgs e)
    {
      MainPageViewModel viewModel = (MainPageViewModel)this.BindingContext;
      if (viewModel.CmdNavigatePage2.CanExecute())
      {
        viewModel.CmdNavigatePage2.Execute();
      }
    }

    private async void Btn_ClickActionButton(object sender, EventArgs e)
    {
      if (!COAFloatingactionbutton.Current.IsSubShowing)
        await COAFloatingactionbutton.Current.ShowSubView();
      else
        await COAFloatingactionbutton.Current.HideSubView();
    }
  }
}
