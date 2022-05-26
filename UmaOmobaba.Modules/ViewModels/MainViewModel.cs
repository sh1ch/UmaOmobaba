using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmaOmobaba.Core;
using UmaOmobaba.Modules.Process;
using Unity;
using sys = System.Timers;

namespace UmaOmobaba.Modules.ViewModels;

public class MainViewModel : BindableBase, IDestructible
{
    private sys.Timer _Timer = new sys.Timer();

    /// <summary>
    /// <see cref="MainViewModel"/> クラスの新しいインスタンスを初期化します。
    /// </summary>
    public MainViewModel(IUnityContainer container)
    {
        var env = container.Resolve<IEnv>(ContainerName.Env);

        var handle = new WindowHandle(env.TargetWindowName, env.TargetClassName);

        _Timer.Interval = 1000; // 1,000 ms

        _Timer.Elapsed += (s, e) =>
        {
            if (handle.TryUpdate())
            {

            }
            else
            {
                // ハンドルが取得できない
            }

            Debug.WriteLine("timer elapsed.");
        };

        _Timer.Start();
    }

    public void Destroy()
    {
        if (_Timer is not null)
        {
            _Timer.Stop();
            _Timer.Dispose();
        }
    }
}
