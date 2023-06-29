using DraggingIssueNetMAUI.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace DraggingIssueNetMAUI.ViewModels
{
  public interface IMainViewModel
  {
    ObservableCollection<DataModel> CollectionItems { get; set; }
  }
}