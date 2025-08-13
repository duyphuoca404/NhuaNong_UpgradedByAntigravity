// Decompiled with JetBrains decompiler
// Type: NhuaNong.Program
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Diagnostics;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
        return;
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      new FrmMain().Show();
      Application.Run();
    }
  }
}
