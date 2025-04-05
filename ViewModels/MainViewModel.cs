using BatchProcess3.Data;
using BatchProcess3.Factories;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BatchProcess3.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private readonly PageFactory  _pageFactory;
    
    [ObservableProperty] private bool _sideMenuExpanded = true;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(HomePageIsActive))]
    [NotifyPropertyChangedFor(nameof(ProcessPageIsActive))]
    [NotifyPropertyChangedFor(nameof(MacrosPageIsActive))]
    [NotifyPropertyChangedFor(nameof(HistoryPageIsActive))]
    [NotifyPropertyChangedFor(nameof(ReporterPageIsActive))]
    [NotifyPropertyChangedFor(nameof(ActionsPageIsActive))]
    [NotifyPropertyChangedFor(nameof(SettingsPageIsActive))]
    private PageViewModel _currentPage;

    public bool HomePageIsActive => CurrentPage.PageName == ApplicationPageNames.Home;
    public bool ProcessPageIsActive => CurrentPage.PageName == ApplicationPageNames.Process;
    public bool ActionsPageIsActive => CurrentPage.PageName == ApplicationPageNames.Actions;
    public bool SettingsPageIsActive => CurrentPage.PageName == ApplicationPageNames.Settings;
    public bool MacrosPageIsActive => CurrentPage.PageName == ApplicationPageNames.Macros;
    public bool ReporterPageIsActive => CurrentPage.PageName == ApplicationPageNames.Reporter;
    public bool HistoryPageIsActive => CurrentPage.PageName == ApplicationPageNames.History;

    /// <summary>
    /// Design-time only constructor
    /// </summary>
    public MainViewModel()
    {
        CurrentPage = new SettingsPageViewModel();
    }
    
    public MainViewModel(PageFactory pageFactory)
    {
        _pageFactory = pageFactory;
        
        GotToHome();
    }

    [RelayCommand]
    private void SideMenuResize()
    {
        SideMenuExpanded = !SideMenuExpanded;
    }

    [RelayCommand]
    private void GotToHome()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Home);
    }

    [RelayCommand]
    private void GotToProcess()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Process);
    }

    [RelayCommand]
    private void GotToActions()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Actions);
    }

    [RelayCommand]
    private void GotToHistory()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.History);
    }

    [RelayCommand]
    private void GotToMacros()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Macros);
    }

    [RelayCommand]
    private void GotToReporter()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Reporter);
    }

    [RelayCommand]
    private void GotToSettings()
    {
        CurrentPage = _pageFactory.GetPageViewModel(ApplicationPageNames.Settings);
    }
}