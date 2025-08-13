// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.INNView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public interface INNView : IBase, IPermission
  {
    BindingList<ObjTaiXe> BLstTaiXe { set; }

    BindingList<ObjXe> BLstXe { set; }

    BindingList<ObjPhieuTron> BLstPhieuTron { set; }

    BindingList<ObjMAC> BLstMAC { set; }

    BindingList<ObjMACSilo> BLstMACSilo { set; }

    BindingList<ObjSilo> BLstSilo { set; }

    BindingList<ObjWeigh> BLstWeigh { set; }

    BindingList<ObjWeiSiloSaving> BLstWeiSiloSaving { set; }

    BindingList<ObjWeiSiloVisible> BLstWeiSiloVisible { set; }

    BindingList<ObjTimerPara> BLstTimerPara { set; }

    BindingList<ObjDuLieuTron> BLstDuLieuTron { set; }

    ObjMeTron CurMeTron { set; }

    ObjMeTronChiTiet CurMeTronChiTiet { set; }

    ObjMeTronChiTietGiaoHang CurMeTronChiTietGiaoHang { set; }

    SetPoint SP { set; }

    SetPoint_NotHD SP_NotHD { set; }

    SendingToPLC SO { set; }

    bool IsSuccessfulUpdatePT { set; }

    ObjPhieuTron SavingPhieuTron { set; }

    BindingList<Objvw_DataMix> BLstDataMix { set; }
  }
}
