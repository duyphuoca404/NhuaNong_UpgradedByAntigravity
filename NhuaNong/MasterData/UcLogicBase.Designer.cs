using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using NhuaNong.Data;
using NhuaNong.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.MasterData
{
  public partial class UcLogicBase
  {
    private IContainer components;
    private SimpleButton btnResetValue;
    private SimpleButton btnSetUpLogic;
    private LabelControl lblLogicName;
    public LookUpEdit lueWeigh2;
    public LookUpEdit lueWeigh1;


    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lueWeigh2 = new LookUpEdit();
      this.lueWeigh1 = new LookUpEdit();
      this.btnResetValue = new SimpleButton();
      this.btnSetUpLogic = new SimpleButton();
      this.lblLogicName = new LabelControl();
      this.lueWeigh2.Properties.BeginInit();
      this.lueWeigh1.Properties.BeginInit();
      this.SuspendLayout();
      this.lueWeigh2.Location = new Point(259, 4);
      this.lueWeigh2.Name = "lueWeigh2";
      this.lueWeigh2.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueWeigh2.Properties.Appearance.Options.UseFont = true;
      this.lueWeigh2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueWeigh2.Properties.Columns.AddRange(new LookUpColumnInfo[4]
      {
        new LookUpColumnInfo("MaSilo", "Mã Silo"),
        new LookUpColumnInfo("TenSilo", "Tên Silo"),
        new LookUpColumnInfo("SiloID", "SiloID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("MaterialName", "Tên Vật tư")
      });
      this.lueWeigh2.Properties.DisplayMember = "MaSilo";
      this.lueWeigh2.Properties.NullText = "";
      this.lueWeigh2.Properties.ValueMember = "SiloID";
      this.lueWeigh2.Size = new Size(117, 22);
      this.lueWeigh2.TabIndex = 34;
      this.lueWeigh2.EditValueChanged += new EventHandler(this.lueWeigh2_EditValueChanged);
      this.lueWeigh1.Location = new Point(130, 4);
      this.lueWeigh1.Name = "lueWeigh1";
      this.lueWeigh1.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueWeigh1.Properties.Appearance.Options.UseFont = true;
      this.lueWeigh1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueWeigh1.Properties.Columns.AddRange(new LookUpColumnInfo[4]
      {
        new LookUpColumnInfo("MaSilo", "Mã Silo"),
        new LookUpColumnInfo("TenSilo", "Tên Silo"),
        new LookUpColumnInfo("SiloID", "SiloID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("MaterialName", "Tên Vật tư")
      });
      this.lueWeigh1.Properties.DisplayMember = "MaSilo";
      this.lueWeigh1.Properties.NullText = "";
      this.lueWeigh1.Properties.ValueMember = "MaSilo";
      this.lueWeigh1.Size = new Size(117, 22);
      this.lueWeigh1.TabIndex = 33;
      this.lueWeigh1.EditValueChanged += new EventHandler(this.lueWeigh1_EditValueChanged);
      this.btnResetValue.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnResetValue.Appearance.Options.UseFont = true;
      this.btnResetValue.Location = new Point(505, 2);
      this.btnResetValue.Name = "btnResetValue";
      this.btnResetValue.Size = new Size(98, 26);
      this.btnResetValue.TabIndex = 32;
      this.btnResetValue.Text = "Làm mới";
      this.btnResetValue.Click += new EventHandler(this.btnResetValue_Click);
      this.btnSetUpLogic.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSetUpLogic.Appearance.Options.UseFont = true;
      this.btnSetUpLogic.Location = new Point(395, 2);
      this.btnSetUpLogic.Name = "btnSetUpLogic";
      this.btnSetUpLogic.Size = new Size(98, 26);
      this.btnSetUpLogic.TabIndex = 31;
      this.btnSetUpLogic.Text = "Thiết lập";
      this.btnSetUpLogic.Click += new EventHandler(this.btnSetUpLogic_Click);
      this.lblLogicName.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblLogicName.Appearance.Options.UseFont = true;
      this.lblLogicName.Location = new Point(14, 7);
      this.lblLogicName.Name = "lblLogicName";
      this.lblLogicName.Size = new Size(63, 16);
      this.lblLogicName.TabIndex = 30;
      this.lblLogicName.Text = "LOGIC CÂN";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.lueWeigh2);
      this.Controls.Add((Control)this.lueWeigh1);
      this.Controls.Add((Control)this.btnResetValue);
      this.Controls.Add((Control)this.btnSetUpLogic);
      this.Controls.Add((Control)this.lblLogicName);
      this.Name = "UcLogicBase";
      this.Size = new Size(625, 30);
      this.lueWeigh2.Properties.EndInit();
      this.lueWeigh1.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
