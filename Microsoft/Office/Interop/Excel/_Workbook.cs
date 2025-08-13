// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Excel._Workbook
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Excel
{
  [CompilerGenerated]
  [Guid("000208DA-0000-0000-C000-000000000046")]
  [TypeIdentifier]
  [ComImport]
  public interface _Workbook
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap1_20();
    void _VtblGap1_20();

    [LCIDConversion(3)]
    [DispId(277)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Close([MarshalAs(UnmanagedType.Struct), In, Optional] object SaveChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename, [MarshalAs(UnmanagedType.Struct), In, Optional] object RouteWorkbook);

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap2_103();
    void _VtblGap2_103();

    [DispId(494)]
    Sheets Worksheets { [DispId(494), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap3_40();
    void _VtblGap3_40();

    [DispId(1925)]
    [LCIDConversion(12)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        //void SaveAs(
        //  [MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
        //  [MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat,
        //  [MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
        //  [MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
        //  [MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
        //  [MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
        //  [In] XlSaveAsAccessMode AccessMode = XlSaveAsAccessMode.xlNoChange,
        //  [MarshalAs(UnmanagedType.Struct), In, Optional] object ConflictResolution,
        //  [MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru,
        //  [MarshalAs(UnmanagedType.Struct), In, Optional] object TextCodepage,
        //  [MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout,
        //  [MarshalAs(UnmanagedType.Struct), In, Optional] object Local);

        //void SaveAs(
        //[MarshalAs(UnmanagedType.Struct), In, Optional] object Filename,
        //[MarshalAs(UnmanagedType.Struct), In, Optional] object FileFormat,
        //[MarshalAs(UnmanagedType.Struct), In, Optional] object Password,
        //[MarshalAs(UnmanagedType.Struct), In, Optional] object WriteResPassword,
        //[MarshalAs(UnmanagedType.Struct), In, Optional] object ReadOnlyRecommended,
        //[MarshalAs(UnmanagedType.Struct), In, Optional] object CreateBackup,
        //[MarshalAs(UnmanagedType.Struct), In, Optional] object ConflictResolution,
        //[MarshalAs(UnmanagedType.Struct), In, Optional] object AddToMru,
        //[MarshalAs(UnmanagedType.Struct), In, Optional] object TextCodepage,
        //[MarshalAs(UnmanagedType.Struct), In, Optional] object TextVisualLayout,
        //[MarshalAs(UnmanagedType.Struct), In, Optional] object Local,
        //[In, Optional] XlSaveAsAccessMode AccessMode); // Chuyển ra cuối và thêm [Optional], xóa phần gán giá trị mặc định đi và giữ lại thuộc tính [Optional]
        // ---- DÁN ĐOẠN CODE ĐÚNG NÀY VÀO ----
        void SaveAs(
        [In, Optional, MarshalAs(UnmanagedType.Struct)] object Filename,
        [In, Optional, MarshalAs(UnmanagedType.Struct)] object FileFormat,
        [In, Optional, MarshalAs(UnmanagedType.Struct)] object Password,
        [In, Optional, MarshalAs(UnmanagedType.Struct)] object WriteResPassword,
        [In, Optional, MarshalAs(UnmanagedType.Struct)] object ReadOnlyRecommended,
        [In, Optional, MarshalAs(UnmanagedType.Struct)] object CreateBackup,
        [In, Optional] XlSaveAsAccessMode AccessMode, // <-- Vị trí đúng là thứ 7
        [In, Optional, MarshalAs(UnmanagedType.Struct)] object ConflictResolution,
        [In, Optional, MarshalAs(UnmanagedType.Struct)] object AddToMru,
        [In, Optional, MarshalAs(UnmanagedType.Struct)] object TextCodepage,
        [In, Optional, MarshalAs(UnmanagedType.Struct)] object TextVisualLayout,
        [In, Optional, MarshalAs(UnmanagedType.Struct)] object Local);
    }
}
