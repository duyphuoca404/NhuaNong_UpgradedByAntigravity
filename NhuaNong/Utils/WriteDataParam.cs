// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.WriteDataParam
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace NhuaNong.Utils
{
  public class WriteDataParam
  {
    private string folderPhieuThuc;

    public bool WriteDataPT(string[] param)
    {
      try
      {
        string str1 = "MAUTPCP.docx";
        if (!this.CopyTempFile(str1))
          return false;
        // ISSUE: variable of a compiler-generated type
        Application instance = (Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
        try
        {
          string str2 = Path.Combine(this.folderPhieuThuc, str1);
          // ISSUE: variable of a compiler-generated type
          Documents documents = instance.Documents;
          object obj1 = (object) str2;
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
          // ISSUE: variable of a compiler-generated type
          Document document1 = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
          for (int index = 0; index < param.Length; ++index)
          {
            string placeholder = "{" + index.ToString() + "}";
            this.FillParam(instance, placeholder, param[index]);
          }
          string str3 = Path.Combine(this.folderPhieuThuc, "MAUTPCP.pdf");
          // ISSUE: variable of a compiler-generated type
          Document document2 = document1;
          obj3 = (object) str3;
          ref object local17 = ref obj3;
          obj2 = (object) WdSaveFormat.wdFormatPDF;
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
          object missing18 = Type.Missing;
          ref object local33 = ref missing18;
          // ISSUE: reference to a compiler-generated method
          document2.SaveAs2(ref local17, ref local18, ref local19, ref local20, ref local21, ref local22, ref local23, ref local24, ref local25, ref local26, ref local27, ref local28, ref local29, ref local30, ref local31, ref local32, ref local33);
          // ISSUE: variable of a compiler-generated type
          Document document3 = document1;
          missing18 = Type.Missing;
          ref object local34 = ref missing18;
          missing17 = Type.Missing;
          ref object local35 = ref missing17;
          missing16 = Type.Missing;
          ref object local36 = ref missing16;
          // ISSUE: reference to a compiler-generated method
          document3.Close(ref local34, ref local35, ref local36);
        }
        finally
        {
          // ISSUE: variable of a compiler-generated type
          Application application = instance;
          object missing19 = Type.Missing;
          ref object local37 = ref missing19;
          object missing20 = Type.Missing;
          ref object local38 = ref missing20;
          object missing21 = Type.Missing;
          ref object local39 = ref missing21;
          // ISSUE: reference to a compiler-generated method
          application.Quit(ref local37, ref local38, ref local39);
          Marshal.ReleaseComObject((object) instance);
        }
        File.Delete(Path.Combine(this.folderPhieuThuc, str1));
        return true;
      }
      catch (COMException ex)
      {
      }
      catch (System.Exception ex)
      {
      }
      return false;
    }

    private void FillParam(Application wordApp, string placeholder, string replacement)
    {
      // ISSUE: variable of a compiler-generated type
      Find find = wordApp.Selection.Find;
      // ISSUE: reference to a compiler-generated method
      find.ClearFormatting();
      find.Text = placeholder;
      // ISSUE: reference to a compiler-generated method
      find.Replacement.ClearFormatting();
      find.Replacement.Text = replacement;
      object obj = (object) Missing.Value;
      object Replace = (object) WdReplace.wdReplaceAll;
      // ISSUE: reference to a compiler-generated method
      find.Execute(ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref Replace, ref obj, ref obj, ref obj, ref obj);
    }

    private bool CopyTempFile(string fileName)
    {
      try
      {
        string path1 = Path.Combine(Directory.GetCurrentDirectory(), "MAUPHIEU");
        string str1 = Path.Combine(Directory.GetCurrentDirectory(), "PHIEUTHUC");
        string path2 = fileName;
        string sourceFileName = Path.Combine(path1, path2);
        string str2 = Path.Combine(str1, fileName);
        if (!Directory.Exists(str1))
          Directory.CreateDirectory(str1);
        string destFileName = str2;
        File.Copy(sourceFileName, destFileName, true);
        return true;
      }
      catch (DirectoryNotFoundException ex)
      {
        return false;
      }
      catch (IOException ex)
      {
        return false;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }
  }
}
