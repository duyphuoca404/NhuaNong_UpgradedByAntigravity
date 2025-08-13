// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.SEC_TypeInfo
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class SEC_TypeInfo
  {
    public SEC_TypeInfo()
    {
      this.SEC_Function = (ICollection<NhuaNong.EntityModel.SEC_Function>) new HashSet<NhuaNong.EntityModel.SEC_Function>();
    }

    public int TypeInfoID { get; set; }

    public string TypeInfo { get; set; }

    public int? AssemblyID { get; set; }

    public virtual SEC_Assembly SEC_Assembly { get; set; }

    public virtual ICollection<NhuaNong.EntityModel.SEC_Function> SEC_Function { get; set; }
  }
}
