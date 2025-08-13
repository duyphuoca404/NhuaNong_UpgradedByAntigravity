// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.CongTruongRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

#nullable disable
namespace NhuaNong.DAL
{
  public class CongTruongRepository : 
    EFRepository<CongTruong>,
    ICongTruongRepository,
    IEFRepository<CongTruong>
  {
    public CongTruongRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new CongTruong(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public IList<CongTruong> ListCongTruong_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maCT,
      string tenCT,
      string diaChi,
      string phone,
      bool? active)
    {
      IEnumerable<CongTruong> source = this.GetAll();
      if (!string.IsNullOrEmpty(maCT))
        source = source.Where<CongTruong>((Func<CongTruong, bool>) (c => c.MaCongTruong.Contains(maCT)));
      if (!string.IsNullOrEmpty(tenCT))
        source = source.Where<CongTruong>((Func<CongTruong, bool>) (c => c.TenCongTruong.Contains(tenCT)));
      if (!string.IsNullOrEmpty(diaChi))
        source = source.Where<CongTruong>((Func<CongTruong, bool>) (c => c.DiaChi.Contains(diaChi)));
      if (!string.IsNullOrEmpty(phone))
        source = source.Where<CongTruong>((Func<CongTruong, bool>) (c => c.Phone.Contains(phone)));
      if (fromDate.HasValue)
        source = source.Where<CongTruong>((Func<CongTruong, bool>) (c =>
        {
          DateTime? creationDate = c.CreationDate;
          DateTime? nullable = fromDate;
          return creationDate.HasValue & nullable.HasValue && creationDate.GetValueOrDefault() >= nullable.GetValueOrDefault();
        }));
      if (toDate.HasValue)
        source = source.Where<CongTruong>((Func<CongTruong, bool>) (c =>
        {
          DateTime? creationDate = c.CreationDate;
          DateTime? nullable = toDate;
          return creationDate.HasValue & nullable.HasValue && creationDate.GetValueOrDefault() <= nullable.GetValueOrDefault();
        }));
      if (active.HasValue)
        source = source.Where<CongTruong>((Func<CongTruong, bool>) (c => c.Activated == active.Value));
      return (IList<CongTruong>) source.ToList<CongTruong>();
    }
  }
}
