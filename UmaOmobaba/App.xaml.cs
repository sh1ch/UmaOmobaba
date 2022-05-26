using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UmaOmobaba.Core;
using UmaOmobaba.Modules;
using Unity;

namespace UmaOmobaba;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    protected override Window CreateShell() => Container.Resolve<MainWindow>();

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
        var env = new Env();

        env.Initialize();

        containerRegistry.RegisterInstance<IEnv>(env, ContainerName.Env);
    }

    protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
    {
        moduleCatalog.AddModule<Module>();
    }

}
