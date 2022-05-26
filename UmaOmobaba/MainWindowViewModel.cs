using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmaOmobaba.Properties;

namespace UmaOmobaba;

public class MainWindowViewModel : BindableBase
{
    private string _Title = Resources.WindowTitle;
    public string Title
    {
        get => _Title;
        set => SetProperty(ref _Title, value);
    }

    public MainWindowViewModel()
    {

    }
}
