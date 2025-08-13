// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel.Range
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel
{
  [CompilerGenerated]
  [InterfaceType(2)]
  [Guid("00020846-0000-0000-C000-000000000046")]
  [TypeIdentifier]
  // Thay thế phương thức sealed extern bằng khai báo phương thức trừu tượng trong interface
  [ComImport]
  public interface Range : IEnumerable
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    // sealed extern void _VtblGap1_45();
    // Khai báo phương thức trừu tượng thay cho sealed extern
    void _VtblGap1_45();
    [DispId(0)]
    [IndexerName("_Default")]
    object this[[MarshalAs(UnmanagedType.Struct), In, Optional] object RowIndex, [MarshalAs(UnmanagedType.Struct), In, Optional] object ColumnIndex] { [DispId(0), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Struct)] get; [DispId(0), MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.Struct), In, Optional] set; }
  }
}
