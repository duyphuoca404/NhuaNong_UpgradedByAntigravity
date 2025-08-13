// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjectBase
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjectBase
  {
    private bool _markAsDeleted;
    private bool _isNewObject = true;

    [DataMember]
    public bool MarkAsDeleted
    {
      get => this._markAsDeleted;
      set => this._markAsDeleted = value;
    }

    [DataMember]
    public bool IsNewObject
    {
      get => this._isNewObject;
      set => this._isNewObject = value;
    }
  }
}
