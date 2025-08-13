// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.SEC_FunctionRepository
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
  public class SEC_FunctionRepository : 
    EFRepository<SEC_Function>,
    ISEC_FunctionRepository,
    IEFRepository<SEC_Function>
  {
    public SEC_FunctionRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new SEC_Function(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public IList<SEC_Function> ListSEC_Function_ByFunctionType(int funcType)
    {
      return this.SelectAll((ISpecification<SEC_Function>) new Specification<SEC_Function>((Expression<Func<SEC_Function, bool>>) (f => f.FunctionType == (int?) funcType)));
    }

    public IList<SEC_Function> ListSEC_Function_ByUserID(int userID)
    {
      return this.SelectAll((ISpecification<SEC_Function>) new Specification<SEC_Function>((Expression<Func<SEC_Function, bool>>) (f => f.SEC_RoleFunction.Any<SEC_RoleFunction>((Func<SEC_RoleFunction, bool>) (rf => rf.SEC_Role.SEC_UserRole.Any<SEC_UserRole>((Func<SEC_UserRole, bool>) (ur => ur.UserID == userID)))))));
    }
  }
}
