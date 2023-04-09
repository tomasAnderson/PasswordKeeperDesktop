using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using PasswordKeeper.Model;

namespace PasswordKeeper.ViewModel;

public class ItemViewModel : ViewModelBase
{
    private ObservableCollection<ItemModel> _itemModels = new();

    public ObservableCollection<ItemModel> ItemModels
    {
        get => _itemModels;
        set => Set(() => ItemModels, ref _itemModels, value);
    }

    public ItemViewModel()
    {
        ItemModels = new ObservableCollection<ItemModel>()
        {
            new() {Id = 1, ServiceName = "github andrey", Login = "login", Password = "1234"},
            new() {Id = 2, ServiceName = "github tomas", Login = "login", Password = "1234333"},
            new() {Id = 3, ServiceName = "google", Login = "login", Password = "1234HyJ"}
        };
    }
}