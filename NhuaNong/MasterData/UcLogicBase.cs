// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.UcLogicBase
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class UcLogicBase : UserControl
  {
    private UcLogicBase.NhomSiloEnum _nhomSilo;
    private double _valueLogic;
    private string _numberSiloLogic;
    protected BindingList<ObjSilo> _blstSiloLogic = new BindingList<ObjSilo>();
    protected BindingList<ObjSilo> _blstSiloLogicSeleted1 = new BindingList<ObjSilo>();
    protected BindingList<ObjSilo> _blstSiloLogicSeleted2 = new BindingList<ObjSilo>();
    private IContainer components;
    private SimpleButton btnResetValue;
    private SimpleButton btnSetUpLogic;
    private LabelControl lblLogicName;
    public LookUpEdit lueWeigh2;
    public LookUpEdit lueWeigh1;

    public event UcLogicBase.ButtonEventHandler ButtonSetupLogic;

    public event UcLogicBase.ChangeValueEventHandler ChangeValueBlstLogic_01;

    public event UcLogicBase.ChangeValueEventHandler ChangeValueBlstLogic_02;

    public string SiloLogicTittle
    {
      get => this.lblLogicName.Text;
      set => this.lblLogicName.Text = value;
    }

    public double ValueLogic
    {
      get => this._valueLogic;
      set => this._valueLogic = value;
    }

    public UcLogicBase.NhomSiloEnum NhomSilo
    {
      get => this._nhomSilo;
      set => this._nhomSilo = value;
    }

    public UcLogicBase() => this.InitializeComponent();

    public virtual void GetBlstSiloLogic(BindingList<ObjSilo> _blstSilo)
    {
    }

    public void GetValueLogic()
    {
      double num = 0.0;
      if (!this.ValidateData())
      {
        this.ValueLogic = num;
      }
      else
      {
        switch (this.NhomSilo)
        {
          case UcLogicBase.NhomSiloEnum.AGG:
            this._numberSiloLogic = this.GetNumLogicSiloAG(this.lueWeigh1).ToString() + this.GetNumLogicSiloAG(this.lueWeigh2).ToString();
            break;
          case UcLogicBase.NhomSiloEnum.CE:
            this._numberSiloLogic = this.GetNumLogicSiloCE(this.lueWeigh1).ToString() + this.GetNumLogicSiloCE(this.lueWeigh2).ToString();
            break;
          case UcLogicBase.NhomSiloEnum.ADD:
            this._numberSiloLogic = this.GetNumLogicSiloAD(this.lueWeigh1).ToString() + this.GetNumLogicSiloAD(this.lueWeigh2).ToString();
            break;
        }
        this.ValueLogic = double.Parse(this._numberSiloLogic);
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if ((int) this.lueWeigh1.EditValue == -1)
      {
        this.lueWeigh1.ErrorText = "Silo is requied";
        flag = false;
      }
      if ((int) this.lueWeigh2.EditValue == -1)
      {
        this.lueWeigh2.ErrorText = "Silo is requied";
        flag = false;
      }
      return flag;
    }

    private int GetNumLogicSiloAG(LookUpEdit lueSiloLogic)
    {
      int numLogicSiloAg = 0;
      switch (lueSiloLogic.GetColumnValue("MaSilo").ToString())
      {
        case "Agg1":
          numLogicSiloAg = 1;
          break;
        case "Agg2":
          numLogicSiloAg = 2;
          break;
        case "Agg3":
          numLogicSiloAg = 3;
          break;
        case "Agg4":
          numLogicSiloAg = 4;
          break;
        case "Agg5":
          numLogicSiloAg = 5;
          break;
        case "Agg6":
          numLogicSiloAg = 6;
          break;
      }
      return numLogicSiloAg;
    }

    private int GetNumLogicSiloCE(LookUpEdit lueSiloLogic)
    {
      int numLogicSiloCe = 0;
      switch (lueSiloLogic.GetColumnValue("MaSilo").ToString())
      {
        case "Ce1":
          numLogicSiloCe = 1;
          break;
        case "Ce2":
          numLogicSiloCe = 2;
          break;
        case "Ce3":
          numLogicSiloCe = 3;
          break;
        case "Ce4":
          numLogicSiloCe = 4;
          break;
        case "Ce5":
          numLogicSiloCe = 5;
          break;
      }
      return numLogicSiloCe;
    }

    private int GetNumLogicSiloAD(LookUpEdit lueSiloLogic)
    {
      int numLogicSiloAd = 0;
      switch (lueSiloLogic.GetColumnValue("MaSilo").ToString())
      {
        case "Add1":
          numLogicSiloAd = 1;
          break;
        case "Add2":
          numLogicSiloAd = 2;
          break;
        case "Add3":
          numLogicSiloAd = 3;
          break;
        case "Add4":
          numLogicSiloAd = 4;
          break;
        case "Add5":
          numLogicSiloAd = 5;
          break;
        case "Add6":
          numLogicSiloAd = 6;
          break;
      }
      return numLogicSiloAd;
    }

    protected virtual void lueWeigh1_EditValueChanged(object sender, EventArgs e)
    {
      if (this.ChangeValueBlstLogic_01 == null)
        return;
      this.ChangeValueBlstLogic_01((object) this, new EventArgs());
    }

    protected virtual void lueWeigh2_EditValueChanged(object sender, EventArgs e)
    {
      if (this.ChangeValueBlstLogic_02 == null)
        return;
      this.ChangeValueBlstLogic_02((object) this, new EventArgs());
    }

    protected virtual void btnSetUpLogic_Click(object sender, EventArgs e)
    {
      if (this.ButtonSetupLogic == null)
        return;
      this.ButtonSetupLogic((object) this, new EventArgs());
      if (this.lueWeigh1.Text == string.Empty || this.lueWeigh2.Text == string.Empty)
      {
        this.GetValueLogic();
        TramTromMessageBox.ShowMessageDialog("Đã đưa LOGIC về trạng thái ban đầu.");
      }
      else
      {
        if (TramTromMessageBox.ShowYesNoDialog(string.Format("Xác nhận thực hiện {0} - LOGIC - {1} ?", (object) this.lueWeigh1.Text.ToString(), (object) this.lueWeigh2.Text.ToString())) != DialogResult.Yes)
          return;
        this.GetValueLogic();
      }
    }

    protected virtual void btnResetValue_Click(object sender, EventArgs e) => this.ResetValue();

    private void ResetValue()
    {
      this.lueWeigh1.EditValue = (object) -1;
      this.lueWeigh2.EditValue = (object) -1;
    }

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
      this.lueWeigh2.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.lueWeigh1.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.btnResetValue.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnResetValue.Appearance.Options.UseFont = true;
      this.btnResetValue.Location = new Point(505, 2);
      this.btnResetValue.Name = "btnResetValue";
      this.btnResetValue.Size = new Size(98, 26);
      this.btnResetValue.TabIndex = 32;
      this.btnResetValue.Text = "Làm mới";
      this.btnResetValue.Click += new EventHandler(this.btnResetValue_Click);
      this.btnSetUpLogic.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSetUpLogic.Appearance.Options.UseFont = true;
      this.btnSetUpLogic.Location = new Point(395, 2);
      this.btnSetUpLogic.Name = "btnSetUpLogic";
      this.btnSetUpLogic.Size = new Size(98, 26);
      this.btnSetUpLogic.TabIndex = 31;
      this.btnSetUpLogic.Text = "Thiết lập";
      this.btnSetUpLogic.Click += new EventHandler(this.btnSetUpLogic_Click);
      this.lblLogicName.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblLogicName.Appearance.Options.UseFont = true;
      this.lblLogicName.Location = new Point(14, 7);
      this.lblLogicName.Name = "lblLogicName";
      this.lblLogicName.Size = new Size(63, 16);
      this.lblLogicName.TabIndex = 30;
      this.lblLogicName.Text = "LOGIC CÂN";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.lueWeigh2);
      this.Controls.Add((Control) this.lueWeigh1);
      this.Controls.Add((Control) this.btnResetValue);
      this.Controls.Add((Control) this.btnSetUpLogic);
      this.Controls.Add((Control) this.lblLogicName);
      this.Name = nameof (UcLogicBase);
      this.Size = new Size(625, 30);
      this.lueWeigh2.Properties.EndInit();
      this.lueWeigh1.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public delegate void ButtonEventHandler(object sender, EventArgs e);

    public delegate void ChangeValueEventHandler(object sender, EventArgs e);

    public enum NhomSiloEnum
    {
      AGG,
      CE,
      ADD,
    }
  }
}
