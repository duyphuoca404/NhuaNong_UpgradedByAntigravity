// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.EventLogHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class EventLogHelper
  {
    public static void CopyToObjEventLog(EventLog fromEnt, ObjEventLog toObj)
    {
      toObj.EventLogID = fromEnt.EventLogID;
      toObj.LogCode = fromEnt.LogCode;
      toObj.LogDate = fromEnt.LogDate;
      toObj.UserID = fromEnt.UserID;
      toObj.UserName = fromEnt.UserName;
      toObj.EventActionCodeID = fromEnt.EventActionCodeID;
      toObj.EventActionContent = fromEnt.EventActionContent;
      toObj.Description = fromEnt.Description;
      toObj.OldValueNumeric = fromEnt.OldValueNumeric;
      toObj.NewValueNumeric = fromEnt.NewValueNumeric;
      toObj.OldValueText = fromEnt.OldValueText;
      toObj.NewValueText = fromEnt.NewValueText;
      toObj.Title1 = fromEnt.Title1;
      toObj.Value1 = fromEnt.Value1;
      toObj.Content1 = fromEnt.Content1;
      toObj.Title2 = fromEnt.Title2;
      toObj.Value2 = fromEnt.Value2;
      toObj.Content2 = fromEnt.Content2;
      toObj.Title3 = fromEnt.Title3;
      toObj.Value3 = fromEnt.Value3;
      toObj.Content3 = fromEnt.Content3;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      toObj.VersionNo = fromEnt.VersionNo;
      if (toObj.EventLogID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntEventLog(ObjEventLog fromObj, EventLog toEnt)
    {
      toEnt.EventLogID = fromObj.EventLogID;
      toEnt.LogCode = fromObj.LogCode;
      toEnt.LogDate = fromObj.LogDate;
      toEnt.UserID = fromObj.UserID;
      toEnt.UserName = fromObj.UserName;
      toEnt.EventActionCodeID = fromObj.EventActionCodeID;
      toEnt.EventActionContent = fromObj.EventActionContent;
      toEnt.Description = fromObj.Description;
      toEnt.OldValueNumeric = fromObj.OldValueNumeric;
      toEnt.NewValueNumeric = fromObj.NewValueNumeric;
      toEnt.OldValueText = fromObj.OldValueText;
      toEnt.NewValueText = fromObj.NewValueText;
      toEnt.Title1 = fromObj.Title1;
      toEnt.Value1 = fromObj.Value1;
      toEnt.Content1 = fromObj.Content1;
      toEnt.Title2 = fromObj.Title2;
      toEnt.Value2 = fromObj.Value2;
      toEnt.Content2 = fromObj.Content2;
      toEnt.Title3 = fromObj.Title3;
      toEnt.Value3 = fromObj.Value3;
      toEnt.Content3 = fromObj.Content3;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
      toEnt.VersionNo = fromObj.VersionNo;
    }

    public static ObjEventLog BuildNewObjEventLog(EventLog entEventLog)
    {
      ObjEventLog toObj = new ObjEventLog();
      EventLogHelper.CopyToObjEventLog(entEventLog, toObj);
      return toObj;
    }

    public static IList<ObjEventLog> BuildListObjEventLog(IList<EventLog> lstEntEventLog)
    {
      IList<ObjEventLog> objEventLogList = (IList<ObjEventLog>) new List<ObjEventLog>();
      foreach (EventLog entEventLog in (IEnumerable<EventLog>) lstEntEventLog)
        objEventLogList.Add(EventLogHelper.BuildNewObjEventLog(entEventLog));
      return objEventLogList;
    }

    public static EventLog BuildNewEntEventLog(ObjEventLog objEventLog)
    {
      EventLog toEnt = new EventLog();
      EventLogHelper.CopyToEntEventLog(objEventLog, toEnt);
      return toEnt;
    }

    public static IList<EventLog> BuildListEntEventLog(IList<ObjEventLog> lstObjEventLog)
    {
      IList<EventLog> eventLogList = (IList<EventLog>) new List<EventLog>();
      foreach (ObjEventLog objEventLog in (IEnumerable<ObjEventLog>) lstObjEventLog)
        eventLogList.Add(EventLogHelper.BuildNewEntEventLog(objEventLog));
      return eventLogList;
    }
  }
}
