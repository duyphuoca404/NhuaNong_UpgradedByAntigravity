// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Cell
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word
{
  [CompilerGenerated]
  [DefaultMember("Range")]
  [Guid("0002094E-0000-0000-C000-000000000046")]
  [TypeIdentifier]
  [ComImport]
  public interface Cell
  {
    [DispId(0)]
    Range Range { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap1_11();
    void _VtblGap1_11();
    [DispId(1104)]
    WdCellVerticalAlignment VerticalAlignment { [DispId(1104), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [DispId(1104), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap2_12();
    void _VtblGap2_12();
    [DispId(204)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Merge([MarshalAs(UnmanagedType.Interface), In] Cell MergeTo);

    [DispId(205)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Split([MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumRows, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NumColumns);
  }
}
