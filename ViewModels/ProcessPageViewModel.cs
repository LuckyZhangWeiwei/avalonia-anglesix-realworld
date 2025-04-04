using BatchProcess3.Data;

namespace BatchProcess3.ViewModels;

public partial class ProcessPageViewModel : PageViewModel
{
    public ProcessPageViewModel()
    {
        PageName = ApplicationPageNames.Process;
    }

    public string Test { get; set; } = ApplicationPageNames.Process.ToString();
}