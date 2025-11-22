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

namespace NDPSo.MasterData
{
  public partial class UcTam
  {
    private IContainer components;
    private SimpleButton simpleButton7;
    private SimpleButton simpleButton8;
    private LookUpEdit lookUpEdit5;
    private LookUpEdit lookUpEdit6;
    private SimpleButton simpleButton5;
    private SimpleButton simpleButton6;
    private LookUpEdit lookUpEdit3;
    private LookUpEdit lookUpEdit4;
    private SimpleButton simpleButton4;
    private SimpleButton simpleButton3;
    private LookUpEdit lookUpEdit2;
    private LookUpEdit lookUpEdit1;
    private LabelControl lblLogicCanAdd1;
    private LabelControl lblLogicCanCe2;
    private LabelControl lblLogicCanCe1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.simpleButton7 = new SimpleButton();
      this.simpleButton8 = new SimpleButton();
      this.lookUpEdit5 = new LookUpEdit();
      this.lookUpEdit6 = new LookUpEdit();
      this.simpleButton5 = new SimpleButton();
      this.simpleButton6 = new SimpleButton();
      this.lookUpEdit3 = new LookUpEdit();
      this.lookUpEdit4 = new LookUpEdit();
      this.simpleButton4 = new SimpleButton();
      this.simpleButton3 = new SimpleButton();
      this.lookUpEdit2 = new LookUpEdit();
      this.lookUpEdit1 = new LookUpEdit();
      this.lblLogicCanAdd1 = new LabelControl();
      this.lblLogicCanCe2 = new LabelControl();
      this.lblLogicCanCe1 = new LabelControl();
      this.lookUpEdit5.Properties.BeginInit();
      this.lookUpEdit6.Properties.BeginInit();
      this.lookUpEdit3.Properties.BeginInit();
      this.lookUpEdit4.Properties.BeginInit();
      this.lookUpEdit2.Properties.BeginInit();
      this.lookUpEdit1.Properties.BeginInit();
      this.SuspendLayout();
      this.simpleButton7.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.simpleButton7.Appearance.Options.UseFont = true;
      this.simpleButton7.Location = new Point(654, 251);
      this.simpleButton7.Name = "simpleButton7";
      this.simpleButton7.Size = new Size(98, 26);
      this.simpleButton7.TabIndex = 32;
      this.simpleButton7.Text = "Reset";
      this.simpleButton7.UseWaitCursor = true;
      this.simpleButton8.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.simpleButton8.Appearance.Options.UseFont = true;
      this.simpleButton8.Location = new Point(550, 251);
      this.simpleButton8.Name = "simpleButton8";
      this.simpleButton8.Size = new Size(98, 26);
      this.simpleButton8.TabIndex = 31;
      this.simpleButton8.Text = "Thiết lập";
      this.simpleButton8.UseWaitCursor = true;
      this.lookUpEdit5.Location = new Point(391, 253);
      this.lookUpEdit5.Name = "lookUpEdit5";
      this.lookUpEdit5.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lookUpEdit5.Properties.Appearance.Options.UseFont = true;
      this.lookUpEdit5.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit5.Properties.NullText = "";
      this.lookUpEdit5.Size = new Size(135, 22);
      this.lookUpEdit5.TabIndex = 30;
      this.lookUpEdit5.UseWaitCursor = true;
      this.lookUpEdit6.Location = new Point(242, 253);
      this.lookUpEdit6.Name = "lookUpEdit6";
      this.lookUpEdit6.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lookUpEdit6.Properties.Appearance.Options.UseFont = true;
      this.lookUpEdit6.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit6.Properties.NullText = "";
      this.lookUpEdit6.Size = new Size(135, 22);
      this.lookUpEdit6.TabIndex = 29;
      this.lookUpEdit6.UseWaitCursor = true;
      this.simpleButton5.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.simpleButton5.Appearance.Options.UseFont = true;
      this.simpleButton5.Location = new Point(654, 220);
      this.simpleButton5.Name = "simpleButton5";
      this.simpleButton5.Size = new Size(98, 26);
      this.simpleButton5.TabIndex = 28;
      this.simpleButton5.Text = "Reset";
      this.simpleButton5.UseWaitCursor = true;
      this.simpleButton6.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.simpleButton6.Appearance.Options.UseFont = true;
      this.simpleButton6.Location = new Point(550, 220);
      this.simpleButton6.Name = "simpleButton6";
      this.simpleButton6.Size = new Size(98, 26);
      this.simpleButton6.TabIndex = 27;
      this.simpleButton6.Text = "Thiết lập";
      this.simpleButton6.UseWaitCursor = true;
      this.lookUpEdit3.Location = new Point(391, 222);
      this.lookUpEdit3.Name = "lookUpEdit3";
      this.lookUpEdit3.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lookUpEdit3.Properties.Appearance.Options.UseFont = true;
      this.lookUpEdit3.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit3.Properties.NullText = "";
      this.lookUpEdit3.Size = new Size(135, 22);
      this.lookUpEdit3.TabIndex = 26;
      this.lookUpEdit3.UseWaitCursor = true;
      this.lookUpEdit4.Location = new Point(242, 222);
      this.lookUpEdit4.Name = "lookUpEdit4";
      this.lookUpEdit4.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lookUpEdit4.Properties.Appearance.Options.UseFont = true;
      this.lookUpEdit4.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit4.Properties.NullText = "";
      this.lookUpEdit4.Size = new Size(135, 22);
      this.lookUpEdit4.TabIndex = 25;
      this.lookUpEdit4.UseWaitCursor = true;
      this.simpleButton4.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.simpleButton4.Appearance.Options.UseFont = true;
      this.simpleButton4.Location = new Point(654, 190);
      this.simpleButton4.Name = "simpleButton4";
      this.simpleButton4.Size = new Size(98, 26);
      this.simpleButton4.TabIndex = 24;
      this.simpleButton4.Text = "Reset";
      this.simpleButton4.UseWaitCursor = true;
      this.simpleButton3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.simpleButton3.Appearance.Options.UseFont = true;
      this.simpleButton3.Location = new Point(550, 190);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.Size = new Size(98, 26);
      this.simpleButton3.TabIndex = 23;
      this.simpleButton3.Text = "Thiết lập";
      this.simpleButton3.UseWaitCursor = true;
      this.lookUpEdit2.Location = new Point(391, 192);
      this.lookUpEdit2.Name = "lookUpEdit2";
      this.lookUpEdit2.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lookUpEdit2.Properties.Appearance.Options.UseFont = true;
      this.lookUpEdit2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit2.Properties.NullText = "";
      this.lookUpEdit2.Size = new Size(135, 22);
      this.lookUpEdit2.TabIndex = 22;
      this.lookUpEdit2.UseWaitCursor = true;
      this.lookUpEdit1.Location = new Point(242, 192);
      this.lookUpEdit1.Name = "lookUpEdit1";
      this.lookUpEdit1.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
      this.lookUpEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit1.Properties.NullText = "";
      this.lookUpEdit1.Size = new Size(135, 22);
      this.lookUpEdit1.TabIndex = 21;
      this.lookUpEdit1.UseWaitCursor = true;
      this.lblLogicCanAdd1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblLogicCanAdd1.Appearance.Options.UseFont = true;
      this.lblLogicCanAdd1.Location = new Point(117, 256);
      this.lblLogicCanAdd1.Margin = new Padding(2);
      this.lblLogicCanAdd1.Name = "lblLogicCanAdd1";
      this.lblLogicCanAdd1.Size = new Size(94, 16);
      this.lblLogicCanAdd1.TabIndex = 20;
      this.lblLogicCanAdd1.Text = "Logic Cân ADD 1";
      this.lblLogicCanAdd1.UseWaitCursor = true;
      this.lblLogicCanCe2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblLogicCanCe2.Appearance.Options.UseFont = true;
      this.lblLogicCanCe2.Location = new Point(125, 225);
      this.lblLogicCanCe2.Margin = new Padding(2);
      this.lblLogicCanCe2.Name = "lblLogicCanCe2";
      this.lblLogicCanCe2.Size = new Size(85, 16);
      this.lblLogicCanCe2.TabIndex = 19;
      this.lblLogicCanCe2.Text = "Logic Cân CE 2";
      this.lblLogicCanCe2.UseWaitCursor = true;
      this.lblLogicCanCe1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblLogicCanCe1.Appearance.Options.UseFont = true;
      this.lblLogicCanCe1.Location = new Point(125, 195);
      this.lblLogicCanCe1.Margin = new Padding(2);
      this.lblLogicCanCe1.Name = "lblLogicCanCe1";
      this.lblLogicCanCe1.Size = new Size(85, 16);
      this.lblLogicCanCe1.TabIndex = 18;
      this.lblLogicCanCe1.Text = "Logic Cân CE 1";
      this.lblLogicCanCe1.UseWaitCursor = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.simpleButton7);
      this.Controls.Add((Control)this.simpleButton8);
      this.Controls.Add((Control)this.lookUpEdit5);
      this.Controls.Add((Control)this.lookUpEdit6);
      this.Controls.Add((Control)this.simpleButton5);
      this.Controls.Add((Control)this.simpleButton6);
      this.Controls.Add((Control)this.lookUpEdit3);
      this.Controls.Add((Control)this.lookUpEdit4);
      this.Controls.Add((Control)this.simpleButton4);
      this.Controls.Add((Control)this.simpleButton3);
      this.Controls.Add((Control)this.lookUpEdit2);
      this.Controls.Add((Control)this.lookUpEdit1);
      this.Controls.Add((Control)this.lblLogicCanAdd1);
      this.Controls.Add((Control)this.lblLogicCanCe2);
      this.Controls.Add((Control)this.lblLogicCanCe1);
      this.Name = "UcTam";
      this.Size = new Size(868, 466);
      this.lookUpEdit5.Properties.EndInit();
      this.lookUpEdit6.Properties.EndInit();
      this.lookUpEdit3.Properties.EndInit();
      this.lookUpEdit4.Properties.EndInit();
      this.lookUpEdit2.Properties.EndInit();
      this.lookUpEdit1.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
