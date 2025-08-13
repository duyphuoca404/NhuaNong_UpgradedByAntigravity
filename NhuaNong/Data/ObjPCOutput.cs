// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjPCOutput
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjPCOutput : ObjectBase
  {
    [DataMember]
    public int PCOutputID { get; set; }

    [DataMember]
    public string Code { get; set; }

    [DataMember]
    public Decimal Value { get; set; }

    [DataMember]
    public string Description { get; set; }
  }
}
