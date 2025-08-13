// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word._Document
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
  [DefaultMember("Name")]
  [Guid("0002096B-0000-0000-C000-000000000046")]
  [TypeIdentifier]
  [ComImport]
  public interface _Document
  {
    [DispId(0)]
    string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap1_7();
        void _VtblGap1_7();
        [DispId(6)]
    Tables Tables { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap2_40();
        void _VtblGap2_40();
        [DispId(41)]
    Range Content { [DispId(41), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap3_110();
        void _VtblGap3_110();
        [DispId(1105)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Close([MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OriginalFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RouteDocument);

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap4_84();
        void _VtblGap4_84();

        [DispId(446)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void PrintOut(
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Background,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Append,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Range,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OutputFileName,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object From,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object To,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Item,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Copies,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Pages,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PageType,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintToFile,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Collate,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ActivePrinterMacGX,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ManualDuplexPrint,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomColumn,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomRow,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperWidth,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PrintZoomPaperHeight);

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
   // sealed extern void _VtblGap5_44();
        void _VtblGap5_44();
        [DispId(376)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SaveAs(
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileName,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileFormat,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LockComments,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePassword,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnlyRecommended,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EmbedTrueTypeFonts,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveNativePictureFormat,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveFormsData,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveAsAOCELetter,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Encoding,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertLineBreaks,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AllowSubstitutions,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LineEnding,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddBiDiMarks);

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap6_119();
        void _VtblGap6_119();
        [DispId(552)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void ExportAsFixedFormat(
        [MarshalAs(UnmanagedType.BStr), In] string OutputFileName,
        [In] WdExportFormat ExportFormat,
        [In, Optional] bool OpenAfterExport,
        [In, Optional] WdExportOptimizeFor OptimizeFor,
        [In, Optional] WdExportRange Range,
        [In, Optional] int From,
        [In, Optional] int To,
        [In, Optional] WdExportItem Item,
        [In, Optional] bool IncludeDocProps,
        [In, Optional] bool KeepIRM,
        [In, Optional] WdExportCreateBookmarks CreateBookmarks,
        [In, Optional] bool DocStructureTags,
        [In, Optional] bool BitmapMissingFonts,
        [In, Optional] bool UseISO19005_1,
        [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FixedFormatExtClassPtr);


        [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap7_16();
        void _VtblGap7_16();
        [DispId(568)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SaveAs2(
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileName,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FileFormat,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LockComments,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Password,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePassword,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnlyRecommended,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object EmbedTrueTypeFonts,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveNativePictureFormat,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveFormsData,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveAsAOCELetter,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Encoding,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object InsertLineBreaks,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AllowSubstitutions,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object LineEnding,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddBiDiMarks,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object CompatibilityMode);
  }
}
