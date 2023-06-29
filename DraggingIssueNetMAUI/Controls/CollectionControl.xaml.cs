namespace DraggingIssueNetMAUI.Controls;

public partial class CollectionControl : ContentView
{
	public CollectionControl()
	{
		InitializeComponent();
	}

  private int TileCount = 0;
  private void OnHandlerChanged(object sender, EventArgs e)
  {
    Frame f = (Frame)sender;
    this.Tiles.Add(f);
    this.TileCount++;
  }

  private async Task TransitionIn()
  {
    foreach (Frame item in this.Tiles)
    {
      //item.Opacity = 0;
      item.FadeTo(1, 500);
      await Task.Delay(300);
    }
  }

  List<Frame> Tiles = new List<Frame>();
}