// Decompiled with JetBrains decompiler
// Type: NhuaNong.BusinessObject.AdministrationBO
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using Microsoft.Practices.Unity;
using NhuaNong.Core;
using NhuaNong.DAL;
using NhuaNong.Data;
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System.Collections.Generic;
using System.Transactions;

#nullable disable
namespace NhuaNong.BusinessObject
{
  public class AdministrationBO
  {
    public ObjSEC_Assembly GetSEC_AssemblyByKey(int miID)
    {
      return SEC_AssemblyHelper.BuildNewObjSEC_Assembly(IoC.Current.Container.Resolve<ISEC_AssemblyRepository>().GetById(miID));
    }

    public IList<ObjSEC_Assembly> ListSEC_Assembly()
    {
      return SEC_AssemblyHelper.BuildListObjSEC_Assembly(IoC.Current.Container.Resolve<ISEC_AssemblyRepository>().SelectAll());
    }

    public bool SaveSEC_Assembly(IList<ObjSEC_Assembly> lstAssembly)
    {
      ISEC_AssemblyRepository assemblyRepository = IoC.Current.Container.Resolve<ISEC_AssemblyRepository>();
      foreach (ObjSEC_Assembly objSEC_Assembly in (IEnumerable<ObjSEC_Assembly>) lstAssembly)
      {
        if (objSEC_Assembly.MarkAsDeleted)
        {
          assemblyRepository.Delete(assemblyRepository.GetById(objSEC_Assembly.AssemblyID));
        }
        else
        {
          SEC_Assembly entity = SEC_AssemblyHelper.BuildNewEntSEC_Assembly(objSEC_Assembly);
          assemblyRepository.Update(entity);
        }
      }
      assemblyRepository.Save();
      return true;
    }

    public ObjSEC_Function GetSEC_FunctionByKey(int miID)
    {
      return SEC_FunctionHelper.BuildNewObjSEC_Function(IoC.Current.Container.Resolve<ISEC_FunctionRepository>().GetById(miID));
    }

    public IList<ObjSEC_Function> ListSEC_Function()
    {
      return SEC_FunctionHelper.BuildListObjSEC_Function(IoC.Current.Container.Resolve<ISEC_FunctionRepository>().SelectAll());
    }

    public IList<ObjSEC_Function> ListSEC_Function_ByFunctionType(int funcType)
    {
      return SEC_FunctionHelper.BuildListObjSEC_Function(IoC.Current.Container.Resolve<ISEC_FunctionRepository>().ListSEC_Function_ByFunctionType(funcType));
    }

    public IList<ObjSEC_Function> ListSEC_Function_ByUserID(int userID)
    {
      return SEC_FunctionHelper.BuildListObjSEC_Function(IoC.Current.Container.Resolve<ISEC_FunctionRepository>().ListSEC_Function_ByUserID(userID));
    }

    public bool SaveSEC_Function(IList<ObjSEC_Function> lstFunc)
    {
      ISEC_FunctionRepository functionRepository = IoC.Current.Container.Resolve<ISEC_FunctionRepository>();
      foreach (ObjSEC_Function objSEC_Function in (IEnumerable<ObjSEC_Function>) lstFunc)
      {
        if (objSEC_Function.MarkAsDeleted)
        {
          functionRepository.Delete(functionRepository.GetById(objSEC_Function.FunctionID));
        }
        else
        {
          SEC_Function entity = SEC_FunctionHelper.BuildNewEntSEC_Function(objSEC_Function);
          functionRepository.Update(entity);
        }
      }
      functionRepository.Save();
      return true;
    }

    public ObjSEC_Role GetSEC_RoleByKey(int miID)
    {
      return SEC_RoleHelper.BuildNewObjSEC_Role(IoC.Current.Container.Resolve<ISEC_RoleRepository>().GetById(miID));
    }

    public IList<ObjSEC_Role> ListSEC_Role()
    {
      return SEC_RoleHelper.BuildListObjSEC_Role(IoC.Current.Container.Resolve<ISEC_RoleRepository>().SelectAll());
    }

    public bool SaveSEC_Role(IList<ObjSEC_Role> lstRole)
    {
      ISEC_RoleRepository secRoleRepository = IoC.Current.Container.Resolve<ISEC_RoleRepository>();
      using (TransactionScope transactionScope = new TransactionScope())
      {
        foreach (ObjSEC_Role objSecRole in (IEnumerable<ObjSEC_Role>) lstRole)
        {
          if (objSecRole.MarkAsDeleted)
          {
            secRoleRepository.Delete(secRoleRepository.GetById(objSecRole.RoleID));
            new NDPTramTronBO().InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "ROLE_DEL", objSecRole.RoleName, string.Empty, string.Empty);
          }
          else if (objSecRole.IsNewObject)
          {
            SEC_Role entity = SEC_RoleHelper.BuildNewEntSEC_Role(objSecRole);
            secRoleRepository.Add(entity);
            new NDPTramTronBO().InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "ROLE_NEW", objSecRole.RoleName, string.Empty, string.Empty);
          }
          else
          {
            SEC_Role byId = secRoleRepository.GetById(objSecRole.RoleID);
            string oldValueText = SEC_RoleHelper.GenMemberValues(byId);
            string newValueText = SEC_RoleHelper.GenMemberValues(objSecRole);
            new NDPTramTronBO().InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "ROLE_EDIT", objSecRole.RoleName, oldValueText, newValueText);
            SEC_RoleHelper.CopyToEntSEC_Role(objSecRole, byId);
            secRoleRepository.Update(byId);
          }
        }
        secRoleRepository.Save();
        transactionScope.Complete();
        return true;
      }
    }

    public ObjSEC_RoleFunction GetSEC_RoleFunctionByKey(int miID)
    {
      return SEC_RoleFunctionHelper.BuildNewObjSEC_RoleFunction(IoC.Current.Container.Resolve<ISEC_RoleFunctionRepository>().GetById(miID));
    }

    public IList<ObjSEC_RoleFunction> ListSEC_RoleFunction()
    {
      return SEC_RoleFunctionHelper.BuildListObjSEC_RoleFunction(IoC.Current.Container.Resolve<ISEC_RoleFunctionRepository>().SelectAll());
    }

    public bool SaveSEC_RoleFunction(IList<ObjSEC_RoleFunction> lstRoleFunc)
    {
      ISEC_RoleFunctionRepository functionRepository = IoC.Current.Container.Resolve<ISEC_RoleFunctionRepository>();
      try
      {
        using (TransactionScope transactionScope = new TransactionScope())
        {
          foreach (ObjSEC_RoleFunction objSEC_RoleFunction in (IEnumerable<ObjSEC_RoleFunction>) lstRoleFunc)
          {
            if (objSEC_RoleFunction.MarkAsDeleted)
              functionRepository.Delete(functionRepository.GetById(objSEC_RoleFunction.RoleFunctionID));
            else if (objSEC_RoleFunction.IsNewObject)
            {
              SEC_RoleFunction entity = SEC_RoleFunctionHelper.BuildNewEntSEC_RoleFunction(objSEC_RoleFunction);
              functionRepository.Add(entity);
            }
          }
          new NDPTramTronBO().InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "ROLE_FUNCTION_EDIT", string.Empty, string.Empty, string.Empty);
          functionRepository.Save();
          transactionScope.Complete();
        }
        return true;
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        return false;
      }
    }

    public ObjSEC_TypeInfo GetSEC_TypeInfoByKey(int miID)
    {
      return SEC_TypeInfoHelper.BuildNewObjSEC_TypeInfo(IoC.Current.Container.Resolve<ISEC_TypeInfoRepository>().GetById(miID));
    }

    public IList<ObjSEC_TypeInfo> ListSEC_TypeInfo()
    {
      return SEC_TypeInfoHelper.BuildListObjSEC_TypeInfo(IoC.Current.Container.Resolve<ISEC_TypeInfoRepository>().SelectAll());
    }

    public bool SaveSEC_TypeInfo(IList<ObjSEC_TypeInfo> lstTypeInfo)
    {
      ISEC_TypeInfoRepository typeInfoRepository = IoC.Current.Container.Resolve<ISEC_TypeInfoRepository>();
      foreach (ObjSEC_TypeInfo objSEC_TypeInfo in (IEnumerable<ObjSEC_TypeInfo>) lstTypeInfo)
      {
        if (objSEC_TypeInfo.MarkAsDeleted)
        {
          typeInfoRepository.Delete(typeInfoRepository.GetById(objSEC_TypeInfo.TypeInfoID));
        }
        else
        {
          SEC_TypeInfo entity = SEC_TypeInfoHelper.BuildNewEntSEC_TypeInfo(objSEC_TypeInfo);
          typeInfoRepository.Update(entity);
        }
      }
      typeInfoRepository.Save();
      return true;
    }

    public ObjSEC_User GetSEC_UserByKey(int miID)
    {
      var entity = IoC.Current.Container.Resolve<ISEC_UserRepository>().GetById(miID);
      if (entity == null) return null;
      return SEC_UserHelper.BuildNewObjSEC_User(entity);
    }

    public IList<ObjSEC_User> ListSEC_User()
    {
      return SEC_UserHelper.BuildListObjSEC_User(IoC.Current.Container.Resolve<ISEC_UserRepository>().SelectAll());
    }

    public IList<ObjSEC_User> ListSEC_User_ByActive(bool? active)
    {
      return SEC_UserHelper.BuildListObjSEC_User(IoC.Current.Container.Resolve<ISEC_UserRepository>().ListSEC_User_ByActive(active));
    }

    public ObjSEC_User GetSEC_User_ByUsername_Pass(string username, string password)
    {
      SEC_User userByUsernamePass1 = IoC.Current.Container.Resolve<ISEC_UserRepository>().GetSEC_User_ByUsername_Pass(username, password);
      if (userByUsernamePass1 == null)
        return (ObjSEC_User) null;
      ObjSEC_User userByUsernamePass2 = SEC_UserHelper.BuildNewObjSEC_User(userByUsernamePass1);
      foreach (SEC_UserRole secUserRole in (IEnumerable<SEC_UserRole>) userByUsernamePass1.SEC_UserRole)
      {
        ObjSEC_User objSecUser = userByUsernamePass2;
        objSecUser.NPOtherInfo = objSecUser.NPOtherInfo + secUserRole.SEC_Role.RoleName + "/";
      }
      userByUsernamePass2.NPOtherInfo = userByUsernamePass2.NPOtherInfo.Substring(0, userByUsernamePass2.NPOtherInfo.Length - 1);
      return userByUsernamePass2;
    }

    public bool SaveSEC_User(IList<ObjSEC_User> lstUser)
    {
      ISEC_UserRepository secUserRepository = IoC.Current.Container.Resolve<ISEC_UserRepository>();
      using (TransactionScope transactionScope = new TransactionScope())
      {
        foreach (ObjSEC_User objSecUser in (IEnumerable<ObjSEC_User>) lstUser)
        {
          if (objSecUser.MarkAsDeleted)
          {
            secUserRepository.Delete(secUserRepository.GetById(objSecUser.UserID));
            new NDPTramTronBO().InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "USER_DEL", objSecUser.UserName, string.Empty, string.Empty);
          }
          else if (objSecUser.IsNewObject)
          {
            objSecUser.Password = EncryptionHelper.Encrypt(objSecUser.Password);
            SEC_User entity = SEC_UserHelper.BuildNewEntSEC_User(objSecUser);
            secUserRepository.Add(entity);
            new NDPTramTronBO().InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "USER_NEW", objSecUser.UserName, string.Empty, string.Empty);
          }
          else
          {
            SEC_User byId = secUserRepository.GetById(objSecUser.UserID);
            string oldValueText = SEC_UserHelper.GenMemberValues(byId);
            string newValueText = SEC_UserHelper.GenMemberValues(objSecUser);
            new NDPTramTronBO().InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "USER_EDIT", objSecUser.UserName, oldValueText, newValueText);
            SEC_UserHelper.CopyToEntSEC_User(objSecUser, byId);
            secUserRepository.Update(byId);
          }
        }
        secUserRepository.Save();
        transactionScope.Complete();
        return true;
      }
    }

    public ObjSEC_UserRole GetSEC_UserRoleByKey(int miID)
    {
      return SEC_UserRoleHelper.BuildNewObjSEC_UserRole(IoC.Current.Container.Resolve<ISEC_UserRoleRepository>().GetById(miID));
    }

    public IList<ObjSEC_UserRole> ListSEC_UserRole()
    {
      return SEC_UserRoleHelper.BuildListObjSEC_UserRole(IoC.Current.Container.Resolve<ISEC_UserRoleRepository>().SelectAll());
    }

    public bool SaveSEC_UserRole(IList<ObjSEC_UserRole> lstUserRole)
    {
      ISEC_UserRoleRepository userRoleRepository = IoC.Current.Container.Resolve<ISEC_UserRoleRepository>();
      try
      {
        using (TransactionScope transactionScope = new TransactionScope())
        {
          foreach (ObjSEC_UserRole objSEC_UserRole in (IEnumerable<ObjSEC_UserRole>) lstUserRole)
          {
            if (objSEC_UserRole.MarkAsDeleted)
              userRoleRepository.Delete(userRoleRepository.GetById(objSEC_UserRole.UserRoleID));
            else if (objSEC_UserRole.IsNewObject)
            {
              SEC_UserRole entity = SEC_UserRoleHelper.BuildNewEntSEC_UserRole(objSEC_UserRole);
              userRoleRepository.Add(entity);
            }
          }
          new NDPTramTronBO().InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "USER_ROLE_EDIT", string.Empty, string.Empty, string.Empty);
          userRoleRepository.Save();
          transactionScope.Complete();
        }
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }
  }
}
