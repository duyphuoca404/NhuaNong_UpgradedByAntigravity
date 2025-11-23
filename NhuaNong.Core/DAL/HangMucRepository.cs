// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.HangMucRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq; // Thêm using này để đảm bảo các phương thức LINQ hoạt động
using System.Linq.Expressions;
using System.Reflection;

namespace NhuaNong.DAL
{
    internal class HangMucRepository :
        EFRepository<HangMuc>,
        IHangMucRepository,
        IEFRepository<HangMuc>
    {
        public HangMucRepository(IDbContextManager dbCtxMng)
            : base(dbCtxMng)
        {
            this.KeyProperty = this.GetKeyColumnName(new HangMuc(), (DbContext)new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
        }

        public IList<HangMuc> ListHangMuc_ByCondition(
            DateTime? fromDate,
            DateTime? toDate,
            string maKH,
            string tenKH,
            bool? active)
        {
            // Toàn bộ phương thức phức tạp đã được thay thế bằng dòng này
            return this.SelectAll(o =>
                (string.IsNullOrEmpty(maKH) || o.MaHangMuc.Contains(maKH)) &&
                (string.IsNullOrEmpty(tenKH) || o.TenHangMuc.Contains(tenKH)) &&
                (fromDate == null || fromDate == DateTime.MinValue || o.CreationDate >= fromDate) &&
                (toDate == null || toDate == DateTime.MinValue || o.CreationDate <= toDate) &&
                (active == null || o.Activated == active)
            ).ToList(); // Thêm .ToList() để trả về đúng kiểu IList<HangMuc>
        }
    }
}