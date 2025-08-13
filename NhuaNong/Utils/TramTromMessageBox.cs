// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.TramTromMessageBox
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Utils
{
  public class TramTromMessageBox
  {
    public static void ShowDEPErrorDialog(System.Exception ex)
    {
      int num = (int) new FrmErrorMessage(ex, false)
      {
        AlertMessage = "System Error!\nPlease contact administrator for more detail."
      }.ShowDialog();
    }

    public static void ShowDEPErrorDialog(string errorMsg)
    {
      int num = (int) new FrmErrorMessage(errorMsg, false)
      {
        AlertMessage = "System Error!\nPlease contact administrator for more detail."
      }.ShowDialog();
    }

    public static void ShowDEPErrorDialog(System.Exception ex, string message)
    {
      int num = (int) new FrmErrorMessage(ex, false)
      {
        AlertMessage = message
      }.ShowDialog();
    }

    public static void ShowErrorDialog(string message, Control focusControl)
    {
      int num = (int) XtraMessageBox.Show(message, "Require Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      focusControl.Focus();
    }

    public static void ShowErrorDialog(string message)
    {
      int num = (int) XtraMessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    public static void ShowMessageDialog(string message)
    {
      int num = (int) XtraMessageBox.Show(message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    public static void ShowWarningDialog(string message)
    {
      int num = (int) XtraMessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    public static DialogResult ShowYesNoDialog(string confirmMsg)
    {
      return XtraMessageBox.Show(confirmMsg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    }

    public static DialogResult ShowYesNoCancelDialog(string confirmMsg)
    {
      return XtraMessageBox.Show(confirmMsg, "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
    }
  }
}
