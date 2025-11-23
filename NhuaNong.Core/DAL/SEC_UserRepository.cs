// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.SEC_UserRepository
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

#nullable disable
namespace NhuaNong.DAL
{
  public class SEC_UserRepository : 
    EFRepository<SEC_User>,
    ISEC_UserRepository,
    IEFRepository<SEC_User>
  {
    public SEC_UserRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new SEC_User(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public SEC_User GetSEC_User_ByUsername_Pass(string username, string password)
    {
      string decryptedPassword = EncryptionHelper.Encrypt(password);
      SEC_User secUser = this.DoQuery((ISpecification<SEC_User>) new Specification<SEC_User>((Expression<Func<SEC_User, bool>>) (u => u.UserName == username && u.Password == decryptedPassword))).FirstOrDefault<SEC_User>();
      if (secUser == null)
        return (SEC_User) null;
      return secUser.Password != decryptedPassword ? (SEC_User) null : secUser;
    }

    public IList<SEC_User> ListSEC_User_ByActive(bool? active)
    {
        // Lấy tất cả nếu active là null, ngược lại thì lọc theo giá trị active
        return this.SelectAll(new Specification<SEC_User>(o => active == null || o.IsActived == active));
    }
    }
}
