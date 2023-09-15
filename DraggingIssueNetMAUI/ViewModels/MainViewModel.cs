using DraggingIssueNetMAUI.Models;
using H.NotifyIcon;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DraggingIssueNetMAUI.ViewModels
{
  public class MainViewModel : BaseViewModel, IMainViewModel
  {
    public MainViewModel()
    {
      this.CollectionItems = new ObservableCollection<DataModel>();

      this.ShowHideWindowCommand = new Command(() => this.OnShowHideWindow());
      this.ExitApplicationCommand = new Command(() => this.OnExitApplication());

      this.InitializeItems();
    }

    public void SetIsWindowVisibleToFalse()
    {
      this.IsWindowVisible = false;
    }

    private void OnExitApplication()
    {
      Application.Current?.Quit();
    }

    private void OnShowHideWindow()
    {
      Window window = Application.Current?.MainPage?.Window;
      if (window == null)
      {
        return;
      }

      if (this.IsWindowVisible)
      {
        window.Hide();
        this.IsWindowVisible = false;
      }
      else
      {
        window.Show();
        window.Activate();
        this.IsWindowVisible = true;
      }
    }

    private void InitializeItems()
    {
      Random random = new Random();

      //var data = new List<DataModel>();

      for (int i = 0; i < 150; i++)
      {
        string itemName = $"Item {i + 1}";
        int itemId = random.Next(1000); // Generate a random ID between 0 and 999

        this.CollectionItems.Add(new DataModel { Id = itemId, Name = itemName });
      }

      //this.CollectionItems = new ObservableCollection<DataModel>(data);
    }

    public bool IsWindowVisible { get; set; } = true;

    private string id;
    public string Id
    {
      get => this.id;
      set
      {
        this.id = value;
        this.OnPropertyChanged();
      }
    }

    private string name;
    public string Name
    {
      get => this.name;
      set
      {
        this.name = value;
        this.OnPropertyChanged();
      }
    }

    private ObservableCollection<DataModel> collectionItems;
    public ObservableCollection<DataModel> CollectionItems
    {
      get => this.collectionItems;
      set
      {
        this.collectionItems = value;
        this.OnPropertyChanged();
      }
    }

    public ICommand ExitApplicationCommand { get; private set; }
    public ICommand ShowHideWindowCommand { get; private set; }
  }
}
