// Decompiled with JetBrains decompiler
// Type: Microsoft.Office.Interop.Word.Documents
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace Microsoft.Office.Interop.Word
{
  [CompilerGenerated]
  [DefaultMember("Item")]
  [Guid("0002096C-0000-0000-C000-000000000046")]
  [TypeIdentifier]
  [ComImport]
  public interface Documents : IEnumerable
  {
    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap1_1();
        void _VtblGap1_1();
        [DispId(2)]
    int Count { [DispId(2), MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
        //sealed extern void _VtblGap2_8();
        void _VtblGap2_8();
        [DispId(14)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    Document Add(
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Template,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NewTemplate,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DocumentType,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Visible);

    [SpecialName]
    [MethodImpl(MethodCodeType = MethodCodeType.Runtime)]
    //sealed extern void _VtblGap3_4();
        void _VtblGap3_4();
        [DispId(19)]
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    Document Open(
      [MarshalAs(UnmanagedType.Struct), In] ref object FileName,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ConfirmConversions,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object ReadOnly,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object AddToRecentFiles,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordDocument,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object PasswordTemplate,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Revert,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordDocument,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object WritePasswordTemplate,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Format,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Encoding,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object Visible,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object OpenAndRepair,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object DocumentDirection,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object NoEncodingDialog,
      [MarshalAs(UnmanagedType.Struct), In, Optional] ref object XMLTransform);
  }
}
