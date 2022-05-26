using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmaOmobaba.Core;

namespace UmaOmobaba;

public class Env : IEnv
{
    public string TargetWindowName { get; set; } = "";
    public string TargetClassName { get; set; } = "";

    public void Initialize()
    {
        DotNetEnv.Env.Load(".env");

        var windowName = DotNetEnv.Env.GetString(EnvName.WindowName);
        var className = DotNetEnv.Env.GetString(EnvName.ClassName);

#if DEBUG
        windowName = "無題 - メモ帳";
        className = "Notepad";
#endif

        TargetWindowName = windowName;
        TargetClassName = className;
    }
}
