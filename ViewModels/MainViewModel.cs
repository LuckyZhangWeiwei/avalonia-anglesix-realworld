using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BatchProcess3.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] 
    private bool _sideMenuExpanded = true;

    [ObservableProperty]
    private ViewModelBase _currentPage;
    
    private readonly HomePageViewModel _homePage = new ();
    private readonly ProcessPageViewModel _processPage  = new ();

    public MainViewModel()
    {
        CurrentPage = _processPage;
    }

    [RelayCommand]
    private void SideMenuResize()
    {
        SideMenuExpanded = !SideMenuExpanded;
    }
}