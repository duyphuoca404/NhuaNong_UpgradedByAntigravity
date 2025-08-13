// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.KhachHangRepository
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
    public class KhachHangRepository :
        EFRepository<KhachHang>,
        IKhachHangRepository,
        IEFRepository<KhachHang>
    {
        public KhachHangRepository(IDbContextManager dbCtxMng)
            : base(dbCtxMng)
        {
            this.KeyProperty = this.GetKeyColumnName(new KhachHang(), (DbContext)new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
        }

        public IList<KhachHang> ListKhachHang_ByCondition(
            DateTime? fromDate,
            DateTime? toDate,
            string maKH,
            string tenKH,
            string diaChi,
            string phone,
            bool? active)
        {
            // Thay thế toàn bộ code rối rắm bằng biểu thức LINQ đơn giản này
            return this.SelectAll(o =>
                (string.IsNullOrEmpty(maKH) || o.MaKhachHang.Contains(maKH)) &&
                (string.IsNullOrEmpty(tenKH) || o.TenKhachHang.Contains(tenKH)) &&
                (string.IsNullOrEmpty(diaChi) || o.DiaChi.Contains(diaChi)) &&
                (string.IsNullOrEmpty(phone) || o.Phone.Contains(phone)) &&
                (fromDate == null || fromDate == DateTime.MinValue || o.CreationDate >= fromDate) &&
                (toDate == null || toDate == DateTime.MinValue || o.CreationDate <= toDate) &&
                (active == null || o.Activated == active)
            ).ToList();
        }
    }
}