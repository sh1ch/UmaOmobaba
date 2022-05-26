using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UmaOmobaba.Modules.Process;

/// <summary>
/// <see cref="WindowHandle"/> クラスは、指定したウィンドウのハンドルを表します。
/// </summary>
public class WindowHandle
{
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

    /// <summary>
    /// ハンドルを取得するウィンドウ名（ウィンドウタイトル）を表すテキストを取得します。
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// クラス名を表すテキストを取得します。
    /// </summary>
    public string ClassName { get; }

    /// <summary>
    /// ウィンドウのハンドルを取得します。
    /// </summary>
    public IntPtr Handle { get; private set; }

    /// <summary>
    /// <see cref="WindowHandle"/> クラスの新しいインスタンスを初期化します。
    /// </summary>
    /// <param name="name">ウィンドウ名（ウィンドウタイトル）を表すテキスト。</param>
    /// <param name="className">クラス名を表すテキスト。</param>
    public WindowHandle(string name, string className)
    {
        Name = name;
        ClassName = className;
    }

    /// <summary>
    /// ハンドルを取得します。
    /// </summary>
    /// <returns>取得に成功したとき <c>true</c>。それ以外のとき <c>false</c> を返却。</returns>
    public bool TryUpdate()
    {
        var hwnd = FindWindow(ClassName, Name);

        Handle = hwnd;

        return Handle != IntPtr.Zero;
    }
}
