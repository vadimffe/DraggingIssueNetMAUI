using Microsoft.Maui.Platform;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DraggingIssueNetMAUI.WinUI;

/// <summary>
/// Provides application-specific behavior to supplement the default Application class.
/// </summary>
public partial class App : MauiWinUIApplication
{
	/// <summary>
	/// Initializes the singleton application object.  This is the first line of authored code
	/// executed, and as such is the logical equivalent of main() or WinMain().
	/// </summary>
	public App()
	{
		this.InitializeComponent();

    Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
    {
      var nativeWindow = handler.PlatformView;
      var appWindow = nativeWindow.GetAppWindow();
      if (appWindow is not null)
      {
        appWindow.Changed += (sender, args) =>
        {
          if (appWindow.Presenter is OverlappedPresenter overlappedPresenter)
          {
            if (args.DidPresenterChange && overlappedPresenter.State == OverlappedPresenterState.Minimized)
            {
              appWindow.Hide();
              //Thread.Sleep(5000);
              //nativeWindow.Activate();
            }
          }
        };
      }
    });
  }

	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}

