using DraggingIssueNetMAUI.ViewModels;

namespace DraggingIssueNetMAUI;

public partial class MainPage : ContentPage
{
	public MainPage(IMainViewModel mainViewModel)
	{
		InitializeComponent();
    this.BindingContext = mainViewModel;
    this.MainViewModel = mainViewModel;
  }

  private IMainViewModel MainViewModel { get; set; }
}

