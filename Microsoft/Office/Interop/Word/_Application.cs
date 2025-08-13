// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word._Application
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
  [Guid("00020970-0000-0000-C000-000000000046")]
  [TypeIdentifier]
  [ComImport]
  public interface _Application
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap1_3();
        void _VtblGap1_3();
        [DispId(0)]
    string Name { [DispId(0), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.BStr)] get; }

    [DispId(6)]
    Documents Documents { [DispId(6), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap2_1();
        void _VtblGap2_1();
        [DispId(3)]
    Document ActiveDocument { [DispId(3), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap3_1();
        void _VtblGap3_1();
        [DispId(5)]
    Selection Selection { [DispId(5), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap4_104();
        void _VtblGap4_104();
        [DispId(1105)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Quit([MarshalAs(UnmanagedType.Struct), In, Optional] ref object SaveChanges, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OriginalFormat, [MarshalAs(UnmanagedType.Struct), In, Optional] ref object RouteDocument);
  }
}
