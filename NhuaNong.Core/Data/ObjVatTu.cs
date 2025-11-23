// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjVatTu
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.Data
{
  public class ObjVatTu
  {
    public string MaSilo { get; set; }

    public string TenVatTu { get; set; }

    public Decimal? KLThuc { get; set; }

    public Decimal? DinhMuc { get; set; }

    public Decimal? SaiSo { get; set; }

    public Decimal? PerSaiSo { get; set; }

    public ObjVatTu(
      string maSilo,
      string ten,
      Decimal? klthucte,
      Decimal? dinhmuc,
      Decimal? saiso,
      Decimal? persaiso)
    {
      this.MaSilo = maSilo;
      this.TenVatTu = ten;
      this.KLThuc = klthucte;
      this.DinhMuc = dinhmuc;
      this.SaiSo = saiso;
      this.PerSaiSo = persaiso;
    }
  }
}
