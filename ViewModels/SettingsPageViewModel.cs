using System.Collections.Generic;
using BatchProcess3.Data;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BatchProcess3.ViewModels;

public partial class SettingsPageViewModel : PageViewModel
{
    [ObservableProperty] private List<string> _locationPaths;

    public SettingsPageViewModel()
    {
        PageName = ApplicationPageNames.Settings;

        LocationPaths = ["LocationPaths1", "LocationPaths2", "LocationPaths3"];
    }
}