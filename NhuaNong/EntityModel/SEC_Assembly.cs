// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.SEC_Assembly
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class SEC_Assembly
  {
    public SEC_Assembly()
    {
      this.SEC_TypeInfo = (ICollection<NhuaNong.EntityModel.SEC_TypeInfo>) new HashSet<NhuaNong.EntityModel.SEC_TypeInfo>();
    }

    public int AssemblyID { get; set; }

    public string AssemblyInfo { get; set; }

    public virtual ICollection<NhuaNong.EntityModel.SEC_TypeInfo> SEC_TypeInfo { get; set; }
  }
}
