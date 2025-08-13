// Decompiled with JetBrains decompiler
// Type: NhuaNong.Properties.Resources
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace NhuaNong.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (NhuaNong.Properties.Resources.resourceMan == null)
          NhuaNong.Properties.Resources.resourceMan = new ResourceManager("NhuaNong.Properties.Resources", typeof (NhuaNong.Properties.Resources).Assembly);
        return NhuaNong.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => NhuaNong.Properties.Resources.resourceCulture;
      set => NhuaNong.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap homepage_icon
    {
      get
      {
        return (Bitmap) NhuaNong.Properties.Resources.ResourceManager.GetObject(nameof (homepage_icon), NhuaNong.Properties.Resources.resourceCulture);
      }
    }
  }
}
