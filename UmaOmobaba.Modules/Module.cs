using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmaOmobaba.Core;
using UmaOmobaba.Modules.Views;

namespace UmaOmobaba.Modules;

public class Module : IModule
{
    private readonly IRegionManager _regionManager;

    public Module(IRegionManager regionManager)
    {
        _regionManager = regionManager;
    }

    public void OnInitialized(IContainerProvider containerProvider)
    {
        _regionManager.RequestNavigate(NavigationName.RegionBody, NavigationName.Body_Main);
    }

    public void RegisterTypes(IContainerRegistry containerRegistry)
    {
        // ビュー
        containerRegistry.RegisterForNavigation<Main>();
        containerRegistry.RegisterForNavigation<WorkingSet>();

        // ダイアログ

    }
}
