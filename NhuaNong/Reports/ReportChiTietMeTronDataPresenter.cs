// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.ReportChiTietMeTronDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.MasterData;

#nullable disable
namespace NhuaNong.Reports
{
  public class ReportChiTietMeTronDataPresenter(IReportChiTietMeTron view) : 
    MasterDataPresenter<IReportChiTietMeTron>(view)
  {
    public void ListReportChiTietMeTron()
    {
      this._iView.BLstRptDBChiTiet = MasterDataPresenter<IReportChiTietMeTron>._iMasterDataModel.ListDataMix();
    }

    public void ListReportChiTietMeTron_ByCondition()
    {
    }
  }
}
