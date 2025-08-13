// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Workbooks
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel
{
  [CompilerGenerated]
  [Guid("000208DB-0000-0000-C000-000000000046")]
  [DefaultMember("_Default")]
  [TypeIdentifier]
  [ComImport]
  public interface Workbooks : IEnumerable
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap1_3();
    // Khai báo phương thức trừu tượng thay cho sealed extern
    void _VtblGap1_3();
    [DispId(181)]
    [LCIDConversion(1)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    Workbook Add([MarshalAs(UnmanagedType.Struct), In, Optional] object Template);
  }
}
