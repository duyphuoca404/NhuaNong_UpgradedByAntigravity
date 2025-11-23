// Decompiled with JetBrains decompiler
// Type: NhuaNong.BusinessObject.NDPTramTronBO
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using Unity;
using NhuaNong.Core;
using NhuaNong.DAL;
using NhuaNong.Data;
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Transactions;

#nullable disable
namespace NhuaNong.BusinessObject
{
  public class NDPTramTronBO
  {
    public ObjCongTruong GetCongTruongByKey(int miID)
    {
      return CongTruongHelper.BuildNewObjCongTruong(IoC.Current.Container.Resolve<ICongTruongRepository>().GetById(miID));
    }

    public IList<ObjCongTruong> ListCongTruong()
    {
      return CongTruongHelper.BuildListObjCongTruong(IoC.Current.Container.Resolve<ICongTruongRepository>().SelectAll());
    }

    public IList<ObjCongTruong> ListCongTruong_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      string diaChi,
      string phone,
      bool? active)
    {
      return CongTruongHelper.BuildListObjCongTruong(IoC.Current.Container.Resolve<ICongTruongRepository>().ListCongTruong_ByCondition(fromDate, toDate, maKH, tenKH, diaChi, phone, active));
    }

    public bool SaveCongTruong(IList<ObjCongTruong> lst)
    {
      ICongTruongRepository truongRepository = IoC.Current.Container.Resolve<ICongTruongRepository>();
      try
      {
        using (TransactionScope transactionScope = new TransactionScope())
        {
          foreach (ObjCongTruong objCongTruong in (IEnumerable<ObjCongTruong>) lst)
          {
            if (objCongTruong.MarkAsDeleted)
              truongRepository.Delete(truongRepository.GetById(objCongTruong.CongTruongID));
            else if (objCongTruong.IsNewObject)
            {
              CongTruong entity = CongTruongHelper.BuildNewEntCongTruong(objCongTruong);
              entity.CreatedBy = new int?(GlobalValues.UserID);
              entity.CreationDate = new DateTime?(DateTime.Now);
              truongRepository.Add(entity);
            }
            else
            {
              CongTruong byId = truongRepository.GetById(objCongTruong.CongTruongID);
              CongTruongHelper.CopyToEntCongTruong(objCongTruong, byId);
              byId.LatestUpdatedBy = new int?(GlobalValues.UserID);
              byId.LatestUpdateDate = new DateTime?(DateTime.Now);
              truongRepository.Update(byId);
            }
          }
          truongRepository.Save();
          transactionScope.Complete();
          return true;
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        if (ex.InnerException != null)
        {
          if (ex.InnerException.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
            return false;
        }
      }
      return false;
    }

    public ObjDuLieuTron GetDuLieuTronByKey(int miID)
    {
      DuLieuTron byId = IoC.Current.Container.Resolve<IDuLieuTronRepository>().GetById(miID);
      return byId != null ? DuLieuTronHelper.BuildNewObjDuLieuTron(byId) : (ObjDuLieuTron) null;
    }

    public IList<ObjDuLieuTron> ListDuLieuTron(bool includeInActivated)
    {
      IDuLieuTronRepository lieuTronRepository = IoC.Current.Container.Resolve<IDuLieuTronRepository>();
      IMACRepository macRepository = IoC.Current.Container.Resolve<IMACRepository>();
      IList<DuLieuTron> duLieuTronList = (IList<DuLieuTron>) new List<DuLieuTron>();
      IList<ObjDuLieuTron> objDuLieuTronList = DuLieuTronHelper.BuildListObjDuLieuTron(!includeInActivated ? (IList<DuLieuTron>) lieuTronRepository.SelectAll().Where<DuLieuTron>((Func<DuLieuTron, bool>) (o => o.Activated)).OrderBy<DuLieuTron, int>((Func<DuLieuTron, int>) (o => o.LnNo)).ToList<DuLieuTron>() : (IList<DuLieuTron>) lieuTronRepository.SelectAll().OrderBy<DuLieuTron, int>((Func<DuLieuTron, int>) (o => o.LnNo)).ToList<DuLieuTron>());
      foreach (ObjDuLieuTron objDuLieuTron in (IEnumerable<ObjDuLieuTron>) objDuLieuTronList)
      {
        MAC byId = macRepository.GetById(objDuLieuTron.MACID.Value);
        objDuLieuTron.NPMACThemBotNuoc1 = byId.ThemBotNuoc1;
        objDuLieuTron.NPMACThemBotNuoc2 = byId.ThemBotNuoc2;
      }
      return objDuLieuTronList;
    }

    public ObjDuLieuTron AddDuLieuTron(ObjDuLieuTron objDLT)
    {
      try
      {
        IDuLieuTronRepository lieuTronRepository = IoC.Current.Container.Resolve<IDuLieuTronRepository>();
        DuLieuTron entity = DuLieuTronHelper.BuildNewEntDuLieuTron(objDLT);
        lieuTronRepository.Add(entity);
        lieuTronRepository.Save();
        objDLT.DuLieuTronID = entity.DuLieuTronID;
        objDLT.VersionNo = entity.VersionNo;
        objDLT.CreatedBy = new int?(GlobalValues.UserID);
        objDLT.CreationDate = new DateTime?(DateTime.Now);
        return objDLT;
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        return (ObjDuLieuTron) null;
      }
    }

    public ObjDuLieuTron UpdateDuLieuTron(ObjDuLieuTron objDLT)
    {
      try
      {
        IDuLieuTronRepository lieuTronRepository = IoC.Current.Container.Resolve<IDuLieuTronRepository>();
        DuLieuTron byId = lieuTronRepository.GetById(objDLT.DuLieuTronID);
        DuLieuTronHelper.CopyToEntDuLieuTron(objDLT, byId);
        lieuTronRepository.Update(byId);
        lieuTronRepository.Save();
        objDLT.VersionNo = byId.VersionNo;
        objDLT.LatestUpdatedBy = new int?(GlobalValues.UserID);
        objDLT.LatestUpdateDate = new DateTime?(DateTime.Now);
        return objDLT;
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        return (ObjDuLieuTron) null;
      }
    }

    public bool DeleteDulieuTron(int id)
    {
      try
      {
        IDuLieuTronRepository lieuTronRepository = IoC.Current.Container.Resolve<IDuLieuTronRepository>();
        lieuTronRepository.Delete(lieuTronRepository.GetById(id));
        lieuTronRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        return false;
      }
    }

    public bool SaveDuLieuTron(IList<ObjDuLieuTron> lstDLT)
    {
      IDuLieuTronRepository lieuTronRepository = IoC.Current.Container.Resolve<IDuLieuTronRepository>();
      foreach (ObjDuLieuTron objDuLieuTron in (IEnumerable<ObjDuLieuTron>) lstDLT)
      {
        if (objDuLieuTron.MarkAsDeleted)
        {
          lieuTronRepository.Delete(lieuTronRepository.GetById(objDuLieuTron.DuLieuTronID));
        }
        else
        {
          if (objDuLieuTron.DuLieuTronID > 0)
          {
            objDuLieuTron.LatestUpdateDate = new DateTime?(DateTime.Now);
            objDuLieuTron.LatestUpdatedBy = new int?(GlobalValues.UserID);
          }
          else
          {
            objDuLieuTron.CreationDate = new DateTime?(DateTime.Now);
            objDuLieuTron.CreatedBy = new int?(GlobalValues.UserID);
          }
          DuLieuTron entity = DuLieuTronHelper.BuildNewEntDuLieuTron(objDuLieuTron);
          lieuTronRepository.Update(entity);
        }
      }
      lieuTronRepository.Save();
      return true;
    }

    public bool InsertEventLog(ObjEventLog objEventLog)
    {
      try
      {
        IEventLogRepository eventLogRepository = IoC.Current.Container.Resolve<IEventLogRepository>();
        eventLogRepository.Attach(EventLogHelper.BuildNewEntEventLog(objEventLog));
        eventLogRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        return false;
      }
    }

    public bool InsertEventLog(
      int? userId,
      string userName,
      string eventActionCode,
      string result,
      string oldValueText,
      string newValueText)
    {
      bool flag;
      try
      {
        IEventLogRepository eventLogRepository = IoC.Current.Container.Resolve<IEventLogRepository>();
        EventActionCode eventActionCode1 = IoC.Current.Container.Resolve<IEventActionCodeRepository>().DoQuery().Where<EventActionCode>((Expression<Func<EventActionCode, bool>>) (o => o.Code == eventActionCode)).FirstOrDefault<EventActionCode>();
        if (eventActionCode1 == null)
        {
          TramTronLogger.WriteError(new System.Exception(string.Format("EventActionCode [{0}] không tồn tại.", (object) eventActionCode)));
          flag = false;
        }
        else
        {
          eventLogRepository.Update(new EventLog()
          {
            LogDate = DateTime.Now,
            LogCode = eventActionCode1.Code,
            EventActionCodeID = eventActionCode1.EventActionCodeID,
            EventActionContent = result,
            UserID = userId,
            UserName = userName,
            OldValueText = oldValueText,
            NewValueText = newValueText
          });
          eventLogRepository.Save();
          flag = true;
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        flag = false;
      }
      return flag;
    }

    public IList<ObjEventLog> ListEventLog_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      int? userID,
      int? eventActionCodeID)
    {
      return EventLogHelper.BuildListObjEventLog(IoC.Current.Container.Resolve<IEventLogRepository>().ListEventLog_ByCondition(fromDate, toDate, userID, eventActionCodeID));
    }

    public ObjHopDong GetHopDongByKey(int miID)
    {
      HopDong byId = IoC.Current.Container.Resolve<IHopDongRepository>().GetById(miID);
      if (byId == null)
        return (ObjHopDong) null;
      ObjHopDong hopDongByKey = HopDongHelper.BuildNewObjHopDong(byId);
      hopDongByKey.NPMACMaMAC = byId.MAC.MaMAC;
      hopDongByKey.NPMACTenMAC = byId.MAC.TenMAC;
      hopDongByKey.NPMACThemBotNuoc1 = byId.MAC.ThemBotNuoc1;
      hopDongByKey.NPMACThemBotNuoc2 = byId.MAC.ThemBotNuoc2;
      return hopDongByKey;
    }

    public ObjHopDong GetHopDongByMaHD(string maHD)
    {
      HopDong entHopDong = IoC.Current.Container.Resolve<IHopDongRepository>().DoQuery().Where<HopDong>((Expression<Func<HopDong, bool>>) (o => o.MaHopDong == maHD)).First<HopDong>();
      return entHopDong != null ? HopDongHelper.BuildNewObjHopDong(entHopDong) : (ObjHopDong) null;
    }

    public IList<ObjHopDong> ListHopDong()
    {
      return HopDongHelper.BuildListObjHopDong(IoC.Current.Container.Resolve<IHopDongRepository>().SelectAll());
    }

    public IList<ObjHopDong> ListHopDong_ByCondition(
      string maHopDong,
      DateTime fromDate,
      DateTime toDate,
      int? status,
      int? khachHangID,
      int? congTruongID,
      int? macID)
    {
      return HopDongHelper.BuildListObjHopDong(IoC.Current.Container.Resolve<IHopDongRepository>().ListHopDong_ByCondition(maHopDong, fromDate, toDate, status, khachHangID, congTruongID, macID));
    }

    public bool SaveHopDong(IList<ObjHopDong> lstHD)
    {
      IHopDongRepository hopDongRepository = IoC.Current.Container.Resolve<IHopDongRepository>();
      foreach (ObjHopDong objHopDong in (IEnumerable<ObjHopDong>) lstHD)
      {
        if (objHopDong.MarkAsDeleted)
          hopDongRepository.Delete(hopDongRepository.GetById(objHopDong.HopDongID));
        else if (objHopDong.IsNewObject)
        {
          HopDong entity = HopDongHelper.BuildNewEntHopDong(objHopDong);
          entity.TongPhieu = new int?(0);
          entity.CreatedBy = new int?(GlobalValues.UserID);
          entity.CreationDate = new DateTime?(DateTime.Now);
          hopDongRepository.Add(entity);
        }
        else if (!objHopDong.IsNewObject)
        {
          HopDong byId = hopDongRepository.GetById(objHopDong.HopDongID);
          HopDongHelper.CopyToEntHopDong(objHopDong, byId);
          byId.LatestUpdatedBy = new int?(GlobalValues.UserID);
          byId.LatestUpdateDate = new DateTime?(DateTime.Now);
          hopDongRepository.Update(byId);
        }
      }
      hopDongRepository.Save();
      return true;
    }

    public ObjHopDong SaveHopDong(ObjHopDong objHD)
    {
      IHopDongRepository hopDongRepository = IoC.Current.Container.Resolve<IHopDongRepository>();
      HopDong hopDong = HopDongHelper.BuildNewEntHopDong(objHD);
      if (hopDong.HopDongID > 0)
      {
        hopDong.LatestUpdatedBy = new int?(GlobalValues.UserID);
        hopDong.LatestUpdateDate = new DateTime?(DateTime.Now);
        hopDongRepository.Update(hopDong);
        hopDongRepository.Save();
      }
      else
      {
        objHD.TongPhieu = new int?(0);
        objHD.CreatedBy = new int?(GlobalValues.UserID);
        objHD.CreationDate = new DateTime?(DateTime.Now);
        objHD.LatestUpdatedBy = new int?(GlobalValues.UserID);
        objHD.LatestUpdateDate = new DateTime?(DateTime.Now);
        hopDongRepository.Add(hopDong);
        hopDongRepository.Save();
      }
      if (objHD.HopDongID > 0)
        hopDong = hopDongRepository.GetById(hopDong.HopDongID);
      HopDongHelper.CopyToObjHopDong(hopDong, objHD);
      return objHD;
    }

    public ObjHopDong SaveHopDong(ObjHopDong objHD, ObjDuLieuTron objDLT)
    {
      IHopDongRepository hopDongRepository = IoC.Current.Container.Resolve<IHopDongRepository>();
      IDuLieuTronRepository lieuTronRepository = IoC.Current.Container.Resolve<IDuLieuTronRepository>();
      HopDong hopDong = HopDongHelper.BuildNewEntHopDong(objHD);
      hopDongRepository.Update(hopDong);
      hopDongRepository.Save();
      DuLieuTron entity = DuLieuTronHelper.BuildNewEntDuLieuTron(objDLT);
      entity.HopDong = hopDong;
      lieuTronRepository.Update(entity);
      lieuTronRepository.Save();
      HopDongHelper.CopyToObjHopDong(hopDong, objHD);
      return objHD;
    }

    public ObjKhachHang GetKhachHangByKey(int miID)
    {
      return KhachHangHelper.BuildNewObjKhachHang(IoC.Current.Container.Resolve<IKhachHangRepository>().GetById(miID));
    }

    public IList<ObjKhachHang> ListKhachHang()
    {
      return KhachHangHelper.BuildListObjKhachHang(IoC.Current.Container.Resolve<IKhachHangRepository>().SelectAll());
    }

    public IList<ObjKhachHang> ListKhachHang_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      string diaChi,
      string phone,
      bool? active)
    {
      return KhachHangHelper.BuildListObjKhachHang(IoC.Current.Container.Resolve<IKhachHangRepository>().ListKhachHang_ByCondition(fromDate, toDate, maKH, tenKH, diaChi, phone, active));
    }

    public bool SaveKhachHang(IList<ObjKhachHang> lst)
    {
      IKhachHangRepository khachHangRepository = IoC.Current.Container.Resolve<IKhachHangRepository>();
      try
      {
        using (TransactionScope transactionScope = new TransactionScope())
        {
          foreach (ObjKhachHang objKhachHang in (IEnumerable<ObjKhachHang>) lst)
          {
            if (objKhachHang.MarkAsDeleted)
              khachHangRepository.Delete(khachHangRepository.GetById(objKhachHang.KhachHangID));
            else if (objKhachHang.IsNewObject)
            {
              KhachHang entity = KhachHangHelper.BuildNewEntKhachHang(objKhachHang);
              entity.CreatedBy = new int?(GlobalValues.UserID);
              entity.CreationDate = new DateTime?(DateTime.Now);
              khachHangRepository.Add(entity);
            }
            else
            {
              KhachHang byId = khachHangRepository.GetById(objKhachHang.KhachHangID);
              KhachHangHelper.CopyToEntKhachHang(objKhachHang, byId);
              byId.LatestUpdatedBy = new int?(GlobalValues.UserID);
              byId.LatestUpdateDate = new DateTime?(DateTime.Now);
              khachHangRepository.Update(byId);
            }
          }
          khachHangRepository.Save();
          transactionScope.Complete();
          return true;
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        if (ex.InnerException != null)
        {
          if (ex.InnerException.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
            return false;
        }
      }
      return false;
    }

    public ObjMAC GetMACByKey(int id)
    {
      MAC byId = IoC.Current.Container.Resolve<IMACRepository>().GetById(id);
      ObjMAC macByKey = new ObjMAC();
      if (byId != null)
      {
        macByKey = MACHelper.BuildNewObjMAC(byId);
        macByKey.NPSUMSiloValue = byId.MACSiloes.Sum<MACSilo>((Func<MACSilo, Decimal?>) (o => o.SiloValue));
      }
      return macByKey;
    }

    public IList<ObjMAC> ListMAC()
    {
      IList<MAC> macList = IoC.Current.Container.Resolve<IMACRepository>().SelectAll();
      IList<ObjMAC> objMacList = (IList<ObjMAC>) new List<ObjMAC>();
      foreach (MAC entMAC in (IEnumerable<MAC>) macList)
      {
        ObjMAC objMac = MACHelper.BuildNewObjMAC(entMAC);
        objMac.NPSUMSiloValue = entMAC.MACSiloes.Sum<MACSilo>((Func<MACSilo, Decimal?>) (o => o.SiloValue));
        objMacList.Add(objMac);
      }
      return objMacList;
    }

    public IList<ObjMAC> ListMAC_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maMAC,
      string tenMAC,
      bool? active)
    {
      IList<MAC> macList = IoC.Current.Container.Resolve<IMACRepository>().ListMAC_ByCondition(fromDate, toDate, maMAC, tenMAC, active);
      IList<ObjMAC> objMacList = (IList<ObjMAC>) new List<ObjMAC>();
      foreach (MAC entMAC in (IEnumerable<MAC>) macList)
      {
        ObjMAC objMac = MACHelper.BuildNewObjMAC(entMAC);
        objMac.NPSUMSiloValue = entMAC.MACSiloes.Sum<MACSilo>((Func<MACSilo, Decimal?>) (o => o.SiloValue));
        objMacList.Add(objMac);
      }
      return objMacList;
    }

    public bool SaveMAC(IList<ObjMAC> lstMAC)
    {
      using (TransactionScope transactionScope = new TransactionScope())
      {
        try
        {
          IMACRepository macRepository = IoC.Current.Container.Resolve<IMACRepository>();
          IMACSiloRepository macSiloRepository = IoC.Current.Container.Resolve<IMACSiloRepository>();
          foreach (ObjMAC objMac in (IEnumerable<ObjMAC>) lstMAC)
          {
            if (objMac.MarkAsDeleted)
            {
              MAC byId = macRepository.GetById(objMac.MACID);
              macRepository.Delete(byId);
              this.InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "MAC_DEL", objMac.MaMAC, string.Empty, string.Empty);
            }
            else if (objMac.IsNewObject)
            {
              MAC entity = MACHelper.BuildNewEntMAC(objMac);
              entity.CreationDate = new DateTime?(DateTime.Now);
              foreach (ObjMACSilo objMACSilo in objMac.LstMACSilo)
              {
                MACSilo macSilo = MACSiloHelper.BuildNewEntMACSilo(objMACSilo);
                macSilo.MAC = entity;
                entity.MACSiloes.Add(macSilo);
              }
              macRepository.Add(entity);
              this.InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "MAC_NEW", objMac.MaMAC, string.Empty, string.Empty);
            }
            else
            {
              MAC byId = macRepository.GetById(objMac.MACID);
              string oldValueText = MACHelper.GenMemberValues(byId) + this.BuildString_MACSiloEventLog(MACSiloHelper.BuildListObjMACSilo((IList<MACSilo>) byId.MACSiloes.ToList<MACSilo>()));
              string newValueText = MACHelper.GenMemberValues(objMac) + this.BuildString_MACSiloEventLog((IList<ObjMACSilo>) objMac.LstMACSilo);
              this.InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "MAC_EDIT", objMac.MaMAC, oldValueText, newValueText);
              MACHelper.CopyToEntMAC(objMac, byId);
              byId.LatestUpdatedBy = new int?(GlobalValues.UserID);
              byId.LatestUpdateDate = new DateTime?(DateTime.Now);
              foreach (ObjMACSilo objMacSilo in objMac.LstMACSilo)
              {
                ObjMACSilo objMACSilo = objMacSilo;
                MACSilo toEnt = byId.MACSiloes.FirstOrDefault<MACSilo>((Func<MACSilo, bool>) (x => x.MACSiloID == objMACSilo.MACSiloID));
                if (toEnt == null && objMACSilo.IsNewObject)
                {
                  MACSilo macSilo = MACSiloHelper.BuildNewEntMACSilo(objMACSilo);
                  macSilo.MAC = byId;
                  byId.MACSiloes.Add(macSilo);
                }
                else if (objMACSilo.MarkAsDeleted)
                {
                  byId.MACSiloes.Remove(toEnt);
                  macSiloRepository.Delete(macSiloRepository.GetById(objMACSilo.MACSiloID));
                }
                else
                  MACSiloHelper.CopyToEntMACSilo(objMACSilo, toEnt);
              }
              macRepository.Update(byId);
            }
          }
          macRepository.Save();
          transactionScope.Complete();
          return true;
        }
        catch (System.Exception ex)
        {
          TramTronLogger.WriteError(ex);
          return ex.InnerException == null || !ex.InnerException.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint");
        }
      }
    }

    private string BuildString_MACSiloEventLog(IList<ObjMACSilo> lst)
    {
      string str1 = "#1@#";
      string str2 = "#2@#";
      string empty = string.Empty;
      foreach (ObjMACSilo objMacSilo in (IEnumerable<ObjMACSilo>) lst)
      {
        if (!objMacSilo.MarkAsDeleted)
          empty += string.Format("{0}{1}{2}{3}", (object) str1, (object) objMacSilo.NPSiloMaSilo, (object) str2, (object) objMacSilo.SiloValue);
      }
      return empty;
    }

    public ObjMACSilo GetMACSiloByKey(int miID)
    {
      return MACSiloHelper.BuildNewObjMACSilo(IoC.Current.Container.Resolve<IMACSiloRepository>().GetById(miID));
    }

    public IList<ObjMACSilo> ListMACSilo()
    {
      return MACSiloHelper.BuildListObjMACSilo(IoC.Current.Container.Resolve<IMACSiloRepository>().SelectAll());
    }

    public IList<ObjMACSilo> ListMACSilo_ByMACID(int macID)
    {
      return MACSiloHelper.BuildListObjMACSilo(IoC.Current.Container.Resolve<IMACSiloRepository>().ListMACSilo_ByMACID(macID));
    }

    public IList<ObjMACSilo> ListMACSilo_ByPhieuTronID(int ptID)
    {
      return MACSiloHelper.BuildListObjMACSilo((IList<MACSilo>) IoC.Current.Container.Resolve<IPhieuTronRepository>().GetById(ptID).HopDong.MAC.MACSiloes.ToList<MACSilo>());
    }

    public IList<ObjMACSilo> ListMACSilo_ByHopDongID(int hdID)
    {
      return MACSiloHelper.BuildListObjMACSilo((IList<MACSilo>) IoC.Current.Container.Resolve<IHopDongRepository>().GetById(hdID).MAC.MACSiloes.ToList<MACSilo>());
    }

    public bool SaveMACSilo(IList<ObjMACSilo> lstCT)
    {
      IMACSiloRepository macSiloRepository = IoC.Current.Container.Resolve<IMACSiloRepository>();
      foreach (ObjMACSilo objMACSilo in (IEnumerable<ObjMACSilo>) lstCT)
      {
        if (objMACSilo.MarkAsDeleted)
        {
          macSiloRepository.Delete(macSiloRepository.GetById(objMACSilo.MACSiloID));
        }
        else
        {
          MACSilo entity = MACSiloHelper.BuildNewEntMACSilo(objMACSilo);
          macSiloRepository.Add(entity);
        }
      }
      macSiloRepository.Save();
      return true;
    }

    public ObjMaterial GetMaterialByKey(int miID)
    {
      return MaterialHelper.BuildNewObjMaterial(IoC.Current.Container.Resolve<IMaterialRepository>().GetById(miID));
    }

    public IList<ObjMaterial> ListMaterial()
    {
      return MaterialHelper.BuildListObjMaterial(IoC.Current.Container.Resolve<IMaterialRepository>().SelectAll());
    }

    public IList<ObjMaterial> ListMaterial_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maVT,
      string tenVT,
      bool? active)
    {
      return MaterialHelper.BuildListObjMaterial(IoC.Current.Container.Resolve<IMaterialRepository>().ListMaterial_ByCondition(fromDate, toDate, maVT, tenVT, active));
    }

    public bool SaveMaterial(IList<ObjMaterial> lst)
    {
      IMaterialRepository materialRepository = IoC.Current.Container.Resolve<IMaterialRepository>();
      try
      {
        using (TransactionScope transactionScope = new TransactionScope())
        {
          foreach (ObjMaterial objMaterial in (IEnumerable<ObjMaterial>) lst)
          {
            if (objMaterial.MarkAsDeleted)
              materialRepository.Delete(materialRepository.GetById(objMaterial.MaterialID));
            else if (objMaterial.IsNewObject)
            {
              Material entity = MaterialHelper.BuildNewEntMaterial(objMaterial);
              entity.CreatedBy = new int?(GlobalValues.UserID);
              entity.CreationDate = new DateTime?(DateTime.Now);
              materialRepository.Add(entity);
            }
            else
            {
              Material byId = materialRepository.GetById(objMaterial.MaterialID);
              MaterialHelper.CopyToEntMaterial(objMaterial, byId);
              byId.LatestUpdatedBy = new int?(GlobalValues.UserID);
              byId.LatestUpdateDate = new DateTime?(DateTime.Now);
              materialRepository.Update(byId);
            }
          }
          materialRepository.Save();
          transactionScope.Complete();
          return true;
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        if (ex.InnerException != null)
        {
          if (ex.InnerException.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
            return false;
        }
      }
      return false;
    }

    public ObjMeTron GetMeTronByKey(int miID)
    {
      return MeTronHelper.BuildNewObjMeTron(IoC.Current.Container.Resolve<IMeTronRepository>().GetById(miID));
    }

    public IList<ObjMeTron> ListMeTron()
    {
      return MeTronHelper.BuildListObjMeTron(IoC.Current.Container.Resolve<IMeTronRepository>().SelectAll());
    }

    public IList<ObjMeTron> ListMeTronByPhieuTronID(int ptID)
    {
      return MeTronHelper.BuildListObjMeTron((IList<MeTron>) IoC.Current.Container.Resolve<IMeTronRepository>().DoQuery().Where<MeTron>((Expression<Func<MeTron, bool>>) (o => o.PhieuTronID == ptID)).ToList<MeTron>());
    }

    public bool SaveMeTron(IList<ObjMeTron> lstCT)
    {
      IMeTronRepository meTronRepository = IoC.Current.Container.Resolve<IMeTronRepository>();
      foreach (ObjMeTron objMeTron in (IEnumerable<ObjMeTron>) lstCT)
      {
        if (objMeTron.MarkAsDeleted)
        {
          meTronRepository.Delete(meTronRepository.GetById(objMeTron.MeTronID));
        }
        else
        {
          MeTron entity = MeTronHelper.BuildNewEntMeTron(objMeTron);
          meTronRepository.Add(entity);
        }
      }
      meTronRepository.Save();
      return true;
    }

    public ObjMeTronChiTiet GetMeTronChiTietByKey(int miID)
    {
      return MeTronChiTietHelper.BuildNewObjMeTronChiTiet(IoC.Current.Container.Resolve<IMeTronChiTietRepository>().GetById(miID));
    }

    public IList<ObjMeTronChiTiet> ListMeTronChiTiet()
    {
      return MeTronChiTietHelper.BuildListObjMeTronChiTiet(IoC.Current.Container.Resolve<IMeTronChiTietRepository>().SelectAll());
    }

    public IList<ObjMeTronChiTiet> ListMeTronChiTietByPhieuTronID(int ptID)
    {
      return MeTronChiTietHelper.BuildListObjMeTronChiTiet((IList<MeTronChiTiet>) IoC.Current.Container.Resolve<IMeTronChiTietRepository>().DoQuery().Where<MeTronChiTiet>((Expression<Func<MeTronChiTiet, bool>>) (o => o.MeTron.PhieuTronID == ptID)).ToList<MeTronChiTiet>());
    }

    public IList<ObjMeTronChiTietGiaoHang> ListMeTronChiTietGiaoHangByPhieuTronID(int ptID)
    {
      return MeTronChiTietGiaoHangHelper.BuildListObjMeTronChiTiet((IList<MeTronChiTietGiaoHang>) IoC.Current.Container.Resolve<IMeTronChiTietGiaoHangRepository>().DoQuery().Where<MeTronChiTietGiaoHang>((Expression<Func<MeTronChiTietGiaoHang, bool>>) (o => o.MeTron.PhieuTronID == ptID)).ToList<MeTronChiTietGiaoHang>());
    }

    public bool SaveMeTronChiTiet(IList<ObjMeTronChiTiet> lstCT)
    {
      IMeTronChiTietRepository chiTietRepository = IoC.Current.Container.Resolve<IMeTronChiTietRepository>();
      foreach (ObjMeTronChiTiet objMeTronChiTiet in (IEnumerable<ObjMeTronChiTiet>) lstCT)
      {
        if (objMeTronChiTiet.MarkAsDeleted)
        {
          chiTietRepository.Delete(chiTietRepository.GetById(objMeTronChiTiet.MeTronChiTietID));
        }
        else
        {
          MeTronChiTiet entity = MeTronChiTietHelper.BuildNewEntMeTronChiTiet(objMeTronChiTiet);
          chiTietRepository.Add(entity);
        }
      }
      chiTietRepository.Save();
      return true;
    }

    public ObjMeTronChiTiet SaveMeTronChiTiet(ObjMeTronChiTiet objMTCT, int phieuTronID1)
    {
      IMeTronChiTietRepository chiTietRepository = IoC.Current.Container.Resolve<IMeTronChiTietRepository>();
      IMeTronRepository meTronRepository = IoC.Current.Container.Resolve<IMeTronRepository>();
      IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
      PhieuTron entity1 = phieuTronRepository.GetLastest();
      if (entity1 == null)
      {
        entity1 = new PhieuTron()
        {
          MaPhieuTron = "PHIEU_RONG",
          NgayPhieuTron = new DateTime?(DateTime.Now)
        };
        phieuTronRepository.Add(entity1);
        phieuTronRepository.Save();
      }
      MeTron entity2 = (MeTron) null;
      MeTron tronFromPhieuTron = meTronRepository.GetLatestMeTronFromPhieuTron(entity1.PhieuTronID);
      bool flag = false;
      if (tronFromPhieuTron == null)
      {
        int? sttSiloPlc = objMTCT.STTSiloPLC;
        int num = 0;
        if (sttSiloPlc.GetValueOrDefault() == num && sttSiloPlc.HasValue)
          flag = true;
      }
      if (flag)
      {
        entity2 = new MeTron()
        {
          PhieuTronID = entity1.PhieuTronID,
          LnNo = objMTCT.STTSiloPLC,
          IsManual = objMTCT.IsManual,
          NgayMeTron = new DateTime?(DateTime.Now),
          KhoiLuong = entity1.KLDuTinhCuaTungMe,
          CreatedBy = new int?(GlobalValues.UserID),
          CreationDate = new DateTime?(DateTime.Now)
        };
        meTronRepository.Add(entity2);
      }
      if (entity2 == null)
        entity2 = meTronRepository.GetMeTron(entity1.PhieuTronID, objMTCT.STTSiloPLC.Value);
      if (entity2 == null)
      {
        entity2 = new MeTron()
        {
          PhieuTronID = entity1.PhieuTronID,
          LnNo = objMTCT.STTSiloPLC,
          IsManual = objMTCT.IsManual,
          NgayMeTron = new DateTime?(DateTime.Now),
          KhoiLuong = entity1.KLDuTinhCuaTungMe,
          CreatedBy = new int?(GlobalValues.UserID),
          CreationDate = new DateTime?(DateTime.Now)
        };
        meTronRepository.Add(entity2);
      }
      else
        meTronRepository.Update(entity2);
      meTronRepository.Save();
      objMTCT.MeTronID = entity2.MeTronID;
      MeTronChiTiet meTronChiTiet = MeTronChiTietHelper.BuildNewEntMeTronChiTiet(objMTCT);
      chiTietRepository.Add(meTronChiTiet);
      int? plcSaveId = objMTCT.PLCSaveId;
      int num1 = 1;
      if (plcSaveId.GetValueOrDefault() == num1 & plcSaveId.HasValue)
      {
        entity2.KhoiLuong = new Decimal?(0M);
        entity2.LatestUpdatedBy = new int?(GlobalValues.UserID);
        entity2.LatestUpdateDate = new DateTime?(DateTime.Now);
        meTronRepository.Update(entity2);
        meTronRepository.Save();
      }
      chiTietRepository.Save();
      MeTronChiTietHelper.CopyToObjMeTronChiTiet(meTronChiTiet, objMTCT);
      return objMTCT;
    }

    public ObjMeTronChiTietGiaoHang SaveMeTronChiTietGiaoHang(
      ObjMeTronChiTietGiaoHang objMTCT,
      int phieuTronID1)
    {
      IMeTronChiTietGiaoHangRepository giaoHangRepository = IoC.Current.Container.Resolve<IMeTronChiTietGiaoHangRepository>();
      IMeTronRepository meTronRepository = IoC.Current.Container.Resolve<IMeTronRepository>();
      IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
      PhieuTron entity1 = phieuTronRepository.GetLastest();
      if (entity1 == null)
      {
        entity1 = new PhieuTron()
        {
          MaPhieuTron = "PHIEU_RONG",
          NgayPhieuTron = new DateTime?(DateTime.Now)
        };
        phieuTronRepository.Add(entity1);
        phieuTronRepository.Save();
      }
      MeTron entity2 = (MeTron) null;
      MeTron tronFromPhieuTron = meTronRepository.GetLatestMeTronFromPhieuTron(entity1.PhieuTronID);
      bool flag = false;
      if (tronFromPhieuTron == null)
      {
        int? sttSiloPlc = objMTCT.STTSiloPLC;
        int num = 0;
        if (sttSiloPlc.GetValueOrDefault() == num && sttSiloPlc.HasValue)
          flag = true;
      }
      if (flag)
      {
        entity2 = new MeTron()
        {
          PhieuTronID = entity1.PhieuTronID,
          LnNo = objMTCT.STTSiloPLC,
          IsManual = objMTCT.IsManual,
          NgayMeTron = new DateTime?(DateTime.Now),
          KhoiLuong = entity1.KLDuTinhCuaTungMe,
          CreatedBy = new int?(GlobalValues.UserID),
          CreationDate = new DateTime?(DateTime.Now)
        };
        meTronRepository.Add(entity2);
      }
      if (entity2 == null)
        entity2 = meTronRepository.GetMeTron(entity1.PhieuTronID, objMTCT.STTSiloPLC.Value);
      if (entity2 == null)
      {
        entity2 = new MeTron()
        {
          PhieuTronID = entity1.PhieuTronID,
          LnNo = objMTCT.STTSiloPLC,
          IsManual = objMTCT.IsManual,
          NgayMeTron = new DateTime?(DateTime.Now),
          KhoiLuong = entity1.KLDuTinhCuaTungMe,
          CreatedBy = new int?(GlobalValues.UserID),
          CreationDate = new DateTime?(DateTime.Now)
        };
        meTronRepository.Add(entity2);
      }
      else
        meTronRepository.Update(entity2);
      meTronRepository.Save();
      objMTCT.MeTronID = entity2.MeTronID;
      MeTronChiTietGiaoHang tronChiTietGiaoHang = MeTronChiTietGiaoHangHelper.BuildNewEntMeTronChiTiet(objMTCT);
      giaoHangRepository.Add(tronChiTietGiaoHang);
      int? plcSaveId = objMTCT.PLCSaveId;
      int num1 = 1;
      if (plcSaveId.GetValueOrDefault() == num1 & plcSaveId.HasValue)
      {
        entity2.KhoiLuong = new Decimal?(0M);
        entity2.LatestUpdatedBy = new int?(GlobalValues.UserID);
        entity2.LatestUpdateDate = new DateTime?(DateTime.Now);
        meTronRepository.Update(entity2);
        meTronRepository.Save();
      }
      giaoHangRepository.Save();
      MeTronChiTietGiaoHangHelper.CopyToObjMeTronChiTiet(tronChiTietGiaoHang, objMTCT);
      return objMTCT;
    }

    public ObjNhomSilo GetNhomSiloByKey(int miID)
    {
      return NhomSiloHelper.BuildNewObjNhomSilo(IoC.Current.Container.Resolve<INhomSiloRepository>().GetById(miID));
    }

    public IList<ObjNhomSilo> ListNhomSilo()
    {
      return NhomSiloHelper.BuildListObjNhomSilo(IoC.Current.Container.Resolve<INhomSiloRepository>().SelectAll());
    }

    public bool SaveNhomSilo(IList<ObjNhomSilo> lstCT)
    {
      INhomSiloRepository nhomSiloRepository = IoC.Current.Container.Resolve<INhomSiloRepository>();
      foreach (ObjNhomSilo objNhomSilo in (IEnumerable<ObjNhomSilo>) lstCT)
      {
        if (objNhomSilo.MarkAsDeleted)
        {
          nhomSiloRepository.Delete(nhomSiloRepository.GetById(objNhomSilo.NhomSiloID));
        }
        else
        {
          NhomSilo entity = NhomSiloHelper.BuildNewEntNhomSilo(objNhomSilo);
          nhomSiloRepository.Update(entity);
        }
      }
      nhomSiloRepository.Save();
      return true;
    }

    public ObjPhieuTron GetPhieuTronByKey(int miID)
    {
      return PhieuTronHelper.BuildNewObjPhieuTron(IoC.Current.Container.Resolve<IPhieuTronRepository>().GetById(miID));
    }

    public ObjPhieuGiaoHang GetPhieuGiaoHangByKey(int miID)
    {
      return PhieuGiaoHangHelper.BuildNewObjPhieuTron(IoC.Current.Container.Resolve<IPhieuGiaoHangRepository>().GetById(miID));
    }

    public ObjPhieuTron GetPhieuTronByCode(string code)
    {
      PhieuTron byCode = IoC.Current.Container.Resolve<IPhieuTronRepository>().GetByCode(code);
      return byCode != null ? PhieuTronHelper.BuildNewObjPhieuTron(byCode) : (ObjPhieuTron) null;
    }

    public ObjPhieuGiaoHang GetPhieuGiaoHangByCode(string code)
    {
      PhieuGiaoHang byCode = IoC.Current.Container.Resolve<IPhieuGiaoHangRepository>().GetByCode(code);
      return byCode != null ? PhieuGiaoHangHelper.BuildNewObjPhieuTron(byCode) : (ObjPhieuGiaoHang) null;
    }

    public IList<ObjPhieuTron> ListPhieuTron()
    {
      return PhieuTronHelper.BuildListObjPhieuTron(IoC.Current.Container.Resolve<IPhieuTronRepository>().SelectAll());
    }

    public IList<ObjPhieuGiaoHang> ListPhieuGiaoHang()
    {
      return PhieuGiaoHangHelper.BuildListObjPhieuTron(IoC.Current.Container.Resolve<IPhieuGiaoHangRepository>().SelectAll());
    }

    public IList<ObjPhieuTron> ListPhieuTron_ForTronOnline()
    {
      return PhieuTronHelper.BuildListObjPhieuTron(IoC.Current.Container.Resolve<IPhieuTronRepository>().ListPhieuTron_ForTronOnline());
    }

    public IList<ObjPhieuTron> ListPhieuTron_ByStatus(int status)
    {
      return PhieuTronHelper.BuildListObjPhieuTron(IoC.Current.Container.Resolve<IPhieuTronRepository>().ListPhieuTron_ByStatus(status));
    }

    public IList<ObjPhieuTron> ListPhieuTron_ByIsQueued(bool isQueued)
    {
      return PhieuTronHelper.BuildListObjPhieuTron(IoC.Current.Container.Resolve<IPhieuTronRepository>().ListPhieuTron_ByIsQueued(isQueued));
    }

    public IList<ObjPhieuGiaoHang> ListPhieuGiaoHang_ByIsQueued(bool isQueued)
    {
      return PhieuGiaoHangHelper.BuildListObjPhieuTron(IoC.Current.Container.Resolve<IPhieuGiaoHangRepository>().ListPhieuTron_ByIsQueued(isQueued));
    }

    public IList<ObjPhieuTron> ListPhieuTron_ByCondition(
      string maPhieuTron,
      DateTime fromDate,
      DateTime toDate,
      int? status,
      bool? isQueued)
    {
      return PhieuTronHelper.BuildListObjPhieuTron(IoC.Current.Container.Resolve<IPhieuTronRepository>().ListPhieuTron_ByCondition(maPhieuTron, fromDate, toDate, status, isQueued));
    }

    public IList<ObjPhieuGiaoHang> ListPhieuGiaoHang_ByCondition(
      string maPhieuTron,
      DateTime fromDate,
      DateTime toDate,
      bool? isQueued)
    {
      return PhieuGiaoHangHelper.BuildListObjPhieuTron(IoC.Current.Container.Resolve<IPhieuGiaoHangRepository>().ListPhieuTron_ByCondition(maPhieuTron, fromDate, toDate, isQueued));
    }

    public IList<string> ListMaPhieuTron_AutoComplete(string strInput, int? length)
    {
      return IoC.Current.Container.Resolve<IPhieuTronRepository>().ListMaPhieuTron_AutoComplete(strInput, length);
    }

    public IList<ObjPhieuTron> ListPhieuTron_AutoComplete(string strInput, int? length)
    {
      return PhieuTronHelper.BuildListObjPhieuTron(IoC.Current.Container.Resolve<IPhieuTronRepository>().ListPhieuTron_AutoComplete(strInput, length));
    }

    public bool SavePhieuTron(IList<ObjPhieuTron> lstPT)
    {
      IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
      IHopDongRepository hopDongRepository = IoC.Current.Container.Resolve<IHopDongRepository>();
      foreach (ObjPhieuTron objPhieuTron in (IEnumerable<ObjPhieuTron>) lstPT)
      {
        if (objPhieuTron.MarkAsDeleted)
        {
          phieuTronRepository.Delete(phieuTronRepository.GetById(objPhieuTron.PhieuTronID));
        }
        else
        {
          PhieuTron phieuTron;
          if (objPhieuTron.IsNewObject)
          {
            phieuTron = PhieuTronHelper.BuildNewEntPhieuTron(objPhieuTron);
            HopDong byId = hopDongRepository.GetById(objPhieuTron.HopDongID.Value);
            HopDong hopDong = byId;
            Decimal? klTaoPhieuTron = hopDong.KLTaoPhieuTron;
            Decimal? klDuTinh = phieuTron.KLDuTinh;
            hopDong.KLTaoPhieuTron = klTaoPhieuTron.HasValue & klDuTinh.HasValue ? new Decimal?(klTaoPhieuTron.GetValueOrDefault() + klDuTinh.GetValueOrDefault()) : new Decimal?();
            byId.Status = new int?(1);
            hopDongRepository.Update(byId);
            hopDongRepository.Save();
          }
          else
          {
            phieuTron = phieuTronRepository.GetById(objPhieuTron.PhieuTronID);
            HopDong hopDong = phieuTron.HopDong;
            Decimal? klTaoPhieuTron = hopDong.KLTaoPhieuTron;
            Decimal? klDuTinh1 = objPhieuTron.KLDuTinh;
            Decimal? klDuTinh2 = phieuTron.KLDuTinh;
            Decimal? nullable = klDuTinh1.HasValue & klDuTinh2.HasValue ? new Decimal?(klDuTinh1.GetValueOrDefault() - klDuTinh2.GetValueOrDefault()) : new Decimal?();
            hopDong.KLTaoPhieuTron = klTaoPhieuTron.HasValue & nullable.HasValue ? new Decimal?(klTaoPhieuTron.GetValueOrDefault() + nullable.GetValueOrDefault()) : new Decimal?();
            PhieuTronHelper.CopyToEntPhieuTron(objPhieuTron, phieuTron);
          }
          phieuTronRepository.Add(phieuTron);
        }
      }
      phieuTronRepository.Save();
      return true;
    }

    public bool SavePhieuGiaoHang(IList<ObjPhieuGiaoHang> lstPT)
    {
      IPhieuGiaoHangRepository giaoHangRepository = IoC.Current.Container.Resolve<IPhieuGiaoHangRepository>();
      foreach (ObjPhieuGiaoHang objPhieuGiaoHang in (IEnumerable<ObjPhieuGiaoHang>) lstPT)
      {
        if (objPhieuGiaoHang.MarkAsDeleted)
          giaoHangRepository.Delete(giaoHangRepository.GetById(objPhieuGiaoHang.PhieuTronID));
        else if (objPhieuGiaoHang.IsNewObject)
        {
          PhieuGiaoHang entity = PhieuGiaoHangHelper.BuildNewEntPhieuTron(objPhieuGiaoHang);
          entity.GioBD = DateTime.Now.ToString("HH:mm:ss");
          entity.GioKT = DateTime.Now.AddMinutes((double) ConfigManager.TramTronConfig.AddMinuteGioKT).ToString("HH:mm:ss");
          entity.CreatedBy = new int?(GlobalValues.UserID);
          entity.CreationDate = new DateTime?(DateTime.Now);
          giaoHangRepository.Add(entity);
        }
        else
        {
          PhieuGiaoHang byId = giaoHangRepository.GetById(objPhieuGiaoHang.PhieuTronID);
          PhieuGiaoHangHelper.CopyToEntPhieuTron(objPhieuGiaoHang, byId);
          byId.LatestUpdatedBy = new int?(GlobalValues.UserID);
          byId.LatestUpdateDate = new DateTime?(DateTime.Now);
          giaoHangRepository.Update(byId);
        }
      }
      giaoHangRepository.Save();
      return true;
    }

    public bool AddOrAttachPhieuTron(ObjPhieuTron objPT)
    {
      IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
      phieuTronRepository.Add(PhieuTronHelper.BuildNewEntPhieuTron(objPT));
      phieuTronRepository.Save();
      return true;
    }

    public bool UpdatePhieuTron(ObjPhieuTron objPT, Decimal klThuc)
    {
      try
      {
        IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
        PhieuTron byId = phieuTronRepository.GetById(objPT.PhieuTronID);
        if (byId == null)
          return false;
        byId.KLThuc = new Decimal?(klThuc);
        byId.LatestUpdateDate = new DateTime?(DateTime.Now);
        phieuTronRepository.Update(byId);
        phieuTronRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public bool UpdatePhieuGiaoHang(ObjPhieuGiaoHang objPT, string gioKT)
    {
      try
      {
        IPhieuGiaoHangRepository giaoHangRepository = IoC.Current.Container.Resolve<IPhieuGiaoHangRepository>();
        PhieuGiaoHang byId = giaoHangRepository.GetById(objPT.PhieuTronID);
        if (byId == null)
          return false;
        byId.GioKT = gioKT;
        byId.LatestUpdateDate = new DateTime?(DateTime.Now);
        giaoHangRepository.Update(byId);
        giaoHangRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public bool ResolveUnfinishPhieuTron1()
    {
      IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
      foreach (PhieuTron entity in (IEnumerable<PhieuTron>) phieuTronRepository.ListPhieuTron_ForTronOnline())
      {
        int? status = entity.Status;
        int num = 3;
        if (status.GetValueOrDefault() == num & status.HasValue)
        {
          entity.Status = new int?(5);
          phieuTronRepository.Update(entity);
        }
      }
      phieuTronRepository.Save();
      return true;
    }

    public bool ResolveUnfinishPhieuTron()
    {
      try
      {
        IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
        PhieuTron lastest = phieuTronRepository.GetLastest();
        lastest.Status = new int?(5);
        phieuTronRepository.Update(lastest);
        phieuTronRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public ObjSilo GetSiloByKey(int miID)
    {
      return SiloHelper.BuildNewObjSilo(IoC.Current.Container.Resolve<ISiloRepository>().GetById(miID));
    }

    public IList<ObjSilo> ListSilo()
    {
      return SiloHelper.BuildListObjSilo(IoC.Current.Container.Resolve<ISiloRepository>().SelectAll());
    }

    public IList<ObjSilo> ListSilo_ByActivated(bool activated)
    {
      return SiloHelper.BuildListObjSilo(IoC.Current.Container.Resolve<ISiloRepository>().ListSilo_ByActivated(activated));
    }

    public IList<ObjSilo> ListSilo_ByActivated_MaNhomSilo(bool? activated, string maNhomSL)
    {
      return SiloHelper.BuildListObjSilo(IoC.Current.Container.Resolve<ISiloRepository>().ListSilo_ByActivated_MaNhomSilo(activated, maNhomSL));
    }

    public bool SaveSilo(IList<ObjSilo> lstSilo)
    {
      ISiloRepository siloRepository = IoC.Current.Container.Resolve<ISiloRepository>();
      using (TransactionScope transactionScope = new TransactionScope())
      {
        foreach (ObjSilo objSilo in (IEnumerable<ObjSilo>) lstSilo)
        {
          if (objSilo.MarkAsDeleted)
          {
            siloRepository.Delete(siloRepository.GetById(objSilo.SiloID));
            this.InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "SILO_DEL", objSilo.MaSilo, string.Empty, string.Empty);
          }
          else if (objSilo.IsNewObject)
          {
            Silo entity = SiloHelper.BuildNewEntSilo(objSilo);
            siloRepository.Add(entity);
            this.InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "SILO_NEW", objSilo.MaSilo, string.Empty, string.Empty);
          }
          else
          {
            Silo byId = siloRepository.GetById(objSilo.SiloID);
            string oldValueText = SiloHelper.GenMemberValues(byId);
            string newValueText = SiloHelper.GenMemberValues(objSilo);
            this.InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "SILO_EDIT", objSilo.MaSilo, oldValueText, newValueText);
            SiloHelper.CopyToEntSilo(objSilo, byId);
            siloRepository.Update(byId);
          }
        }
        siloRepository.Save();
        transactionScope.Complete();
        return true;
      }
    }

    public ObjWeigh GetWeighByKey(int miID)
    {
      return WeighHelper.BuildNewObjWeigh(IoC.Current.Container.Resolve<IWeighRepository>().GetById(miID));
    }

    public IList<ObjWeigh> ListWeigh()
    {
      return WeighHelper.BuildListObjWeigh(IoC.Current.Container.Resolve<IWeighRepository>().SelectAll());
    }

    public bool SaveWeigh(IList<ObjWeigh> lstCT)
    {
      IWeighRepository weighRepository = IoC.Current.Container.Resolve<IWeighRepository>();
      foreach (ObjWeigh objWeigh in (IEnumerable<ObjWeigh>) lstCT)
      {
        if (objWeigh.MarkAsDeleted)
        {
          weighRepository.Delete(weighRepository.GetById(objWeigh.WeighID));
        }
        else
        {
          Weigh entity = WeighHelper.BuildNewEntWeigh(objWeigh);
          weighRepository.Update(entity);
        }
      }
      weighRepository.Save();
      return true;
    }

    public ObjWeiSiloSaving GetWeiSiloSavingByKey(int miID)
    {
      return WeiSiloSavingHelper.BuildNewObjWeiSiloSaving(IoC.Current.Container.Resolve<IWeiSiloSavingRepository>().GetById(miID));
    }

    public IList<ObjWeiSiloSaving> ListWeiSiloSaving()
    {
      return WeiSiloSavingHelper.BuildListObjWeiSiloSaving(IoC.Current.Container.Resolve<IWeiSiloSavingRepository>().SelectAll());
    }

    public bool SaveWeiSiloSaving(IList<ObjWeiSiloSaving> lstCT)
    {
      IWeiSiloSavingRepository savingRepository = IoC.Current.Container.Resolve<IWeiSiloSavingRepository>();
      foreach (ObjWeiSiloSaving objWeiSiloSaving in (IEnumerable<ObjWeiSiloSaving>) lstCT)
      {
        if (objWeiSiloSaving.MarkAsDeleted)
        {
          savingRepository.Delete(savingRepository.GetById(objWeiSiloSaving.WeiSiloSavingID));
        }
        else
        {
          WeiSiloSaving entity = WeiSiloSavingHelper.BuildNewEntWeiSiloSaving(objWeiSiloSaving);
          savingRepository.Update(entity);
        }
      }
      savingRepository.Save();
      return true;
    }

    public ObjWeiSiloVisible GetWeiSiloVisibleByKey(int miID)
    {
      return WeiSiloVisibleHelper.BuildNewObjWeiSiloVisible(IoC.Current.Container.Resolve<IWeiSiloVisibleRepository>().GetById(miID));
    }

    public IList<ObjWeiSiloVisible> ListWeiSiloVisible()
    {
      return WeiSiloVisibleHelper.BuildListObjWeiSiloVisible(IoC.Current.Container.Resolve<IWeiSiloVisibleRepository>().SelectAll());
    }

    public bool SaveWeiSiloVisible(IList<ObjWeiSiloVisible> lstCT)
    {
      IWeiSiloVisibleRepository visibleRepository = IoC.Current.Container.Resolve<IWeiSiloVisibleRepository>();
      foreach (ObjWeiSiloVisible objWeiSiloVisible in (IEnumerable<ObjWeiSiloVisible>) lstCT)
      {
        if (objWeiSiloVisible.MarkAsDeleted)
        {
          visibleRepository.Delete(visibleRepository.GetById(objWeiSiloVisible.WeiSiloVisibleID));
        }
        else
        {
          WeiSiloVisible entity = WeiSiloVisibleHelper.BuildNewEntWeiSiloVisible(objWeiSiloVisible);
          visibleRepository.Update(entity);
        }
      }
      visibleRepository.Save();
      return true;
    }

    public ObjHangMuc GetHangMucByKey(int miID)
    {
      return HangMucHelper.BuildNewObjHangMuc(IoC.Current.Container.Resolve<IHangMucRepository>().GetById(miID));
    }

    public IList<ObjHangMuc> ListHangMuc()
    {
      return HangMucHelper.BuildListObjHangMuc(IoC.Current.Container.Resolve<IHangMucRepository>().SelectAll());
    }

    public IList<ObjHangMuc> ListHangMuc_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      bool? active)
    {
      return HangMucHelper.BuildListObjHangMuc(IoC.Current.Container.Resolve<IHangMucRepository>().ListHangMuc_ByCondition(fromDate, toDate, maKH, tenKH, active));
    }

    public bool SaveHangMuc(IList<ObjHangMuc> lst)
    {
      IHangMucRepository hangMucRepository = IoC.Current.Container.Resolve<IHangMucRepository>();
      try
      {
        using (TransactionScope transactionScope = new TransactionScope())
        {
          foreach (ObjHangMuc objHangMuc in (IEnumerable<ObjHangMuc>) lst)
          {
            if (objHangMuc.MarkAsDeleted)
              hangMucRepository.Delete(hangMucRepository.GetById(objHangMuc.HangMucID));
            else if (objHangMuc.IsNewObject)
            {
              HangMuc entity = HangMucHelper.BuildNewEntHangMuc(objHangMuc);
              entity.CreatedBy = new int?(GlobalValues.UserID);
              entity.CreationDate = new DateTime?(DateTime.Now);
              hangMucRepository.Add(entity);
            }
            else
            {
              HangMuc byId = hangMucRepository.GetById(objHangMuc.HangMucID);
              HangMucHelper.CopyToEntHangMuc(objHangMuc, byId);
              byId.LatestUpdatedBy = new int?(GlobalValues.UserID);
              byId.LatestUpdateDate = new DateTime?(DateTime.Now);
              hangMucRepository.Update(byId);
            }
          }
          hangMucRepository.Save();
          transactionScope.Complete();
          return true;
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        if (ex.InnerException != null)
        {
          if (ex.InnerException.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
            return false;
        }
      }
      return false;
    }

    public ObjNhanVien GetNhanVienByKey(int miID)
    {
      return NhanVienHelper.BuildNewObjNhanVien(IoC.Current.Container.Resolve<INhanVienRepository>().GetById(miID));
    }

    public IList<ObjNhanVien> ListNhanVien()
    {
      return NhanVienHelper.BuildListObjNhanVien(IoC.Current.Container.Resolve<INhanVienRepository>().SelectAll());
    }

    public IList<ObjNhanVien> ListNhanVien_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      string phone,
      bool? active)
    {
      return NhanVienHelper.BuildListObjNhanVien(IoC.Current.Container.Resolve<INhanVienRepository>().ListNhanVien_ByCondition(fromDate, toDate, maKH, tenKH, phone, active));
    }

    public bool SaveNhanVien(IList<ObjNhanVien> lst)
    {
      INhanVienRepository nhanVienRepository = IoC.Current.Container.Resolve<INhanVienRepository>();
      try
      {
        using (TransactionScope transactionScope = new TransactionScope())
        {
          foreach (ObjNhanVien objNhanVien in (IEnumerable<ObjNhanVien>) lst)
          {
            if (objNhanVien.MarkAsDeleted)
              nhanVienRepository.Delete(nhanVienRepository.GetById(objNhanVien.NhanVienID));
            else if (objNhanVien.IsNewObject)
            {
              NhanVien entity = NhanVienHelper.BuildNewEntNhanVien(objNhanVien);
              entity.CreatedBy = new int?(GlobalValues.UserID);
              entity.CreationDate = new DateTime?(DateTime.Now);
              nhanVienRepository.Add(entity);
            }
            else
            {
              NhanVien byId = nhanVienRepository.GetById(objNhanVien.NhanVienID);
              NhanVienHelper.CopyToEntNhanVien(objNhanVien, byId);
              byId.LatestUpdatedBy = new int?(GlobalValues.UserID);
              byId.LatestUpdateDate = new DateTime?(DateTime.Now);
              nhanVienRepository.Update(byId);
            }
          }
          nhanVienRepository.Save();
          transactionScope.Complete();
          return true;
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        if (ex.InnerException != null)
        {
          if (ex.InnerException.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
            return false;
        }
      }
      return false;
    }

    public ObjTaiXe GetTaiXeByKey(int miID)
    {
      return TaiXeHelper.BuildNewObjTaiXe(IoC.Current.Container.Resolve<ITaiXeRepository>().GetById(miID));
    }

    public IList<ObjTaiXe> ListTaiXe()
    {
      return TaiXeHelper.BuildListObjTaiXe(IoC.Current.Container.Resolve<ITaiXeRepository>().SelectAll());
    }

    public IList<ObjTaiXe> ListTaiXe_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      string phone,
      bool? active)
    {
      return TaiXeHelper.BuildListObjTaiXe(IoC.Current.Container.Resolve<ITaiXeRepository>().ListTaiXe_ByCondition(fromDate, toDate, maKH, tenKH, phone, active));
    }

    public bool SaveTaiXe(IList<ObjTaiXe> lst)
    {
      ITaiXeRepository taiXeRepository = IoC.Current.Container.Resolve<ITaiXeRepository>();
      try
      {
        using (TransactionScope transactionScope = new TransactionScope())
        {
          foreach (ObjTaiXe objTaiXe in (IEnumerable<ObjTaiXe>) lst)
          {
            if (objTaiXe.MarkAsDeleted)
              taiXeRepository.Delete(taiXeRepository.GetById(objTaiXe.TaiXeID));
            else if (objTaiXe.IsNewObject)
            {
              TaiXe entity = TaiXeHelper.BuildNewEntTaiXe(objTaiXe);
              entity.CreatedBy = new int?(GlobalValues.UserID);
              entity.CreationDate = new DateTime?(DateTime.Now);
              taiXeRepository.Add(entity);
            }
            else
            {
              TaiXe byId = taiXeRepository.GetById(objTaiXe.TaiXeID);
              TaiXeHelper.CopyToEntTaiXe(objTaiXe, byId);
              byId.LatestUpdatedBy = new int?(GlobalValues.UserID);
              byId.LatestUpdateDate = new DateTime?(DateTime.Now);
              taiXeRepository.Update(byId);
            }
          }
          taiXeRepository.Save();
          transactionScope.Complete();
          return true;
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        if (ex.InnerException != null)
        {
          if (ex.InnerException.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
            return false;
        }
      }
      return false;
    }

    public ObjXe GetXeByKey(int miID)
    {
      return XeHelper.BuildNewObjXe(IoC.Current.Container.Resolve<IXeRepository>().GetById(miID));
    }

    public IList<ObjXe> ListXe()
    {
      return XeHelper.BuildListObjXe(IoC.Current.Container.Resolve<IXeRepository>().SelectAll());
    }

    public IList<ObjXe> ListXe_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string bienSo,
      bool? active)
    {
      return XeHelper.BuildListObjXe(IoC.Current.Container.Resolve<IXeRepository>().ListXe_ByCondition(fromDate, toDate, bienSo, active));
    }

    public bool SaveXe(IList<ObjXe> lst)
    {
      IXeRepository xeRepository = IoC.Current.Container.Resolve<IXeRepository>();
      try
      {
        using (TransactionScope transactionScope = new TransactionScope())
        {
          foreach (ObjXe objXe in (IEnumerable<ObjXe>) lst)
          {
            if (objXe.MarkAsDeleted)
              xeRepository.Delete(xeRepository.GetById(objXe.XeID));
            else if (objXe.IsNewObject)
            {
              Xe entity = XeHelper.BuildNewEntXe(objXe);
              entity.CreatedBy = new int?(GlobalValues.UserID);
              entity.CreationDate = new DateTime?(DateTime.Now);
              xeRepository.Add(entity);
            }
            else
            {
              Xe byId = xeRepository.GetById(objXe.XeID);
              XeHelper.CopyToEntXe(objXe, byId);
              byId.LatestUpdatedBy = new int?(GlobalValues.UserID);
              byId.LatestUpdateDate = new DateTime?(DateTime.Now);
              xeRepository.Update(byId);
            }
          }
          xeRepository.Save();
          transactionScope.Complete();
          return true;
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        if (ex.InnerException != null)
        {
          if (ex.InnerException.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
            return false;
        }
      }
      return false;
    }

    public ObjTimerPara GetTimerParaByKey(int miID)
    {
      return TimerParaHelper.BuildNewObjTimerPara(IoC.Current.Container.Resolve<ITimerParaRepository>().GetById(miID));
    }

    public IList<ObjTimerPara> ListTimerPara()
    {
      return TimerParaHelper.BuildListObjTimerPara(IoC.Current.Container.Resolve<ITimerParaRepository>().SelectAll());
    }

    public bool SaveTimerPara(IList<ObjTimerPara> lstCT)
    {
      ITimerParaRepository timerParaRepository = IoC.Current.Container.Resolve<ITimerParaRepository>();
      foreach (ObjTimerPara objTimerPara in (IEnumerable<ObjTimerPara>) lstCT)
      {
        if (objTimerPara.MarkAsDeleted)
        {
          timerParaRepository.Delete(timerParaRepository.GetById(objTimerPara.TimerParaID));
        }
        else
        {
          TimerPara entity = TimerParaHelper.BuildNewEntTimerPara(objTimerPara);
          timerParaRepository.Update(entity);
        }
      }
      timerParaRepository.Save();
      return true;
    }

    public ObjTinhDoHutNuoc GetTinhDoHutNuocByKey(int miID)
    {
      TinhDoHutNuoc byId = IoC.Current.Container.Resolve<ITinhDoHutNuocRepository>().GetById(miID);
      ObjTinhDoHutNuoc tinhDoHutNuocByKey = TinhDoHutNuocHelper.BuildNewObjTinhDoHutNuoc(byId);
      tinhDoHutNuocByKey.BLstTinhDoHutNuocChiTiet = new BindingList<ObjTinhDoHutNuocChiTiet>();
      foreach (TinhDoHutNuocChiTiet doHutNuocChiTiet in (IEnumerable<TinhDoHutNuocChiTiet>) byId.TinhDoHutNuocChiTiets)
        tinhDoHutNuocByKey.BLstTinhDoHutNuocChiTiet.Add(TinhDoHutNuocChiTietHelper.BuildNewObjTinhDoHutNuocChiTiet(doHutNuocChiTiet));
      return tinhDoHutNuocByKey;
    }

    public IList<ObjTinhDoHutNuoc> ListTinhDoHutNuoc()
    {
      return TinhDoHutNuocHelper.BuildListObjTinhDoHutNuoc(IoC.Current.Container.Resolve<ITinhDoHutNuocRepository>().SelectAll());
    }

    public bool SaveTinhDoHutNuoc(IList<ObjTinhDoHutNuoc> lstTDHN)
    {
      ITinhDoHutNuocRepository hutNuocRepository = IoC.Current.Container.Resolve<ITinhDoHutNuocRepository>();
      ITinhDoHutNuocChiTietRepository chiTietRepository = IoC.Current.Container.Resolve<ITinhDoHutNuocChiTietRepository>();
      foreach (ObjTinhDoHutNuoc objTinhDoHutNuoc in (IEnumerable<ObjTinhDoHutNuoc>) lstTDHN)
      {
        if (objTinhDoHutNuoc.MarkAsDeleted)
          hutNuocRepository.Delete(hutNuocRepository.GetById(objTinhDoHutNuoc.TinhDoHutNuocID));
        else if (objTinhDoHutNuoc.TinhDoHutNuocID > 0)
        {
          TinhDoHutNuoc byId = hutNuocRepository.GetById(objTinhDoHutNuoc.TinhDoHutNuocID);
          TinhDoHutNuocHelper.CopyToEntTinhDoHutNuoc(objTinhDoHutNuoc, byId);
          for (int index = byId.TinhDoHutNuocChiTiets.Count - 1; index >= 0; --index)
            chiTietRepository.Delete(byId.TinhDoHutNuocChiTiets.First<TinhDoHutNuocChiTiet>());
          chiTietRepository.Save();
          foreach (ObjTinhDoHutNuocChiTiet objTinhDoHutNuocChiTiet in (Collection<ObjTinhDoHutNuocChiTiet>) objTinhDoHutNuoc.BLstTinhDoHutNuocChiTiet)
            TinhDoHutNuocChiTietHelper.BuildNewEntTinhDoHutNuocChiTiet(objTinhDoHutNuocChiTiet).TinhDoHutNuoc = byId;
          hutNuocRepository.Add(byId);
        }
        else
        {
          TinhDoHutNuoc entity = TinhDoHutNuocHelper.BuildNewEntTinhDoHutNuoc(objTinhDoHutNuoc);
          foreach (ObjTinhDoHutNuocChiTiet objTinhDoHutNuocChiTiet in (Collection<ObjTinhDoHutNuocChiTiet>) objTinhDoHutNuoc.BLstTinhDoHutNuocChiTiet)
            TinhDoHutNuocChiTietHelper.BuildNewEntTinhDoHutNuocChiTiet(objTinhDoHutNuocChiTiet).TinhDoHutNuoc = entity;
          hutNuocRepository.Update(entity);
        }
      }
      hutNuocRepository.Save();
      return true;
    }

    public ObjPhieuTron SaveTronOnline(ObjPhieuTron objPT, List<ObjMeTron> lstMT)
    {
      try
      {
        IHopDongRepository hopDongRepository = IoC.Current.Container.Resolve<IHopDongRepository>();
        IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
        IMeTronRepository meTronRepository = IoC.Current.Container.Resolve<IMeTronRepository>();
        IMeTronChiTietRepository chiTietRepository = IoC.Current.Container.Resolve<IMeTronChiTietRepository>();
        foreach (ObjMeTron objMeTron in lstMT)
        {
          MeTron entity1 = MeTronHelper.BuildNewEntMeTron(objMeTron);
          entity1.CreatedBy = new int?(GlobalValues.UserID);
          entity1.CreationDate = new DateTime?(DateTime.Now);
          entity1.PhieuTronID = objPT.PhieuTronID;
          meTronRepository.Add(entity1);
          foreach (ObjMeTronChiTiet objMeTronChiTiet in objMeTron.LstMeTronChiTiet)
          {
            MeTronChiTiet entity2 = MeTronChiTietHelper.BuildNewEntMeTronChiTiet(objMeTronChiTiet);
            entity2.CreatedBy = new int?(GlobalValues.UserID);
            entity2.CreationDate = new DateTime?(DateTime.Now);
            entity2.MeTron = entity1;
            chiTietRepository.Add(entity2);
          }
        }
        meTronRepository.Save();
        chiTietRepository.Save();
        PhieuTron byId1 = phieuTronRepository.GetById(objPT.PhieuTronID);
        Decimal num1 = 0M;
        foreach (MeTron meTron in (IEnumerable<MeTron>) byId1.MeTrons)
        {
          Decimal valueOrDefault = objPT.KLDuTinhCuaTungMe.GetValueOrDefault();
          meTron.KhoiLuong = new Decimal?(valueOrDefault);
          meTronRepository.Update(meTron);
          num1 += valueOrDefault;
        }
        byId1.KLThuc = new Decimal?(num1);
        PhieuTron phieuTron1 = byId1;
        Decimal? slMeDaTron1 = phieuTron1.SLMeDaTron;
        Decimal count = (Decimal) lstMT.Count;
        phieuTron1.SLMeDaTron = slMeDaTron1.HasValue ? new Decimal?(slMeDaTron1.GetValueOrDefault() + count) : new Decimal?();
        Decimal? slMeDuTinh1 = byId1.SLMeDuTinh;
        Decimal? slMeDaTron2 = byId1.SLMeDaTron;
        Decimal? nullable;
        if (slMeDuTinh1.GetValueOrDefault() == slMeDaTron2.GetValueOrDefault() & slMeDuTinh1.HasValue == slMeDaTron2.HasValue)
        {
          byId1.Status = new int?(6);
        }
        else
        {
          Decimal? slMeDuTinh2 = byId1.SLMeDuTinh;
          nullable = byId1.SLMeDaTron;
          if (!(slMeDuTinh2.GetValueOrDefault() > nullable.GetValueOrDefault() & slMeDuTinh2.HasValue & nullable.HasValue))
            byId1.Status = new int?(7);
        }
        phieuTronRepository.Update(byId1);
        phieuTronRepository.Save();
        meTronRepository.Save();
        HopDong byId2 = hopDongRepository.GetById(objPT.HopDongID.Value);
        Decimal num2 = 0M;
        foreach (PhieuTron phieuTron2 in (IEnumerable<PhieuTron>) byId2.PhieuTrons)
        {
          Decimal num3 = num2;
          nullable = phieuTron2.KLThuc;
          Decimal num4 = nullable.Value;
          num2 = num3 + num4;
        }
        byId2.KLDaGiao = new Decimal?(num2);
        hopDongRepository.Add(byId2);
        hopDongRepository.Save();
        return PhieuTronHelper.BuildNewObjPhieuTron(byId1);
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        return (ObjPhieuTron) null;
      }
    }

    public bool SaveNhanVienTronOnline(int id)
    {
      try
      {
        IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
        PhieuTron lastest = phieuTronRepository.GetLastest();
        lastest.NhanVienID = new int?(id);
        phieuTronRepository.Update(lastest);
        phieuTronRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public bool SaveTaiXeTronOnline(int id)
    {
      try
      {
        IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
        PhieuTron lastest = phieuTronRepository.GetLastest();
        lastest.TaiXeID = new int?(id);
        phieuTronRepository.Update(lastest);
        phieuTronRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public bool SaveTaiXeTronOnlinePhieuGiaoHang(string id)
    {
      try
      {
        IPhieuGiaoHangRepository giaoHangRepository = IoC.Current.Container.Resolve<IPhieuGiaoHangRepository>();
        PhieuGiaoHang lastest = giaoHangRepository.GetLastest();
        lastest.TenTaiXe = id;
        giaoHangRepository.Update(lastest);
        giaoHangRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public bool SaveXeTronOnline(int id)
    {
      try
      {
        IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
        PhieuTron lastest = phieuTronRepository.GetLastest();
        lastest.XeID = new int?(id);
        phieuTronRepository.Update(lastest);
        phieuTronRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public bool SaveXeTronOnlinePhieuGiaoHang(string id)
    {
      try
      {
        IPhieuGiaoHangRepository giaoHangRepository = IoC.Current.Container.Resolve<IPhieuGiaoHangRepository>();
        PhieuGiaoHang lastest = giaoHangRepository.GetLastest();
        lastest.BienSo = id;
        giaoHangRepository.Update(lastest);
        giaoHangRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public bool SaveNiemChiTronOnline(string niemchi)
    {
      try
      {
        IPhieuTronRepository phieuTronRepository = IoC.Current.Container.Resolve<IPhieuTronRepository>();
        PhieuTron lastest = phieuTronRepository.GetLastest();
        lastest.MoTa = niemchi;
        phieuTronRepository.Update(lastest);
        phieuTronRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public bool SaveNiemChiTronOnlinePhieuGiaoHang(string niemchi)
    {
      try
      {
        IPhieuGiaoHangRepository giaoHangRepository = IoC.Current.Container.Resolve<IPhieuGiaoHangRepository>();
        PhieuGiaoHang lastest = giaoHangRepository.GetLastest();
        lastest.NiemChi = niemchi;
        giaoHangRepository.Update(lastest);
        giaoHangRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public bool UpdateDoAmSiloOnlineBySiloID(int siloID, Decimal doAm)
    {
      try
      {
        ISiloRepository siloRepository = IoC.Current.Container.Resolve<ISiloRepository>();
        Silo byId = siloRepository.GetById(siloID);
        byId.DoAm_NhomSlioAgg = new Decimal?(doAm);
        siloRepository.Update(byId);
        siloRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public bool UpdateHutNuocSiloOnlineBySiloID(int siloID, Decimal doHutNuoc)
    {
      try
      {
        ISiloRepository siloRepository = IoC.Current.Container.Resolve<ISiloRepository>();
        Silo byId = siloRepository.GetById(siloID);
        byId.DoHutNuoc_NhomSiloAgg = new Decimal?(doHutNuoc);
        siloRepository.Update(byId);
        siloRepository.Save();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public ObjMAC SaveMacThemBotNuoc1(int macId, Decimal themBotNuoc1)
    {
      try
      {
        IMACRepository macRepository = IoC.Current.Container.Resolve<IMACRepository>();
        MAC byId = macRepository.GetById(macId);
        byId.ThemBotNuoc1 = themBotNuoc1;
        macRepository.Update(byId);
        macRepository.Save();
        return MACHelper.BuildNewObjMAC(byId);
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        return (ObjMAC) null;
      }
    }

    public ObjMAC SaveMacThemBotNuoc2(int macId, Decimal themBotNuoc2)
    {
      try
      {
        IMACRepository macRepository = IoC.Current.Container.Resolve<IMACRepository>();
        MAC byId = macRepository.GetById(macId);
        byId.ThemBotNuoc2 = themBotNuoc2;
        macRepository.Update(byId);
        macRepository.Save();
        return MACHelper.BuildNewObjMAC(byId);
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        return (ObjMAC) null;
      }
    }

    public Objvw_DataMix GetDataMixByKey(int datamixID)
    {
      return vw_DataMixHelper.BuildNewObjvw_DataMix(IoC.Current.Container.Resolve<IViewDataMixRepository>().GetById(datamixID));
    }

    public IList<Objvw_DataMix> ListDataMix()
    {
      return vw_DataMixHelper.BuildListObjvw_DataMix(IoC.Current.Container.Resolve<IViewDataMixRepository>().SelectAll());
    }

    public IList<Objvw_DataMix> ListDataMix_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maPhieuTron,
      string khachHang,
      string congTruong,
      string hangMuc,
      string taiXe,
      string bienSo,
      string mac,
      string nhanVien)
    {
      return vw_DataMixHelper.BuildListObjvw_DataMix(IoC.Current.Container.Resolve<IViewDataMixRepository>().ListDataMix_ByCondition(fromDate, toDate, maPhieuTron, khachHang, congTruong, hangMuc, taiXe, bienSo, mac, nhanVien));
    }

    public IList<Objvw_DataMix> ListDataMix_ByCondition(
      DateTime? fromDate,
      TimeSpan? fromTime,
      DateTime? toDate,
      TimeSpan? toTime,
      string maPhieuTron,
      int? khachHang,
      int? congTruong,
      int? hangMuc,
      int? mac,
      int? bienSo,
      int? taiXe,
      int? nhanVien,
      bool? moPhong)
    {
      return vw_DataMixHelper.BuildListObjvw_DataMix(IoC.Current.Container.Resolve<IViewDataMixRepository>().ListDataMix_ByCondition(fromDate, toDate, maPhieuTron, khachHang, congTruong, hangMuc, mac, bienSo, taiXe, nhanVien, moPhong));
    }

    public IList<Objvw_SumWeight> ListSumWeight_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maPhieuTron,
      int? khachHang,
      int? congTruong,
      int? hangMuc,
      int? mac,
      int? bienSo,
      int? taiXe,
      int? nhanVien,
      bool? moPhong)
    {
      return vw_SumWeightHelper.BuildListObjvw_SumWeight(IoC.Current.Container.Resolve<IViewSumWeightRepository>().ListSumWeight_ByCondition(fromDate, toDate, maPhieuTron, khachHang, congTruong, hangMuc, mac, bienSo, taiXe, nhanVien, moPhong));
    }

    public ObjAggregationResult GetSumForIsQueuedAndTimeRange(
      DateTime? fromDate,
      DateTime? toDate,
      bool? mophong)
    {
      return vw_DataMixHelper.BuildNewAggregation(IoC.Current.Container.Resolve<IViewDataMixRepository>().GetSumForIsQueuedAndTimeRange(fromDate, toDate, mophong));
    }

    public IList<Objvw_MaterialDetailDayWithID> ListTotalMaterial_ByCondition(
      int? materialID,
      bool? isManual)
    {
      return vw_PvMaterialDetailDayWithIDHelper.BuildListObjvw_MaterialDetailDayWithID(IoC.Current.Container.Resolve<Ivw_MaterialDetailDayRepository>().ListvwMaterialDetailDay_ByCondition(new DateTime?(), new DateTime?(), materialID, isManual));
    }

    public IList<Objvw_MaterialDetailDayWithID> ListMaterialDetailDay_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      int? materialID,
      bool? isManual)
    {
      return vw_PvMaterialDetailDayWithIDHelper.BuildListObjvw_MaterialDetailDayWithID(IoC.Current.Container.Resolve<Ivw_MaterialDetailDayRepository>().ListvwMaterialDetailDay_ByCondition_Update(fromDate, toDate, materialID, isManual));
    }

    public IList<Objvw_TranferDetailDayWithID> ListTranferDetailDay_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      int? xeID,
      bool? isQueued)
    {
      return vw_TranferDetailDayWithIDHelper.BuildListObjvw_TranferDetailDayWithID(IoC.Current.Container.Resolve<Ivw_TranferDetailDayRepository>().ListTranferDetailDay_ByCondition_Update(fromDate, toDate, xeID, isQueued));
    }

    public IList<Objvw_TranferDetailDayWithID> ListTotalTranfer_ByCondition(
      int? xeID,
      bool? isManual)
    {
      return vw_TranferDetailDayWithIDHelper.BuildListObjvw_TranferDetailDayWithID(IoC.Current.Container.Resolve<Ivw_TotalTranferRepository>().ListvwTotalTranfer_ByCondition(xeID, isManual));
    }

    public IList<Objvw_DriverDetailDayWithID> ListTotalDriver_ByCondition(
      int? taixeID,
      bool? isManual)
    {
      return vw_DriverDetailDayWithIDHelper.BuildListObjvw_DriverDetailDayWithID(IoC.Current.Container.Resolve<Ivw_TotalDriverRepository>().ListvwTotalDriver_ByCondition(taixeID, isManual));
    }

    public IList<Objvw_DriverDetailDayWithID> ListDriverDetailDay__ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      int? taiXeID,
      bool? isManual)
    {
      return vw_DriverDetailDayWithIDHelper.BuildListObjvw_DriverDetailDayWithID(IoC.Current.Container.Resolve<Ivw_DriverDetailDayRepository>().ListDriverDetailDay_ByCondition_Update(fromDate, toDate, taiXeID, isManual));
    }

    public NhuaNong.Core.BusinessObject.DashboardStats GetDashboardStats()
    {
        var stats = new NhuaNong.Core.BusinessObject.DashboardStats();
        try
        {
            var phieuTronRepo = IoC.Current.Container.Resolve<IPhieuTronRepository>();
            var phieuGiaoHangRepo = IoC.Current.Container.Resolve<IPhieuGiaoHangRepository>();
            var eventLogRepo = IoC.Current.Container.Resolve<IEventLogRepository>();

            // Total Production
            stats.TotalProduction = (double)(phieuTronRepo.DoQuery().Sum(p => p.KLThuc) ?? 0);

            // Total Trips
            stats.TotalTrips = phieuGiaoHangRepo.DoQuery().Count();

            // Active Alerts (Today)
            var today = DateTime.Today;
            stats.ActiveAlerts = eventLogRepo.DoQuery().Count(e => e.LogDate >= today);
        }
        catch (Exception ex)
        {
            TramTronLogger.WriteError(ex);
        }
        return stats;
    }
  }
}
