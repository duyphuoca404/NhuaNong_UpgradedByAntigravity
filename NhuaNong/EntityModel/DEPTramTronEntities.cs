// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.DEPTramTronEntities
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class DEPTramTronEntities : DbContext, IDBContext, IDisposable
  {
    public DEPTramTronEntities()
      : base("name=DEPTramTronEntities")
    {
      this.Configuration.LazyLoadingEnabled = true;
    }

    public DEPTramTronEntities(string connectionString)
      : base(connectionString)
    {
      this.Configuration.LazyLoadingEnabled = true;
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      throw new UnintentionalCodeFirstException();
    }

    IDbSet<TEntity> IDBContext.Set<TEntity>() => (IDbSet<TEntity>) this.Set<TEntity>();

    void IDBContext.SaveChanges() => this.SaveChanges();

    public virtual DbSet<bandwidth> bandwidths { get; set; }

    public virtual DbSet<CongTruong> CongTruongs { get; set; }

    public virtual DbSet<DuLieuTron> DuLieuTrons { get; set; }

    public virtual DbSet<EventActionCode> EventActionCodes { get; set; }

    public virtual DbSet<EventLog> EventLogs { get; set; }

    public virtual DbSet<HopDong> HopDongs { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<MAC> MACs { get; set; }

    public virtual DbSet<MACSilo> MACSiloes { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<MeTron> MeTrons { get; set; }

    public virtual DbSet<MeTronChiTiet> MeTronChiTiets { get; set; }

    public virtual DbSet<NhomSilo> NhomSiloes { get; set; }

    public virtual DbSet<PCInput> PCInputs { get; set; }

    public virtual DbSet<PCOutput> PCOutputs { get; set; }

    public virtual DbSet<PhieuTron> PhieuTrons { get; set; }

    public virtual DbSet<RptTongTungXe> RptTongTungXes { get; set; }

    public virtual DbSet<RptViewDataMix> RptViewDataMixes { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.SEC_Assembly> SEC_Assembly { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.SEC_Function> SEC_Function { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.SEC_Role> SEC_Role { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.SEC_RoleFunction> SEC_RoleFunction { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.SEC_TypeInfo> SEC_TypeInfo { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.SEC_User> SEC_User { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.SEC_UserRole> SEC_UserRole { get; set; }

    public virtual DbSet<Silo> Silos { get; set; }

    public virtual DbSet<SysCodeGen> SysCodeGens { get; set; }

    public virtual DbSet<TaiXe> TaiXes { get; set; }

    public virtual DbSet<TimerPara> TimerParas { get; set; }

    public virtual DbSet<TinhDoHutNuoc> TinhDoHutNuocs { get; set; }

    public virtual DbSet<TinhDoHutNuocChiTiet> TinhDoHutNuocChiTiets { get; set; }

    public virtual DbSet<TraceRecord> TraceRecords { get; set; }

    public virtual DbSet<VatTu> VatTus { get; set; }

    public virtual DbSet<Weigh> Weighs { get; set; }

    public virtual DbSet<WeiSiloSaving> WeiSiloSavings { get; set; }

    public virtual DbSet<WeiSiloVisible> WeiSiloVisibles { get; set; }

    public virtual DbSet<Xe> Xes { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_Temp_Removing> vw_Temp_Removing { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<HangMuc> HangMucs { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_PvSUMTotal> vw_PvSUMTotal { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_PvTotalMaterial> vw_PvTotalMaterial { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_PvMaterialDetailDay> vw_PvMaterialDetailDay { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_PvTranferDetailDay> vw_PvTranferDetailDay { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_PvTotalTranfer> vw_PvTotalTranfer { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_PvTotalDriver> vw_PvTotalDriver { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_Infos> vw_Infos { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_DataMix> vw_DataMix { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_PvtMTCT> vw_PvtMTCT { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_PvTotalWeghit> vw_PvTotalWeghit { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_PvMaterialDetailDay_WithID> vw_PvMaterialDetailDay_WithID { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_PvDriverDetailDay_WithID> vw_PvDriverDetailDay_WithID { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_PvTranferDetailDay_WithID> vw_PvTranferDetailDay_WithID { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_InfoPT> vw_InfoPT { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_SumWeight> vw_SumWeight { get; set; }

    public virtual DbSet<PhieuGiaoHang> PhieuGiaoHangs { get; set; }

    public virtual DbSet<NhuaNong.EntityModel.vw_SumWeighFolPT> vw_SumWeighFolPT { get; set; }

    public virtual DbSet<MeTronChiTietGiaoHang> MeTronChiTietGiaoHangs { get; set; }

    DbEntityEntry<TEntity> IDBContext.Entry<TEntity>(TEntity entity) => this.Entry<TEntity>(entity);
  }
}
