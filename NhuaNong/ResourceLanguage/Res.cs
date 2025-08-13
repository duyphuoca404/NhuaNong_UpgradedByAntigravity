// Decompiled with JetBrains decompiler
// Type: NhuaNong.ResourceLanguage.Res
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace NhuaNong.ResourceLanguage
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Res
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Res()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Res.resourceMan == null)
          Res.resourceMan = new ResourceManager("NhuaNong.ResourceLanguage.Res", typeof (Res).Assembly);
        return Res.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Res.resourceCulture;
      set => Res.resourceCulture = value;
    }
  }
}
