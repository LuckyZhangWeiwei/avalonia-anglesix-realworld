using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BatchProcess3.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private bool _sideMenuExpanded = true;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HomePageIsActive))]
    [NotifyPropertyChangedFor(nameof(ProcessPageIsActive))]
    private ViewModelBase _currentPage;

    public bool HomePageIsActive => CurrentPage == _homePage;
    public bool ProcessPageIsActive => CurrentPage == _processPage;

    private readonly HomePageViewModel _homePage = new();
    private readonly ProcessPageViewModel _processPage = new();

    public MainViewModel()
    {
        CurrentPage = _homePage;
    }

    [RelayCommand]
    private void SideMenuResize()
    {
        SideMenuExpanded = !SideMenuExpanded;
    }

    [RelayCommand]
    private void GotToHome()
    {
        CurrentPage = _homePage;
    }

    [RelayCommand]
    private void GotToProcess()
    {
        CurrentPage = _processPage;
    }
}