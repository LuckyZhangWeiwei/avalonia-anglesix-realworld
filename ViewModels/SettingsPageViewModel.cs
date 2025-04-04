using BatchProcess3.Data;

namespace BatchProcess3.ViewModels;

public partial class SettingsPageViewModel : PageViewModel
{
    public SettingsPageViewModel()
    {
        PageName = ApplicationPageNames.Settings;
    }

    public string Test { get; set; } = ApplicationPageNames.Settings.ToString();
}