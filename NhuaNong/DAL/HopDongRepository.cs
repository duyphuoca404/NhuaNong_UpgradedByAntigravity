// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.HopDongRepository
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
using System.Linq.Expressions;
using System.Reflection;

namespace NhuaNong.DAL
{
    public class HopDongRepository : EFRepository<HopDong>, IHopDongRepository, IEFRepository<HopDong>
    {
        public HopDongRepository(IDbContextManager dbCtxMng)
            : base(dbCtxMng)
        {
            this.KeyProperty = this.GetKeyColumnName(new HopDong(), (DbContext)new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
        }

        public IList<HopDong> ListHopDong_ByCondition(
            string maHopDong,
            DateTime fromDate,
            DateTime toDate,
            int? status,
            int? khachHangID,
            int? congTruongID,
            int? macID)
        {
            // Thay thế toàn bộ code rối rắm bằng biểu thức LINQ đơn giản này
            return this.SelectAll(hd =>
                (string.IsNullOrEmpty(maHopDong) || hd.MaHopDong.Contains(maHopDong)) &&
                (hd.NgayHopDong >= fromDate) &&
                (hd.NgayHopDong <= toDate) &&
                (status == null || status == -1 || hd.Status == status) &&
                (khachHangID == null || hd.KhachHangID == khachHangID) &&
                (congTruongID == null || hd.CongTruongID == congTruongID) &&
                (macID == null || hd.MACID == macID)
            ).ToList();
        }
        public HopDong GetByMaHD(string maHD)
        {
            return this.DoQuery((ISpecification<HopDong>)new Specification<HopDong>((Expression<Func<HopDong, bool>>)(o => o.MaHopDong == maHD))).FirstOrDefault<HopDong>();
        }
        //public HopDong GetByMaHD(string maHD)
        //{
        //    // Sửa lại hàm này cho đúng cú pháp LINQ chuẩn
        //    return this.DoQuery(o => o.MaHopDong == maHD).FirstOrDefault();
        //}
    }
}