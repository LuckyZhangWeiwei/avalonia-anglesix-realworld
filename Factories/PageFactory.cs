using System;
using BatchProcess3.Data;
using BatchProcess3.ViewModels;

namespace BatchProcess3.Factories;

public class PageFactory
{
    private readonly Func<ApplicationPageNames, PageViewModel> factory;

    public PageFactory(Func<ApplicationPageNames, PageViewModel> pageViewModelFactory)
    {
        factory = pageViewModelFactory;
    }

    public PageViewModel GetPageViewModel(ApplicationPageNames pageName) => factory.Invoke(pageName);
}