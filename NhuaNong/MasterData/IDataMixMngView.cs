// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.IDataMixMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using NhuaNong.Utils;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public interface IDataMixMngView : IBase, IPermission
  {
    BindingList<Objvw_DataMix> BLstDataMix { set; }

    BindingList<ObjKhachHang> BLstKhachHang { set; }

    BindingList<ObjCongTruong> BLstCongTruong { set; }

    BindingList<ObjHangMuc> BLstHangMuc { set; }

    BindingList<ObjMAC> BLstMAC { set; }

    BindingList<ObjSilo> BLstSilo { set; }

    BindingList<ObjXe> BLstXe { set; }

    BindingList<ObjTaiXe> BLstTaiXe { set; }

    BindingList<ObjNhanVien> BLstNhanVien { set; }

    List<FieldCode> LstDataMixStatus { set; }
  }
}
