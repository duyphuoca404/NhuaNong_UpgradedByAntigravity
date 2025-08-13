// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.Support
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using NhuaNong.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Utils
{
  public class Support
  {
    public static string GetNextNiemChi(string inputString)
    {
      string nextNiemChi = "";
      string s = new string(inputString.SkipWhile<char>((Func<char, bool>) (c => c == '0')).ToArray<char>());
      int result;
      if (!int.TryParse(s, out result))
        return nextNiemChi;
      int num = result + 1;
      return new string('0', inputString.Length - s.Length) + num.ToString();
    }

    public static void GetListSiloLogic(
      BindingList<ObjSilo> _blstSiloLogic,
      BindingList<ObjSilo> _blstSiloLogic1,
      LookUpEdit lue1,
      LookUpEdit lue2)
    {
      _blstSiloLogic1.Clear();
      foreach (ObjSilo objSilo in (Collection<ObjSilo>) _blstSiloLogic)
      {
        if (objSilo.SiloID != (int) lue1.EditValue)
          _blstSiloLogic1.Add(objSilo);
      }
      lue2.Properties.DataSource = (object) _blstSiloLogic1;
    }

    public static void GetListSiloLogic(BindingList<ObjSilo> _blstSiloLogic, LookUpEdit lue1)
    {
      BindingList<ObjSilo> bindingList = new BindingList<ObjSilo>();
      foreach (ObjSilo objSilo in (Collection<ObjSilo>) _blstSiloLogic)
      {
        if (objSilo.SiloID != (int) lue1.EditValue)
          bindingList.Add(objSilo);
      }
      _blstSiloLogic.Clear();
      _blstSiloLogic = bindingList;
    }

    public static void UpdateListSiloLogic(BindingList<ObjSilo> _blstSiloLogic, string maSilo)
    {
      BindingList<ObjSilo> bindingList = new BindingList<ObjSilo>();
      foreach (ObjSilo objSilo in (Collection<ObjSilo>) _blstSiloLogic)
      {
        if (!(objSilo.MaSilo == maSilo))
          bindingList.Add(objSilo);
      }
      _blstSiloLogic.Clear();
      foreach (ObjSilo objSilo in (Collection<ObjSilo>) bindingList)
        _blstSiloLogic.Add(objSilo);
    }

    public static void SetValueSpinZero(SpinEdit spinEdit)
    {
      if (spinEdit == null || !(spinEdit.Value < 0M))
        return;
      spinEdit.Value = 0M;
    }

    public static void ResetValueLueLogic(LookUpEdit lue1, LookUpEdit lue2)
    {
      lue1.EditValue = (object) null;
      lue2.EditValue = (object) null;
    }

    public static double GetValueLogic(LookUpEdit lue1, LookUpEdit lue2, string nhomSilo)
    {
      double valueLogic = 0.0;
      string s = "";
      if (!Support.ValidateData(lue1, lue2))
        return valueLogic;
      switch (nhomSilo)
      {
        case "AG":
          int numLogicSiloAg = Support.GetNumLogicSiloAG(lue1);
          string str1 = numLogicSiloAg.ToString();
          numLogicSiloAg = Support.GetNumLogicSiloAG(lue2);
          string str2 = numLogicSiloAg.ToString();
          s = str1 + str2;
          break;
        case "CE":
          int numLogicSiloCe = Support.GetNumLogicSiloCE(lue1);
          string str3 = numLogicSiloCe.ToString();
          numLogicSiloCe = Support.GetNumLogicSiloCE(lue2);
          string str4 = numLogicSiloCe.ToString();
          s = str3 + str4;
          break;
        case "AD":
          int numLogicSiloAd = Support.GetNumLogicSiloAD(lue1);
          string str5 = numLogicSiloAd.ToString();
          numLogicSiloAd = Support.GetNumLogicSiloAD(lue2);
          string str6 = numLogicSiloAd.ToString();
          s = str5 + str6;
          break;
      }
      return double.Parse(s);
    }

    private static bool ValidateData(LookUpEdit lue1, LookUpEdit lue2)
    {
      bool flag = true;
      if (lue1.EditValue == null)
      {
        lue1.ErrorText = "Silo is requied";
        flag = false;
      }
      if (lue2.EditValue == null)
      {
        lue2.ErrorText = "Silo is requied";
        flag = false;
      }
      return flag;
    }

    private static int GetNumLogicSiloAG(LookUpEdit lueSiloLogic)
    {
      int numLogicSiloAg = 0;
      switch (lueSiloLogic.GetColumnValue("MaSilo").ToString())
      {
        case "Agg1":
          numLogicSiloAg = 1;
          break;
        case "Agg2":
          numLogicSiloAg = 2;
          break;
        case "Agg3":
          numLogicSiloAg = 3;
          break;
        case "Agg4":
          numLogicSiloAg = 4;
          break;
        case "Agg5":
          numLogicSiloAg = 5;
          break;
        case "Agg6":
          numLogicSiloAg = 6;
          break;
      }
      return numLogicSiloAg;
    }

    private static int GetNumLogicSiloCE(LookUpEdit lueSiloLogic)
    {
      int numLogicSiloCe = 0;
      switch (lueSiloLogic.GetColumnValue("MaSilo").ToString())
      {
        case "Ce1":
          numLogicSiloCe = 1;
          break;
        case "Ce2":
          numLogicSiloCe = 2;
          break;
        case "Ce3":
          numLogicSiloCe = 3;
          break;
        case "Ce4":
          numLogicSiloCe = 4;
          break;
        case "Ce5":
          numLogicSiloCe = 5;
          break;
      }
      return numLogicSiloCe;
    }

    private static int GetNumLogicSiloAD(LookUpEdit lueSiloLogic)
    {
      int numLogicSiloAd = 0;
      switch (lueSiloLogic.GetColumnValue("MaSilo").ToString())
      {
        case "Add1":
          numLogicSiloAd = 1;
          break;
        case "Add2":
          numLogicSiloAd = 2;
          break;
        case "Add3":
          numLogicSiloAd = 3;
          break;
        case "Add4":
          numLogicSiloAd = 4;
          break;
        case "Add5":
          numLogicSiloAd = 5;
          break;
        case "Add6":
          numLogicSiloAd = 6;
          break;
      }
      return numLogicSiloAd;
    }

    public static double SetUpLogic(LookUpEdit lue1, LookUpEdit lue2, string nhomSilo)
    {
      return lue1.Text == string.Empty || lue2.Text == string.Empty || TramTromMessageBox.ShowYesNoDialog(string.Format("Xác nhận thực hiện thiết lập {0} - LOGIC - {1} ?", (object) lue1.Text.ToString(), (object) lue2.Text.ToString())) == DialogResult.Yes ? Support.GetValueLogic(lue1, lue2, nhomSilo) : 0.0;
    }

    public static bool CheckSiloLogic(BindingList<ObjSilo> bllst, string maSilo)
    {
      bool flag = true;
      foreach (ObjSilo objSilo in (Collection<ObjSilo>) bllst)
      {
        if (objSilo.MaSilo != maSilo)
          flag = false;
      }
      return flag;
    }

    public static string SecondToHour(int sec)
    {
      return "PHẦN MỀM SẼ TỰ ĐỘNG CẬP NHẬT SAU: " + string.Format("{0} Giờ, {1} Phút, {2} Giây", (object) (sec / 3600), (object) (sec % 3600 / 60), (object) (sec % 60));
    }

    public static void PrintReport(string path)
    {
      try
      {
        Process.Start(new ProcessStartInfo()
        {
          Verb = "print",
          FileName = path,
          CreateNoWindow = true,
          WindowStyle = ProcessWindowStyle.Hidden
        });
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    public static void PrintReportNEW(string path)
    {
      try
      {
        string lower = Path.GetExtension(path).ToLower();
        if (lower != ".pdf" && lower != ".doc" && lower != ".docx")
          TramTromMessageBox.ShowErrorDialog("Unsupported file format.");
        else if (lower == ".pdf")
        {
          string pdfReaderPath = ConfigManager.TramTronConfig.PdfReaderPath;
          if (!File.Exists(pdfReaderPath))
          {
            TramTromMessageBox.ShowErrorDialog("Foxit Reader not found.");
          }
          else
          {
            ProcessStartInfo processStartInfo = new ProcessStartInfo()
            {
              FileName = pdfReaderPath,
              Arguments = "/t \"" + path + "\"",
              CreateNoWindow = true,
              WindowStyle = ProcessWindowStyle.Hidden
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
        }
        else
        {
          ProcessStartInfo processStartInfo = new ProcessStartInfo()
          {
            FileName = path,
            Verb = "print",
            CreateNoWindow = true,
            WindowStyle = ProcessWindowStyle.Hidden
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
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    public static void PrintReportPDF(string path)
    {
      try
      {
        string pdfReaderPath = ConfigManager.TramTronConfig.PdfReaderPath;
        if (!File.Exists(pdfReaderPath))
        {
          TramTromMessageBox.ShowErrorDialog("Foxit Reader not found.");
        }
        else
        {
          ProcessStartInfo processStartInfo = new ProcessStartInfo()
          {
            FileName = pdfReaderPath,
            Arguments = "/t \"" + path + "\"",
            CreateNoWindow = true,
            WindowStyle = ProcessWindowStyle.Hidden
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
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    public static void PrintReportWord(string path)
    {
      try
      {
        if (!File.Exists(path))
        {
          TramTromMessageBox.ShowErrorDialog("Word file not found.");
        }
        else
        {
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
          object missing14 = Type.Missing;
          ref object local15 = ref missing14;
          object missing15 = Type.Missing;
          ref object local16 = ref missing15;
          // ISSUE: reference to a compiler-generated method
          // ISSUE: variable of a compiler-generated type
          Document o = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
          // ISSUE: variable of a compiler-generated type
          Document document1 = o;
          missing15 = Type.Missing;
          ref object local17 = ref missing15;
          object missing16 = Type.Missing;
          ref object local18 = ref missing16;
          object missing17 = Type.Missing;
          ref object local19 = ref missing17;
          object missing18 = Type.Missing;
          ref object local20 = ref missing18;
          object missing19 = Type.Missing;
          ref object local21 = ref missing19;
          object missing20 = Type.Missing;
          ref object local22 = ref missing20;
          object missing21 = Type.Missing;
          ref object local23 = ref missing21;
          object missing22 = Type.Missing;
          ref object local24 = ref missing22;
          object missing23 = Type.Missing;
          ref object local25 = ref missing23;
          object missing24 = Type.Missing;
          ref object local26 = ref missing24;
          object missing25 = Type.Missing;
          ref object local27 = ref missing25;
          object missing26 = Type.Missing;
          ref object local28 = ref missing26;
          object missing27 = Type.Missing;
          ref object local29 = ref missing27;
          object missing28 = Type.Missing;
          ref object local30 = ref missing28;
          object missing29 = Type.Missing;
          ref object local31 = ref missing29;
          obj1 = Type.Missing;
          ref object local32 = ref obj1;
          object missing30 = Type.Missing;
          ref object local33 = ref missing30;
          object obj2 = Type.Missing;
          ref object local34 = ref obj2;
          // ISSUE: reference to a compiler-generated method
          document1.PrintOut(ref local17, ref local18, ref local19, ref local20, ref local21, ref local22, ref local23, ref local24, ref local25, ref local26, ref local27, ref local28, ref local29, ref local30, ref local31, ref local32, ref local33, ref local34);
          // ISSUE: variable of a compiler-generated type
          Document document2 = o;
          obj2 = (object) false;
          ref object local35 = ref obj2;
          object missing31 = Type.Missing;
          ref object local36 = ref missing31;
          obj1 = Type.Missing;
          ref object local37 = ref obj1;
          // ISSUE: reference to a compiler-generated method
          document2.Close(ref local35, ref local36, ref local37);
          obj1 = Type.Missing;
          ref object local38 = ref obj1;
          object missing32 = Type.Missing;
          ref object local39 = ref missing32;
          object missing33 = Type.Missing;
          ref object local40 = ref missing33;
          // ISSUE: reference to a compiler-generated method
          instance.Quit(ref local38, ref local39, ref local40);
          Marshal.ReleaseComObject((object) o);
          Marshal.ReleaseComObject((object) instance);
        }
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    public static void CloseWordApplications()
    {
      string[] strArray = new string[4]
      {
        "winword",
        "acrobat",
        "FoxitReader",
        "FoxitPhantomPDF"
      };
      foreach (Process process in Process.GetProcesses())
      {
        try
        {
          foreach (string str in strArray)
          {
            if (process.ProcessName.ToLower().Contains(str))
            {
              process.Kill();
              Console.WriteLine("Đã đóng ứng dụng " + str + ".");
            }
          }
        }
        catch (System.Exception ex)
        {
          Console.WriteLine("Lỗi: " + ex.Message);
        }
      }
      Process[] processesByName = Process.GetProcessesByName("FoxitPDFReader");
      if (processesByName.Length == 0)
        return;
      processesByName[0].Kill();
    }

    public static string[] ReadWordFile(string filePath)
    {
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Word.Application instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
      // ISSUE: variable of a compiler-generated type
      Documents documents = instance.Documents;
      object obj = (object) filePath;
      ref object local1 = ref obj;
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
      object missing14 = Type.Missing;
      ref object local15 = ref missing14;
      object missing15 = Type.Missing;
      ref object local16 = ref missing15;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Document document = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
      string text = document.Content.Text;
      object missing16 = Type.Missing;
      ref object local17 = ref missing16;
      object missing17 = Type.Missing;
      ref object local18 = ref missing17;
      object missing18 = Type.Missing;
      ref object local19 = ref missing18;
      // ISSUE: reference to a compiler-generated method
      document.Close(ref local17, ref local18, ref local19);
      object missing19 = Type.Missing;
      ref object local20 = ref missing19;
      object missing20 = Type.Missing;
      ref object local21 = ref missing20;
      object missing21 = Type.Missing;
      ref object local22 = ref missing21;
      // ISSUE: reference to a compiler-generated method
      instance.Quit(ref local20, ref local21, ref local22);
      return text.Split(new string[1]{ Environment.NewLine }, StringSplitOptions.None);
    }

    public static void WriteToExcel(string filePath, string[] lines)
    {
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Excel.Application instance = (Microsoft.Office.Interop.Excel.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Workbook o1 = instance.Workbooks.Add(Type.Missing);
      // ISSUE: reference to a compiler-generated field
      if (Support.\u003C\u003Eo__20.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Support.\u003C\u003Eo__20.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, Worksheet>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Worksheet), typeof (Support)));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: variable of a compiler-generated type
      Worksheet o2 = Support.\u003C\u003Eo__20.\u003C\u003Ep__0.Target((CallSite) Support.\u003C\u003Eo__20.\u003C\u003Ep__0, o1.Worksheets[(object) 1]);
      for (int index = 0; index < lines.Length; ++index)
      {
        // ISSUE: reference to a compiler-generated field
        if (Support.\u003C\u003Eo__20.\u003C\u003Ep__1 == null)
        {
          // ISSUE: reference to a compiler-generated field
          Support.\u003C\u003Eo__20.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Value", typeof (Support), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj = Support.\u003C\u003Eo__20.\u003C\u003Ep__1.Target((CallSite) Support.\u003C\u003Eo__20.\u003C\u003Ep__1, o2.Cells[(object) (index + 1), (object) 1], lines[index]);
      }
      // ISSUE: reference to a compiler-generated method
      o1.SaveAs((object) filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, ConflictResolution: Type.Missing, AddToMru: Type.Missing, TextCodepage: Type.Missing, TextVisualLayout: Type.Missing, Local: Type.Missing);
      // ISSUE: reference to a compiler-generated method
      o1.Close(Type.Missing, Type.Missing, Type.Missing);
      // ISSUE: reference to a compiler-generated method
      instance.Quit();
      Marshal.ReleaseComObject((object) o2);
      Marshal.ReleaseComObject((object) o1);
      Marshal.ReleaseComObject((object) instance);
    }

    public static void ReadTableFromWordAndWriteToExcel(string wordFile, string excelFile)
    {
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Word.Application instance1 = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
      // ISSUE: variable of a compiler-generated type
      Documents documents = instance1.Documents;
      object obj1 = (object) wordFile;
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
      object missing14 = Type.Missing;
      ref object local15 = ref missing14;
      object missing15 = Type.Missing;
      ref object local16 = ref missing15;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Document document = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
      string text = document.Content.Text;
      object missing16 = Type.Missing;
      ref object local17 = ref missing16;
      object missing17 = Type.Missing;
      ref object local18 = ref missing17;
      object missing18 = Type.Missing;
      ref object local19 = ref missing18;
      // ISSUE: reference to a compiler-generated method
      document.Close(ref local17, ref local18, ref local19);
      object missing19 = Type.Missing;
      ref object local20 = ref missing19;
      object missing20 = Type.Missing;
      ref object local21 = ref missing20;
      object missing21 = Type.Missing;
      ref object local22 = ref missing21;
      // ISSUE: reference to a compiler-generated method
      instance1.Quit(ref local20, ref local21, ref local22);
      string[] strArray1 = text.Split(new string[1]
      {
        Environment.NewLine
      }, StringSplitOptions.None);
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Excel.Application instance2 = (Microsoft.Office.Interop.Excel.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Workbook o1 = instance2.Workbooks.Add(Type.Missing);
      // ISSUE: reference to a compiler-generated field
      if (Support.\u003C\u003Eo__21.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Support.\u003C\u003Eo__21.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, Worksheet>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Worksheet), typeof (Support)));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: variable of a compiler-generated type
      Worksheet o2 = Support.\u003C\u003Eo__21.\u003C\u003Ep__0.Target((CallSite) Support.\u003C\u003Eo__21.\u003C\u003Ep__0, o1.Worksheets[(object) 1]);
      for (int index1 = 0; index1 < strArray1.Length; ++index1)
      {
        string[] strArray2 = strArray1[index1].Split(new char[2]
        {
          '\t',
          ','
        }, StringSplitOptions.None);
        for (int index2 = 0; index2 < strArray2.Length; ++index2)
        {
          // ISSUE: reference to a compiler-generated field
          if (Support.\u003C\u003Eo__21.\u003C\u003Ep__1 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Support.\u003C\u003Eo__21.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Value", typeof (Support), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj2 = Support.\u003C\u003Eo__21.\u003C\u003Ep__1.Target((CallSite) Support.\u003C\u003Eo__21.\u003C\u003Ep__1, o2.Cells[(object) (index1 + 1), (object) (index2 + 1)], strArray2[index2].Trim());
        }
      }
      // ISSUE: reference to a compiler-generated method
      o1.SaveAs((object) excelFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, ConflictResolution: Type.Missing, AddToMru: Type.Missing, TextCodepage: Type.Missing, TextVisualLayout: Type.Missing, Local: Type.Missing);
      // ISSUE: reference to a compiler-generated method
      o1.Close(Type.Missing, Type.Missing, Type.Missing);
      // ISSUE: reference to a compiler-generated method
      instance2.Quit();
      Marshal.ReleaseComObject((object) o2);
      Marshal.ReleaseComObject((object) o1);
      Marshal.ReleaseComObject((object) instance2);
    }

    public static void ReadTextFromWordAndWriteToExcel(string wordFile, string excelFile)
    {
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Word.Application instance1 = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
      // ISSUE: variable of a compiler-generated type
      Documents documents = instance1.Documents;
      object obj1 = (object) wordFile;
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
      object missing14 = Type.Missing;
      ref object local15 = ref missing14;
      object missing15 = Type.Missing;
      ref object local16 = ref missing15;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Document document = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
      string text = document.Content.Text;
      object missing16 = Type.Missing;
      ref object local17 = ref missing16;
      object missing17 = Type.Missing;
      ref object local18 = ref missing17;
      object missing18 = Type.Missing;
      ref object local19 = ref missing18;
      // ISSUE: reference to a compiler-generated method
      document.Close(ref local17, ref local18, ref local19);
      object missing19 = Type.Missing;
      ref object local20 = ref missing19;
      object missing20 = Type.Missing;
      ref object local21 = ref missing20;
      object missing21 = Type.Missing;
      ref object local22 = ref missing21;
      // ISSUE: reference to a compiler-generated method
      instance1.Quit(ref local20, ref local21, ref local22);
      string[] strArray = text.Split(new string[1]
      {
        Environment.NewLine
      }, StringSplitOptions.None);
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Excel.Application instance2 = (Microsoft.Office.Interop.Excel.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Workbook o1 = instance2.Workbooks.Add(Type.Missing);
      // ISSUE: reference to a compiler-generated field
      if (Support.\u003C\u003Eo__22.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Support.\u003C\u003Eo__22.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, Worksheet>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Worksheet), typeof (Support)));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: variable of a compiler-generated type
      Worksheet o2 = Support.\u003C\u003Eo__22.\u003C\u003Ep__0.Target((CallSite) Support.\u003C\u003Eo__22.\u003C\u003Ep__0, o1.Worksheets[(object) 1]);
      for (int index = 0; index < strArray.Length; ++index)
      {
        // ISSUE: reference to a compiler-generated field
        if (Support.\u003C\u003Eo__22.\u003C\u003Ep__1 == null)
        {
          // ISSUE: reference to a compiler-generated field
          Support.\u003C\u003Eo__22.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Value", typeof (Support), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj2 = Support.\u003C\u003Eo__22.\u003C\u003Ep__1.Target((CallSite) Support.\u003C\u003Eo__22.\u003C\u003Ep__1, o2.Cells[(object) (index + 1), (object) 1], strArray[index]);
      }
      // ISSUE: reference to a compiler-generated method
      o1.SaveAs((object) excelFile, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, ConflictResolution: Type.Missing, AddToMru: Type.Missing, TextCodepage: Type.Missing, TextVisualLayout: Type.Missing, Local: Type.Missing);
      // ISSUE: reference to a compiler-generated method
      o1.Close(Type.Missing, Type.Missing, Type.Missing);
      // ISSUE: reference to a compiler-generated method
      instance2.Quit();
      Marshal.ReleaseComObject((object) o2);
      Marshal.ReleaseComObject((object) o1);
      Marshal.ReleaseComObject((object) instance2);
    }

    public static double GenerateFakeValue(
      Decimal realValue,
      Decimal lowerError,
      Decimal upperError)
    {
      Decimal num1 = realValue * 0.005M;
      Decimal num2 = lowerError + num1;
      Decimal num3 = upperError - num1;
      Random random = new Random();
      double num4 = random.Next(2) != 0 ? (double) num3 - random.NextDouble() * (double) (num3 - num2) * 0.1 : (double) num2 + random.NextDouble() * (double) (num3 - num2) * 0.1;
      return random.Next(2) != 0 ? (double) realValue - num4 : (double) realValue + num4;
    }

    public static double GenerateFakeValueADD(Decimal realValue)
    {
      Random random = new Random();
      double num = random.NextDouble();
      return random.Next(2) != 0 ? (double) realValue - num : (double) realValue + num;
    }
  }
}
