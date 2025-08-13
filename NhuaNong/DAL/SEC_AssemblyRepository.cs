// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.SEC_AssemblyRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System.Data.Entity;

#nullable disable
namespace NhuaNong.DAL
{
  public class SEC_AssemblyRepository : 
    EFRepository<SEC_Assembly>,
    ISEC_AssemblyRepository,
    IEFRepository<SEC_Assembly>
  {
    public SEC_AssemblyRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new SEC_Assembly(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }
  }
}
