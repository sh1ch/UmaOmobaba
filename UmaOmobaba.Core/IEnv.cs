using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmaOmobaba.Core;

/// <summary>
/// <see cref="IEnv"/> インターフェースは、基本的な環境設定の情報を表します。
/// </summary>
public interface IEnv
{
    /// <summary>
    /// WorkingSet を計測するウィンドウ名を取得または設定します。
    /// </summary>
    public string TargetWindowName { get; set; }

    /// <summary>
    /// WorkingSet を計測するウィンドウ（クラス名）を取得または設定します。
    /// </summary>
    public string TargetClassName { get; set; }
    
}
