// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.HardDrive
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

#nullable disable
namespace NhuaNong.Utils
{
  internal class HardDrive
  {
    private string model;
    private string type;
    private string serialNo;

    public string Model
    {
      get => this.model;
      set => this.model = value;
    }

    public string Type
    {
      get => this.type;
      set => this.type = value;
    }

    public string SerialNo
    {
      get => this.serialNo;
      set => this.serialNo = value;
    }
  }
}
