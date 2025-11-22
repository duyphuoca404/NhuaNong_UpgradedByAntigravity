using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhuaNong.UserControls
{
  public partial class ucVitTaiFD
  {
    private IContainer components;
    private PictureEdit pictureEdit1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pictureEdit1 = new PictureEdit();
      this.pictureEdit1.Properties.BeginInit();
      this.SuspendLayout();
      this.pictureEdit1.Location = new Point(0, 86);
      this.pictureEdit1.Name = "pictureEdit1";
      this.pictureEdit1.Properties.AllowFocused = false;
      this.pictureEdit1.Properties.Appearance.BackColor = Color.Transparent;
      this.pictureEdit1.Properties.Appearance.ForeColor = Color.Transparent;
      this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
      this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
      this.pictureEdit1.Properties.BorderStyle = BorderStyles.NoBorder;
      this.pictureEdit1.Properties.NullText = " ";
      this.pictureEdit1.Properties.ReadOnly = true;
      this.pictureEdit1.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.pictureEdit1.Size = new Size(50, 50);
      this.pictureEdit1.TabIndex = 0;
      this.pictureEdit1.MouseDown += new MouseEventHandler(this.pictureEdit1_MouseDown);
      this.pictureEdit1.MouseUp += new MouseEventHandler(this.pictureEdit1_MouseUp);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Transparent;
      this.BackgroundImage = (Image)ResourceNhua._vittaiFD;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.Controls.Add((Control)this.pictureEdit1);
      this.DoubleBuffered = true;
      this.Name = "ucVitTaiFD";
      this.Size = new Size(132, 136);
      this.Click += new EventHandler(this.ucVitTaiFD_Click);
      this.pictureEdit1.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}
