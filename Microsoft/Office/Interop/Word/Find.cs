// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Find
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word
{
  [CompilerGenerated]
  [Guid("000209B0-0000-0000-C000-000000000046")]
  [TypeIdentifier]
  [ComImport]
  public interface Find
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap1_26();
        void _VtblGap1_26();
        [DispId(22)]
    string Text { [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(22), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.BStr), In] set; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap2_4();
        void _VtblGap2_4();
        [DispId(25)]
    Replacement Replacement { [DispId(25), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap3_12();
        void _VtblGap3_12();
        [DispId(31)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearFormatting();

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap4_2();
        void _VtblGap4_2();
        [DispId(444)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    bool Execute(
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object FindText,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchCase,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchWholeWord,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchWildcards,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchSoundsLike,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchAllWordForms,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Forward,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Wrap,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReplaceWith,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Replace,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchKashida,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchDiacritics,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchAlefHamza,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object MatchControl);
  }
}
