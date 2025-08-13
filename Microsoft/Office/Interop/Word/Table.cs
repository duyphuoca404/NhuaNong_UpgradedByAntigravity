// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Table
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
  [Guid("00020951-0000-0000-C000-000000000046")]
  [DefaultMember("Range")]
  [TypeIdentifier]
  [ComImport]
  public interface Table
  {
    [DispId(0)]
    Range Range { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
   // sealed extern void _VtblGap1_4();
        void _VtblGap1_4();
        [DispId(101)]
    Rows Rows { [DispId(101), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap2_13();
        void _VtblGap2_13();
        [DispId(17)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    Microsoft.Office.Interop.Word.Cell Cell([In] int Row, [In] int Column);

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap3_2();
        void _VtblGap3_2();

        [DispId(20)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AutoFitBehavior([In] WdAutoFitBehavior Behavior);

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap4_26();
        void _VtblGap4_26();
        [DispId(201)]
    [SpecialName]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void set_Style([MarshalAs(UnmanagedType.Struct), In] ref object prop);
  }
}
