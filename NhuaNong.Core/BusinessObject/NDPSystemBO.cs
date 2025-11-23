// Decompiled with JetBrains decompiler
// Type: NhuaNong.BusinessObject.NDPSystemBO
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using Unity;
using NhuaNong.Core;
using NhuaNong.DAL;
using NhuaNong.EntityModel;

#nullable disable
namespace NhuaNong.BusinessObject
{
  public class NDPSystemBO
  {
    public string GetNextCode(string strTblName)
    {
      ISysCodeGenRepository codeGenRepository = IoC.Current.Container.Resolve<ISysCodeGenRepository>();
      SysCodeGen codeGenByTblName = codeGenRepository.GetSysCodeGen_ByTblName(strTblName);
      string nextCode = this.BuildCode(codeGenByTblName.Prefix, new int?(codeGenByTblName.Length), new int?(codeGenByTblName.CurrentNumber));
      if (nextCode == string.Empty)
        return "Error Code";
      ++codeGenByTblName.CurrentNumber;
      codeGenRepository.Update(codeGenByTblName);
      codeGenRepository.Save();
      return nextCode;
    }

    private string BuildCode(string prefix, int? length, int? number)
    {
      string str = number.ToString();
      int length1 = str.Length;
      int? nullable1 = length;
      int valueOrDefault1 = nullable1.GetValueOrDefault();
      if (length1 > valueOrDefault1 & nullable1.HasValue)
        return string.Empty;
      while (true)
      {
        int length2 = str.Length;
        int? nullable2 = length;
        int valueOrDefault2 = nullable2.GetValueOrDefault();
        if (length2 < valueOrDefault2 & nullable2.HasValue)
          str = "0" + str;
        else
          break;
      }
      return string.Format("{0}{1}", (object) prefix, (object) str);
    }
  }
}
