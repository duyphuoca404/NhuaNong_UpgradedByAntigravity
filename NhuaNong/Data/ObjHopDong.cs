// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjHopDong
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjHopDong : ObjectBase
  {
    [DataMember]
    public int HopDongID { get; set; }

    [DataMember]
    public string MaHopDong { get; set; }

    [DataMember]
    public string TenHopDong { get; set; }

    [DataMember]
    public DateTime? NgayHopDong { get; set; }

    [DataMember]
    public string MoTa { get; set; }

    [DataMember]
    public int? KhachHangID { get; set; }

    [DataMember]
    public int? CongTruongID { get; set; }

    [DataMember]
    public int? MACID { get; set; }

    [DataMember]
    public int? HangMucID { get; set; }

    [DataMember]
    public string DoSut { get; set; }

    [DataMember]
    public Decimal? KLDatHang { get; set; }

    [DataMember]
    public Decimal? KLDaGiao { get; set; }

    [DataMember]
    public Decimal? KLConLai { get; set; }

    [DataMember]
    public Decimal? KLTaoPhieuTron { get; set; }

    [DataMember]
    public int? TongPhieu { get; set; }

    [DataMember]
    public int? Status { get; set; }

    [DataMember]
    public Decimal? DLT_KLDuTinh { get; set; }

    [DataMember]
    public Decimal? DLT_KLTronNhoNhat { get; set; }

    [DataMember]
    public Decimal? DLT_KLTronLonNhat { get; set; }

    [DataMember]
    public Decimal? DLT_KLDuTinhCuaTungMe { get; set; }

    [DataMember]
    public Decimal? DLT_KLDuTinhCuaTungMe_NoiB { get; set; }

    [DataMember]
    public bool DLT_KLDuTinhCuaTungMe_NoiB_IsUsed { get; set; }

    [DataMember]
    public Decimal? DLT_KLBuTruMeCuoi { get; set; }

    [DataMember]
    public Decimal? DLT_SLMeDuTinh { get; set; }

    [DataMember]
    public Decimal? DLT_KLXeChoLonNhat { get; set; }

    [DataMember]
    public Decimal? DLT_MACSUMSiloValueCalc { get; set; }

    [DataMember]
    public Decimal? DLT_MACSUMSiloValue { get; set; }

    [DataMember]
    public DateTime? CreationDate { get; set; }

    [DataMember]
    public int? CreatedBy { get; set; }

    [DataMember]
    public DateTime? LatestUpdateDate { get; set; }

    [DataMember]
    public int? LatestUpdatedBy { get; set; }

    [DataMember]
    public byte[] VersionNo { get; set; }

    [DataMember]
    public string NPKhachHangMaKhachHang { get; set; }

    [DataMember]
    public string NPKhachHangTenKhachHang { get; set; }

    [DataMember]
    public string NPCongTruongMaCongTruong { get; set; }

    [DataMember]
    public string NPCongTruongTenCongTruong { get; set; }

    [DataMember]
    public string NPMACMaMAC { get; set; }

    [DataMember]
    public string NPMACTenMAC { get; set; }

    [DataMember]
    public Decimal NPMACThemBotNuoc1 { get; set; }

    [DataMember]
    public Decimal NPMACThemBotNuoc2 { get; set; }

    public Decimal? KLLyThuyetCoTheTaoPT
    {
      get
      {
        Decimal? nullable1 = new Decimal?(0M);
        Decimal? klDaGiao1 = this.KLDaGiao;
        Decimal? klTaoPhieuTron1 = this.KLTaoPhieuTron;
        Decimal? thuyetCoTheTaoPt;
        if (klDaGiao1.GetValueOrDefault() > klTaoPhieuTron1.GetValueOrDefault() & klDaGiao1.HasValue & klTaoPhieuTron1.HasValue)
        {
          Decimal? klDatHang = this.KLDatHang;
          Decimal? klDaGiao2 = this.KLDaGiao;
          thuyetCoTheTaoPt = klDatHang.HasValue & klDaGiao2.HasValue ? new Decimal?(klDatHang.GetValueOrDefault() - klDaGiao2.GetValueOrDefault()) : new Decimal?();
        }
        else
        {
          Decimal? klDatHang = this.KLDatHang;
          Decimal? klTaoPhieuTron2 = this.KLTaoPhieuTron;
          thuyetCoTheTaoPt = klDatHang.HasValue & klTaoPhieuTron2.HasValue ? new Decimal?(klDatHang.GetValueOrDefault() - klTaoPhieuTron2.GetValueOrDefault()) : new Decimal?();
        }
        Decimal? nullable2 = thuyetCoTheTaoPt;
        Decimal num = 0M;
        if (nullable2.GetValueOrDefault() < num & nullable2.HasValue)
          thuyetCoTheTaoPt = new Decimal?(0M);
        return thuyetCoTheTaoPt;
      }
    }

    public string StatusDisplay => string.Empty;
  }
}
