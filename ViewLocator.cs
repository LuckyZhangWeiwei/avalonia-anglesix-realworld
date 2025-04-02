using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using BatchProcess3.ViewModels;

namespace BatchProcess3;

public class ViewLocator : IDataTemplate
{
    public Control? Build(object? data)
    {
        if (data is null) return null;

        var name = data.GetType().FullName!.Replace("ViewModel", "View", StringComparison.InvariantCulture);
        var type = Type.GetType(name);

        if (type is null) return null;

        var control = Activator.CreateInstance(type) as Control;
        control!.DataContext = data;

        return control;
    }

    public bool Match(object? data)
    {
        return data is ViewModelBase;
    }
}