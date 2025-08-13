// Decompiled with JetBrains decompiler
// Type: NhuaNong.ViewManager
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public class ViewManager
  {
    private static Hashtable _htbView = new Hashtable();
    private static Form _frmMain = (Form) null;

    public static object GetView(string name)
    {
      return ViewManager._htbView.ContainsKey((object) name) ? ViewManager._htbView[(object) name] : (object) null;
    }

    public static void ShowView(ControlViewBase ctrView, bool hasKeyDown = true)
    {
      if (ViewManager.GetView(ctrView.Name) is XtraForm view)
      {
        view.Activate();
      }
      else
      {
        XtraForm xtraForm = new XtraForm();
        xtraForm.AutoScroll = true;
        ctrView.AutoScroll = true;
        xtraForm.Controls.Add((Control) ctrView);
        ctrView.Dock = DockStyle.Fill;
        xtraForm.MdiParent = ViewManager._frmMain;
        xtraForm.Name = ctrView.Name;
        xtraForm.Text = ctrView.Caption;
        xtraForm.AutoScaleMode = AutoScaleMode.Font;
        xtraForm.FormClosed += new FormClosedEventHandler(ViewManager.frm_FormClosed);
        xtraForm.FormClosing += new FormClosingEventHandler(ViewManager.frm_FormClosing);
        if (hasKeyDown)
        {
          xtraForm.KeyPreview = true;
          xtraForm.KeyDown += new KeyEventHandler(ViewManager.frm_KeyDown);
        }
        ViewManager._htbView.Add((object) xtraForm.Name, (object) xtraForm);
        xtraForm.Show();
        (ViewManager._frmMain as NhuaNong.FrmMain).EnabledCloseAllDocs();
      }
    }

    public static void ShowViewWindow(ControlViewBase ctrView, bool inTashbar, bool maxWindowState = false)
    {
      XtraForm xtraForm = new XtraForm();
      xtraForm.Size = ctrView.Size;
      xtraForm.ShowInTaskbar = inTashbar;
      xtraForm.MinimizeBox = false;
      xtraForm.MaximizeBox = false;
      xtraForm.FormBorderStyle = FormBorderStyle.FixedDialog;
      xtraForm.StartPosition = FormStartPosition.CenterParent;
      if (maxWindowState)
      {
        xtraForm.MinimizeBox = true;
        xtraForm.MaximizeBox = true;
        xtraForm.WindowState = FormWindowState.Maximized;
      }
      xtraForm.ClientSize = new Size(ctrView.ClientSize.Width, ctrView.ClientSize.Height);
      ctrView.Dock = DockStyle.Fill;
      xtraForm.Controls.Add((Control) ctrView);
      xtraForm.Name = ctrView.Name;
      xtraForm.Text = ctrView.Caption;
      xtraForm.Show();
    }

    private static void frm_KeyDown(object sender, KeyEventArgs e)
    {
      ((sender as XtraForm).Controls[0] as ControlViewBase).DoKeyDown(sender, e);
    }

    private static void frm_FormClosing(object sender, FormClosingEventArgs e)
    {
      ((sender as XtraForm).Controls[0] as ControlViewBase).DoClosing(e);
    }

    private static void frm_FormClosed(object sender, FormClosedEventArgs e)
    {
      XtraForm xtraForm = sender as XtraForm;
      ViewManager._htbView.Remove((object) xtraForm.Name);
      (xtraForm.Controls[0] as ControlViewBase).DoClosed(e);
      xtraForm.Dispose();
      NhuaNong.FrmMain frmMain = ViewManager._frmMain as NhuaNong.FrmMain;
      if (((IEnumerable<Form>) frmMain.MdiChildren).Count<Form>() != 0)
        return;
      frmMain.DisabledCloseAllDocs();
    }

    public static void ShowViewDialog(ControlViewBase ctrView)
    {
      XtraForm xtraForm = new XtraForm();
      xtraForm.Size = ctrView.Size;
      xtraForm.ShowInTaskbar = false;
      xtraForm.MinimizeBox = false;
      xtraForm.MaximizeBox = false;
      xtraForm.FormBorderStyle = FormBorderStyle.FixedDialog;
      xtraForm.StartPosition = FormStartPosition.CenterParent;
      Size clientSize = ctrView.ClientSize;
      int width = clientSize.Width;
      clientSize = ctrView.ClientSize;
      int height = clientSize.Height;
      xtraForm.ClientSize = new Size(width, height);
      ctrView.Dock = DockStyle.Fill;
      xtraForm.Controls.Add((Control) ctrView);
      xtraForm.Name = ctrView.Name;
      xtraForm.Text = ctrView.Caption;
      int num = (int) xtraForm.ShowDialog();
    }

    public static void ShowViewDialog(DialogViewBase dlgView)
    {
      int num = (int) dlgView.ShowDialog();
    }

    public static void CloseAllForm()
    {
      foreach (Form mdiChild in ViewManager._frmMain.MdiChildren)
        mdiChild.Close();
    }

    public static Form FrmMain
    {
      get => ViewManager._frmMain;
      set => ViewManager._frmMain = value;
    }
  }
}
