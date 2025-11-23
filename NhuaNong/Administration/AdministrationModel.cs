// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.AdministrationModel
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.ServiceLibrary;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.Administration
{
  public class AdministrationModel : IAdministrationModel, IBase
  {
    public ObjSEC_Assembly GetSEC_AssemblyByKey(int ctID)
    {
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).GetSEC_AssemblyByKey(ctID);
    }

    public ObjSEC_Function GetSEC_FunctionByKey(int ctID)
    {
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).GetSEC_FunctionByKey(ctID);
    }

    public ObjSEC_Role GetSEC_RoleByKey(int ctID)
    {
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).GetSEC_RoleByKey(ctID);
    }

    public ObjSEC_RoleFunction GetSEC_RoleFunctionByKey(int ctID)
    {
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).GetSEC_RoleFunctionByKey(ctID);
    }

    public ObjSEC_TypeInfo GetSEC_TypeInfoByKey(int ctID)
    {
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).GetSEC_TypeInfoByKey(ctID);
    }

    public ObjSEC_User GetSEC_UserByKey(int ctID)
    {
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).GetSEC_UserByKey(ctID);
    }

    public ObjSEC_UserRole GetSEC_UserRoleByKey(int ctID)
    {
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).GetSEC_UserRoleByKey(ctID);
    }

    public ObjSEC_User GetSEC_User_ByUsername_Pass(string username, string password)
    {
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).GetSEC_User_ByUsername_Pass(username, password);
    }

    public bool InsertEventLog(ObjEventLog objEventLog)
    {
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).InsertEventLog(objEventLog);
    }

    public IList<ObjEventLog> ListEventLog_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      int? userID,
      int? eventActionCodeID)
    {
      return (IList<ObjEventLog>) Converter.ConvertToBindingList<ObjEventLog>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListEventLog_ByCondition(fromDate, toDate, userID, eventActionCodeID) as List<ObjEventLog>);
    }

    public BindingList<ObjSEC_Assembly> ListSEC_Assembly()
    {
      return Converter.ConvertToBindingList<ObjSEC_Assembly>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_Assembly() as List<ObjSEC_Assembly>);
    }

    public BindingList<ObjSEC_Function> ListSEC_Function()
    {
      return Converter.ConvertToBindingList<ObjSEC_Function>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_Function() as List<ObjSEC_Function>);
    }

    public BindingList<ObjSEC_Function> ListSEC_Function_ByFunctionType(int funcType)
    {
      return Converter.ConvertToBindingList<ObjSEC_Function>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_Function_ByFunctionType(funcType) as List<ObjSEC_Function>);
    }

    public BindingList<ObjSEC_Role> ListSEC_Role()
    {
      return Converter.ConvertToBindingList<ObjSEC_Role>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_Role() as List<ObjSEC_Role>);
    }

    public BindingList<ObjSEC_RoleFunction> ListSEC_RoleFunction()
    {
      return Converter.ConvertToBindingList<ObjSEC_RoleFunction>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_RoleFunction() as List<ObjSEC_RoleFunction>);
    }

    public BindingList<ObjSEC_TypeInfo> ListSEC_TypeInfo()
    {
      return Converter.ConvertToBindingList<ObjSEC_TypeInfo>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_TypeInfo() as List<ObjSEC_TypeInfo>);
    }

    public BindingList<ObjSEC_User> ListSEC_User()
    {
      return Converter.ConvertToBindingList<ObjSEC_User>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_User() as List<ObjSEC_User>);
    }

    public BindingList<ObjSEC_User> ListSEC_User_ByActive(bool? active)
    {
      return Converter.ConvertToBindingList<ObjSEC_User>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_User_ByActive(active) as List<ObjSEC_User>);
    }

    public BindingList<ObjSEC_UserRole> ListSEC_UserRole()
    {
      return Converter.ConvertToBindingList<ObjSEC_UserRole>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_UserRole() as List<ObjSEC_UserRole>);
    }

    public bool SaveSEC_Assembly(BindingList<ObjSEC_Assembly> blstAssembly)
    {
      List<ObjSEC_Assembly> list = Converter.ConvertToList<ObjSEC_Assembly>(blstAssembly);
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).SaveSEC_Assembly((IList<ObjSEC_Assembly>) list);
    }

    public bool SaveSEC_Function(BindingList<ObjSEC_Function> blstFunction)
    {
      List<ObjSEC_Function> list = Converter.ConvertToList<ObjSEC_Function>(blstFunction);
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).SaveSEC_Function((IList<ObjSEC_Function>) list);
    }

    public bool SaveSEC_Role(BindingList<ObjSEC_Role> blstRole)
    {
      List<ObjSEC_Role> list = Converter.ConvertToList<ObjSEC_Role>(blstRole);
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).SaveSEC_Role((IList<ObjSEC_Role>) list);
    }

    public bool SaveSEC_RoleFunction(BindingList<ObjSEC_RoleFunction> blstRoleFunction)
    {
      List<ObjSEC_RoleFunction> list = Converter.ConvertToList<ObjSEC_RoleFunction>(blstRoleFunction);
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).SaveSEC_RoleFunction((IList<ObjSEC_RoleFunction>) list);
    }

    public bool SaveSEC_TypeInfo(BindingList<ObjSEC_TypeInfo> blstTypeInfo)
    {
      List<ObjSEC_TypeInfo> list = Converter.ConvertToList<ObjSEC_TypeInfo>(blstTypeInfo);
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).SaveSEC_TypeInfo((IList<ObjSEC_TypeInfo>) list);
    }

    public bool SaveSEC_User(BindingList<ObjSEC_User> blstUser)
    {
      List<ObjSEC_User> list = Converter.ConvertToList<ObjSEC_User>(blstUser);
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).SaveSEC_User((IList<ObjSEC_User>) list);
    }

    public bool SaveSEC_UserRole(BindingList<ObjSEC_UserRole> blstUserRole)
    {
      List<ObjSEC_UserRole> list = Converter.ConvertToList<ObjSEC_UserRole>(blstUserRole);
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).SaveSEC_UserRole((IList<ObjSEC_UserRole>) list);
    }
  }
}
