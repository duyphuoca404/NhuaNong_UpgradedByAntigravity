using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.Office.Interop.Word;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.MasterData;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.KWS
{
  public partial class PrinterPheuTron : ControlViewBase, IPhieuTronMngView, IBase, IPermission
  {
    private PhieuTronMngDataPresenter _presenter;
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private BindingList<ObjPhieuTron> _blstPhieuTron = new BindingList<ObjPhieuTron>();
    private BindingList<ObjHopDong> _blstHopDong = new BindingList<ObjHopDong>();
    private BindingList<ObjMeTron> _blstMeTron = new BindingList<ObjMeTron>();
    private BindingList<ObjMeTronChiTiet> _blstMeTronChiTiet = new BindingList<ObjMeTronChiTiet>();
    private List<string> listPrinter = new List<string>();
    private List<string> lst = new List<string>();
    private PrintDialog printDialog;
    private PrintDocument printDocument;
    private int userID;
    private int objectX = 100;
    private int objectY = 100;
    private bool _error;
    private string sourceFileName = ConfigManager.TramTronConfig.PIPath;
    private string fileName = "";
    private string filePathMau = ConfigManager.TramTronConfig.PIPath;
    private string folderDesPhieuPath = ConfigManager.TramTronConfig.ReportPath;
    private string printerName;
    private int numberOfCopies;
    private Thread thread;
    

    public PrinterPheuTron()
    {
      this.InitializeComponent();
      this.Name = nameof(PrinterPheuTron);
      this._presenter = new PhieuTronMngDataPresenter((IPhieuTronMngView) this);
      this.SetCaption();
      using (Graphics graphics = this.CreateGraphics())
      {
        double dpiX = (double) graphics.DpiX;
        double dpiY = (double) graphics.DpiY;
      }
    }

    public BindingList<ObjPhieuTron> BLstPhieuTron
    {
      set
      {
        this._blstPhieuTron = value;
        this.grcPhieuTron.DataSource = (object) this._blstPhieuTron;
      }
    }

    public BindingList<ObjHopDong> BLstHopDong
    {
      set => this._blstHopDong = value;
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public List<FieldCode> LstPhieuTronStatus
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjMeTron> BLstMeTron
    {
      set => this._blstMeTron = value;
    }

    public BindingList<ObjMeTronChiTiet> BLstMeTronChiTiet
    {
      set => this._blstMeTronChiTiet = value;
    }

    public BindingList<ObjPhieuGiaoHang> BLstPhieuGiaoHang
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjMeTronChiTietGiaoHang> BLstMeTronChiTietGiaoHang
    {
      set => throw new NotImplementedException();
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      this.grvPhieuTron.RefreshData();
    }

    protected override void PopulateStaticData()
    {
      this.LoadSearchDefaultValues();
      this.printerName = ConfigManager.TramTronConfig.MayInPI;
    }

    protected override void PopulateData() => this.LoadPhieuTron();

    private void LoadSearchDefaultValues()
    {
      this.datTuNgay.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestPhieuTronDays);
      this.datDenNgay.EditValue = (object) DateTime.Now;
      DateTime dateTime = DateTime.Now;
      dateTime = dateTime.Date;
      this.tseToTime.EditValue = (object) dateTime.Add(new TimeSpan(23, 59, 59)).TimeOfDay;
    }

    private void LoadPhieuTron()
    {
      this._presenter.ListPhieuTron(string.Empty, Searching.BuildNew_StartDateTime(this.datTuNgay.DateTime, this.tseFromTime.TimeSpan), Searching.BuildNew_EndDateTime(this.datDenNgay.DateTime, this.tseToTime.TimeSpan), new int?(-1), new bool?());
    }

    private void SetCaption() => this.Caption = "Phiếu giao hàng";

    private void ClearDataPhieuTron()
    {
      this.datNgayTron.EditValue = (object) "";
      this.txtGioTron.Text = "";
      this.txtGioKTTron.Text = "";
      this.txtMaPhieuTron.Text = string.Empty;
      this.txtSTTPhieuTron.Text = string.Empty;
      this.txtTenMAC.Text = string.Empty;
      this.txtCuongDo.Text = string.Empty;
      this.txtDoSut.Text = string.Empty;
      this.txtTheTich.Text = string.Empty;
      this.txtKhoiLuongDatHang.Text = string.Empty;
      this.txtLuyKe.Text = string.Empty;
      this.txtTenKhachHang.Text = string.Empty;
      this.txtTenCongTruong.Text = string.Empty;
      this.txtDiaDiem.Text = string.Empty;
      this.txtNiemChi.Text = string.Empty;
      this.txtNguoiTron.Text = string.Empty;
      this.txtTaiXe.Text = string.Empty;
      this.txtXe.Text = string.Empty;
    }

    private void DoFocusPhieuTron()
    {
      this.ClearDataPhieuTron();
      if (!(this.grvPhieuTron.GetRow(this.grvPhieuTron.FocusedRowHandle) is ObjPhieuTron row))
        return;
      int phieuTronId = row.PhieuTronID;
      int? nullable1 = new int?(row.PhieuTronID);
      int num = 0;
      if (nullable1.GetValueOrDefault() == num & nullable1.HasValue)
        return;
      ObjPhieuTron phieuTronByKey = this._presenter.GetPhieuTronByKey(row.PhieuTronID);
      if (phieuTronByKey == null)
        return;
      int? nullable2 = phieuTronByKey.CreatedBy;
      if (nullable2.HasValue)
      {
        nullable2 = phieuTronByKey.CreatedBy;
        this.userID = nullable2.Value;
        this.txtNguoiTron.Text = this._ser.GetSEC_UserByKey(this.userID).FullName;
      }
      this.txtMaHopDong.Text = phieuTronByKey.NPHopDongMaHopDong;
      this.datNgayTron.EditValue = (object) phieuTronByKey.NgayPhieuTron;
      this.txtGioTron.Text = phieuTronByKey.NgayPhieuTron.Value.ToString("HH:mm:ss");
      if (phieuTronByKey.LatestUpdateDate.HasValue)
        this.txtGioKTTron.Text = phieuTronByKey.LatestUpdateDate.Value.ToString("HH:mm:ss");
      this.txtMaPhieuTron.Text = phieuTronByKey.MaPhieuTron;
      TextEdit txtSttPhieuTron = this.txtSTTPhieuTron;
      nullable2 = phieuTronByKey.NoPhieu;
      string str = nullable2.ToString();
      txtSttPhieuTron.Text = str;
      this.txtTenMAC.Text = phieuTronByKey.NPMACTenMAC;
      this.txtCuongDo.Text = phieuTronByKey.NPMACCuongDo;
      this.txtDoSut.Text = phieuTronByKey.NPMACDoSut;
      this.txtTenKhachHang.Text = phieuTronByKey.NPKhachHangTenKhachHang;
      this.txtTenCongTruong.Text = phieuTronByKey.NPCongTruongTenCongTruong;
      this.txtDiaDiem.Text = phieuTronByKey.NPCongTruongDiaChi;
      this.txtHangMuc.Text = phieuTronByKey.NPHangMucTenHangMuc;
      this.txtTaiXe.Text = phieuTronByKey.NPTaiXeTenTaiXe;
      this.txtXe.Text = phieuTronByKey.NPXeBienSo;
      this.txtNiemChi.Text = phieuTronByKey.MoTa;
      this.txtTheTich.Text = phieuTronByKey.KLDuTinh.ToString();
      this.txtLuyKe.Text = phieuTronByKey.KLThuc.ToString();
      this.txtKhoiLuongDatHang.Text = phieuTronByKey.NPHopDongKLDatHang.ToString();
    }

    private void LoadPrinters()
    {
      try
      {
        foreach (string installedPrinter in PrinterSettings.InstalledPrinters)
          this.listPrinter.Add(installedPrinter);
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show("Error loading printers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this.lookupEditPrinters.Properties.DataSource = (object) this.listPrinter;
    }

    private void PrinterPheuTron_Load(object sender, EventArgs e)
    {
      this.LoadPrinters();
      this.printDialog = new PrintDialog();
      this.printDocument = new PrintDocument();
      this.printDocument.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);
    }

    private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
      string s = "Hello, this is the content to be printed.";
      System.Drawing.Font font = new System.Drawing.Font("Arial", 12f);
      Brush black = Brushes.Black;
      e.Graphics.DrawString(s, font, black, (float) this.objectX, (float) this.objectY);
    }

    private void simpleButton3_Click(object sender, EventArgs e)
    {
      List<string> stringList = new List<string>()
      {
        ConfigManager.TramTronConfig.TenCty,
        this.datNgayTron.DateTime.ToString("dd-MM-yyyy"),
        this.txtTenCongTruong.Text,
        this.txtTenKhachHang.Text,
        this.txtTenMAC.Text,
        this.txtCuongDo.Text,
        this.txtSTTPhieuTron.Text,
        "200",
        this.txtDoSut.Text,
        this.txtTaiXe.Text,
        ConfigManager.TramTronConfig.KLChoLonNhat.ToString() + "m\u00B3",
        this.txtTheTich.Text + "m\u00B3",
        this.txtLuyKe.Text,
        this.txtXe.Text,
        this.txtGioTron.Text,
        this.txtDiaDiem.Text,
        this.txtMaPhieuTron.Text,
        "1m\u00B3",
        this.txtHangMuc.Text,
        this.txtNiemChi.Text,
        this.txtNguoiTron.Text,
        this.txtGioKTTron.Text
      };
    }

    private void simpleButton4_Click(object sender, EventArgs e)
    {
      ViewManager.ShowViewDialog((ControlViewBase) new PrinterPheuTronChiTiet());
    }

    private void simpleButton5_Click(object sender, EventArgs e)
    {
      List<string> stringList = new List<string>()
      {
        ConfigManager.TramTronConfig.TenCty,
        this.datNgayTron.DateTime.ToString("dd-MM-yyyy"),
        this.txtTenCongTruong.Text,
        this.txtTenKhachHang.Text,
        this.txtTenMAC.Text,
        this.txtCuongDo.Text,
        this.txtSTTPhieuTron.Text,
        "200",
        this.txtDoSut.Text,
        this.txtTaiXe.Text,
        ConfigManager.TramTronConfig.KLChoLonNhat.ToString() + "m\u00B3",
        this.txtTheTich.Text + "m\u00B3",
        this.txtLuyKe.Text,
        this.txtXe.Text,
        this.txtGioTron.Text,
        this.txtDiaDiem.Text,
        this.txtMaPhieuTron.Text,
        "1m\u00B3",
        this.txtHangMuc.Text,
        this.txtNiemChi.Text,
        this.txtNguoiTron.Text,
        this.txtGioKTTron.Text
      };
    }

    private void grvPhieuTron_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      this.DoFocusPhieuTron();
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      this.ClearDataPhieuTron();
      this.LoadPhieuTron();
    }

    private void btnLamMoi_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void btnPrint_Click(object sender, EventArgs e)
    {
      if (this.grvPhieuTron == null || this.grvPhieuTron.SelectedRowsCount == 0)
        return;
      this.btnPrint.Enabled = false;
      if (!ConfigManager.TramTronConfig.InPITuMau)
        return;
      this.PrintPTFromFile_NewTread();
    }

    private void PrintPTFromFile_NewTread()
    {
      this.thread = new Thread(new ThreadStart(this.PrintPTFromFile));
      this.thread.Start();
    }

    private void PrintPTFromFile()
    {
      this.GetParam();
      this.WriteDetailInvoice(this.lst);
      try
      {
        this.numberOfCopies = (int) this.spin_numberOfCopies.Value;
        if (this.filePathMau != string.Empty)
          this.fileName = Path.GetFileName(this.filePathMau);
        string path = Path.Combine(this.folderDesPhieuPath, this.fileName);
        string pdfFilePath = Path.ChangeExtension(path, ".pdf");
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
        // ISSUE: variable of a compiler-generated type
        Documents documents = instance.Documents;
        object obj1 = (object) path;
        ref object local1 = ref obj1;
        object missing1 = Type.Missing;
        ref object local2 = ref missing1;
        object missing2 = Type.Missing;
        ref object local3 = ref missing2;
        object missing3 = Type.Missing;
        ref object local4 = ref missing3;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: variable of a compiler-generated type
        Document o = documents.Add(ref local1, ref local2, ref local3, ref local4);
        // ISSUE: variable of a compiler-generated type
        Document activeDocument = instance.ActiveDocument;
        string OutputFileName = pdfFilePath;
        object missing4 = Type.Missing;
        ref object local5 = ref missing4;
        // ISSUE: reference to a compiler-generated method
        activeDocument.ExportAsFixedFormat(OutputFileName, WdExportFormat.wdExportFormatPDF, FixedFormatExtClassPtr: ref local5);
        object obj2 = (object) false;
        ref object local6 = ref obj2;
        object missing5 = Type.Missing;
        ref object local7 = ref missing5;
        object missing6 = Type.Missing;
        ref object local8 = ref missing6;
        // ISSUE: reference to a compiler-generated method
        o.Close(ref local6, ref local7, ref local8);
        Marshal.ReleaseComObject((object) o);
        if (File.Exists(path))
        {
          try
          {
            File.Delete(path);
            this.PrinterInvoke(pdfFilePath, this.numberOfCopies);
          }
          catch (System.Exception ex)
          {
            TramTronLogger.WriteError(ex);
          }
        }
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application application = instance;
        missing6 = Type.Missing;
        ref object local9 = ref missing6;
        missing5 = Type.Missing;
        ref object local10 = ref missing5;
        obj2 = Type.Missing;
        ref object local11 = ref obj2;
        // ISSUE: reference to a compiler-generated method
        application.Quit(ref local9, ref local10, ref local11);
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private async void PrintPDF(string pdfFilePath, int numberOfCopies)
    {
      try
      {
        for (int index = 0; index < numberOfCopies; ++index)
        {
          ProcessStartInfo processStartInfo = new ProcessStartInfo()
          {
            Verb = "printto",
            FileName = pdfFilePath,
            UseShellExecute = true,
            Arguments = "\"" + this.printerName + "\""
          };
          using (Process process = new Process()
          {
            StartInfo = processStartInfo
          })
            process.Start();
        }
      }
      catch (System.Exception ex)
      {
        Console.WriteLine("Lỗi khi in file PDF: " + ex.Message);
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowMessageDialog(ex.Message);
      }
    }

    private async Task PrintPDFAsync(string pdfFilePath, int numberOfCopies)
    {
      TaskCompletionSource<bool> completionSource = new TaskCompletionSource<bool>();
      try
      {
        for (int index = 0; index < numberOfCopies; ++index)
        {
          ProcessStartInfo processStartInfo = new ProcessStartInfo()
          {
            Verb = "printto",
            FileName = pdfFilePath,
            UseShellExecute = true,
            Arguments = "\"" + this.printerName + "\""
          };
          using (Process process = new Process()
          {
            StartInfo = processStartInfo
          })
          {
            process.Start();
            process.WaitForExit();
          }
        }
        completionSource.SetResult(true);
      }
      catch (System.Exception ex)
      {
        Console.WriteLine("Lỗi khi in file PDF: " + ex.Message);
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowMessageDialog(ex.Message);
        completionSource.SetException(ex);
      }
      int num = await completionSource.Task ? 1 : 0;
    }

    public bool PrinterInvoke(string pdfFilePath, int numberOfCopies)
    {
      try
      {
        Task[] taskArray = new Task[numberOfCopies];
        for (int index = 0; index < numberOfCopies; ++index)
          taskArray[index] = Task.Run((Action) (() => Support.PrintReport(pdfFilePath)));
        Task.WaitAll(taskArray);
        this.btnPrint.Enabled = true;
        return true;
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
      return false;
    }

    private void GetParam()
    {
      this.lst.Clear();
      this.lst.Add(ConfigManager.TramTronConfig.TenCty);
      this.lst.Add(this.datNgayTron.DateTime.ToString("dd-MM-yyyy"));
      this.lst.Add(this.txtTenCongTruong.Text);
      this.lst.Add(this.txtTenKhachHang.Text);
      this.lst.Add(this.txtTenMAC.Text);
      this.lst.Add(this.txtCuongDo.Text);
      this.lst.Add(this.txtSTTPhieuTron.Text);
      this.lst.Add("200");
      this.lst.Add(this.txtDoSut.Text);
      this.lst.Add(this.txtTaiXe.Text);
      this.lst.Add(ConfigManager.TramTronConfig.KLChoLonNhat.ToString() + "m\u00B3");
      this.lst.Add(this.txtTheTich.Text + "m\u00B3");
      this.lst.Add(this.txtLuyKe.Text);
      this.lst.Add(this.txtXe.Text);
      this.lst.Add(this.txtGioTron.Text);
      this.lst.Add(this.txtDiaDiem.Text);
      this.lst.Add(this.txtMaPhieuTron.Text);
      this.lst.Add("1m\u00B3");
      this.lst.Add(this.txtHangMuc.Text);
      this.lst.Add(this.txtNiemChi.Text);
      this.lst.Add(this.txtNguoiTron.Text);
      this.lst.Add(this.txtGioKTTron.Text);
    }

    private void WriteDetailInvoice(List<string> param)
    {
      try
      {
        if (!this.CopyTempFile() || this._error)
          return;
        if (this.filePathMau != string.Empty)
          this.fileName = Path.GetFileName(this.filePathMau);
        string str = Path.Combine(ConfigManager.TramTronConfig.ReportPath, this.fileName);
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
        // ISSUE: variable of a compiler-generated type
        Documents documents = instance.Documents;
        object obj1 = (object) str;
        ref object local1 = ref obj1;
        object missing1 = Type.Missing;
        ref object local2 = ref missing1;
        object missing2 = Type.Missing;
        ref object local3 = ref missing2;
        object missing3 = Type.Missing;
        ref object local4 = ref missing3;
        object missing4 = Type.Missing;
        ref object local5 = ref missing4;
        object missing5 = Type.Missing;
        ref object local6 = ref missing5;
        object missing6 = Type.Missing;
        ref object local7 = ref missing6;
        object missing7 = Type.Missing;
        ref object local8 = ref missing7;
        object missing8 = Type.Missing;
        ref object local9 = ref missing8;
        object missing9 = Type.Missing;
        ref object local10 = ref missing9;
        object missing10 = Type.Missing;
        ref object local11 = ref missing10;
        object missing11 = Type.Missing;
        ref object local12 = ref missing11;
        object missing12 = Type.Missing;
        ref object local13 = ref missing12;
        object missing13 = Type.Missing;
        ref object local14 = ref missing13;
        object obj2 = Type.Missing;
        ref object local15 = ref obj2;
        object obj3 = Type.Missing;
        ref object local16 = ref obj3;
        // ISSUE: reference to a compiler-generated method
        documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
        for (int index = 0; index < param.Count; ++index)
        {
          string searchText = "{" + index.ToString() + "}";
          this.ReplaceText(instance, searchText, param[index]);
        }
        // ISSUE: variable of a compiler-generated type
        Document activeDocument = instance.ActiveDocument;
        obj3 = (object) str;
        ref object local17 = ref obj3;
        obj2 = (object) 12;
        ref object local18 = ref obj2;
        missing13 = Type.Missing;
        ref object local19 = ref missing13;
        missing12 = Type.Missing;
        ref object local20 = ref missing12;
        missing11 = Type.Missing;
        ref object local21 = ref missing11;
        missing10 = Type.Missing;
        ref object local22 = ref missing10;
        missing9 = Type.Missing;
        ref object local23 = ref missing9;
        missing8 = Type.Missing;
        ref object local24 = ref missing8;
        missing7 = Type.Missing;
        ref object local25 = ref missing7;
        missing6 = Type.Missing;
        ref object local26 = ref missing6;
        missing5 = Type.Missing;
        ref object local27 = ref missing5;
        missing4 = Type.Missing;
        ref object local28 = ref missing4;
        object missing14 = Type.Missing;
        ref object local29 = ref missing14;
        object missing15 = Type.Missing;
        ref object local30 = ref missing15;
        object missing16 = Type.Missing;
        ref object local31 = ref missing16;
        object missing17 = Type.Missing;
        ref object local32 = ref missing17;
        // ISSUE: reference to a compiler-generated method
        activeDocument.SaveAs(ref local17, ref local18, ref local19, ref local20, ref local21, ref local22, ref local23, ref local24, ref local25, ref local26, ref local27, ref local28, ref local29, ref local30, ref local31, ref local32);
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application application = instance;
        missing17 = Type.Missing;
        ref object local33 = ref missing17;
        missing16 = Type.Missing;
        ref object local34 = ref missing16;
        missing15 = Type.Missing;
        ref object local35 = ref missing15;
        // ISSUE: reference to a compiler-generated method
        application.Quit(ref local33, ref local34, ref local35);
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private bool CopyTempFile()
    {
      string piPath1 = ConfigManager.TramTronConfig.PIPath;
      string path2 = "";
      string piPath2 = ConfigManager.TramTronConfig.PIPath;
      if (piPath2 != string.Empty)
        path2 = Path.GetFileName(piPath2);
      string str = Path.Combine(ConfigManager.TramTronConfig.ReportPath, path2);
      try
      {
        if (!File.Exists(str))
          File.Copy(piPath1, str, true);
        this._error = false;
      }
      catch (System.Exception ex)
      {
        this._error = true;
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
      return true;
    }

    private void ReplaceText(Microsoft.Office.Interop.Word.Application word, string searchText, string replacementText)
    {
      // ISSUE: variable of a compiler-generated type
      Find find = word.Selection.Find;
      // ISSUE: reference to a compiler-generated method
      find.ClearFormatting();
      find.Text = searchText;
      // ISSUE: variable of a compiler-generated type
      Replacement replacement = find.Replacement;
      // ISSUE: reference to a compiler-generated method
      replacement.ClearFormatting();
      replacement.Text = replacementText;
      object obj = (object) Missing.Value;
      object Replace = (object) WdReplace.wdReplaceAll;
      // ISSUE: reference to a compiler-generated method
      find.Execute(ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref Replace, ref obj, ref obj, ref obj, ref obj);
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      this.lst.Clear();
      this.lst.Add(ConfigManager.TramTronConfig.TenCty);
      this.lst.Add(this.datNgayTron.DateTime.ToString("dd-MM-yyyy"));
      this.lst.Add(this.txtTenCongTruong.Text);
      this.lst.Add(this.txtTenKhachHang.Text);
      this.lst.Add(this.txtTenMAC.Text);
      this.lst.Add(this.txtCuongDo.Text);
      this.lst.Add(this.txtSTTPhieuTron.Text);
      this.lst.Add("200");
      this.lst.Add(this.txtDoSut.Text);
      this.lst.Add(this.txtTaiXe.Text);
      this.lst.Add(ConfigManager.TramTronConfig.KLChoLonNhat.ToString() + "m\u00B3");
      this.lst.Add(this.txtTheTich.Text + "m\u00B3");
      this.lst.Add(this.txtLuyKe.Text);
      this.lst.Add(this.txtXe.Text);
      this.lst.Add(this.txtGioTron.Text);
      this.lst.Add(this.txtDiaDiem.Text);
      this.lst.Add(this.txtMaPhieuTron.Text);
      this.lst.Add("1m\u00B3");
      this.lst.Add(this.txtHangMuc.Text);
      this.lst.Add(this.txtNiemChi.Text);
      this.lst.Add(this.txtNguoiTron.Text);
      this.lst.Add(this.txtGioKTTron.Text);
    }

    private void spin_numberOfCopies_EditValueChanged(object sender, EventArgs e)
    {
      this.numberOfCopies = (int) this.spin_numberOfCopies.Value;
    }

    
  }
}
