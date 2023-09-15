using DraggingIssueNetMAUI.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DraggingIssueNetMAUI.ViewModels
{
  public interface IMainViewModel
  {
    ObservableCollection<DataModel> CollectionItems { get; set; }
    ICommand ExitApplicationCommand { get; }
    string Id { get; set; }
    bool IsWindowVisible { get; set; }
    string Name { get; set; }
    ICommand ShowHideWindowCommand { get; }

    void SetIsWindowVisibleToFalse();
  }
}