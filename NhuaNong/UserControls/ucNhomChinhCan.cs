using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucNhomChinhCan : UserControl
  {
    private string _nameGroup;
    private string _giaTriXung;
    private string _giaTriNhap0;
    private string _giaTriNhapTai;
    private string _giaTriNhapHeSo;
    private string _giaTriKLThucTe;
    

    public event ucNhomChinhCan.ButtonEventHandler ButtonChinh0_Down;

    public event ucNhomChinhCan.ButtonEventHandler ButtonChinh0_Up;

    public event ucNhomChinhCan.ButtonEventHandler ButtonChinhTai_Down;

    public event ucNhomChinhCan.ButtonEventHandler ButtonChinhTai_Up;

    public event ucNhomChinhCan.EnterKey Enter_Down_Nhap0;

    public event ucNhomChinhCan.EnterKey Enter_Down_NhapTai;

    public event ucNhomChinhCan.EnterKey Enter_Down_NhapHeSo;

    public string NameGroup
    {
      get => this._nameGroup;
      set
      {
        this._nameGroup = value;
        this.groupControl1.Text = this._nameGroup;
      }
    }

    public string GiaTri_Xung
    {
      get => this._giaTriXung;
      set
      {
        this._giaTriXung = value;
        this.txtXung.Text = this._giaTriXung;
      }
    }

    public string GiaTri_Nhap0
    {
      get => this._giaTriNhap0;
      set
      {
        this._giaTriNhap0 = value;
        this.txtNhap0.Text = this._giaTriNhap0;
      }
    }

    public string GiaTri_NhapTai
    {
      get => this._giaTriNhapTai;
      set
      {
        this._giaTriNhapTai = value;
        this.txtNhapTai.Text = this._giaTriNhapTai;
      }
    }

    public string GiaTri_NhapHeSo
    {
      get => this._giaTriNhapHeSo;
      set
      {
        this._giaTriNhapHeSo = value;
        this.txtNhapHeSo.Text = this._giaTriNhapHeSo;
      }
    }

    public string GiaTri_KLThucTe
    {
      get => this._giaTriKLThucTe;
      set
      {
        this._giaTriKLThucTe = value;
        this.txtKLThucTe.Text = this._giaTriKLThucTe;
      }
    }

    public ucNhomChinhCan()
    {
      this.InitializeComponent();
      this.Name = nameof(ucNhomChinhCan);
    }

    private void txtXung_EditValueChanged(object sender, EventArgs e)
    {
      this.GiaTri_Xung = this.txtXung.Text;
    }

    private void txtNhap0_EditValueChanged(object sender, EventArgs e)
    {
      this.GiaTri_Nhap0 = this.txtNhap0.Text;
    }

    private void txtNhapTai_EditValueChanged(object sender, EventArgs e)
    {
      this.GiaTri_NhapTai = this.txtNhapTai.Text;
    }

    private void txtNhapHeSo_EditValueChanged(object sender, EventArgs e)
    {
      this.GiaTri_NhapHeSo = this.txtNhapHeSo.Text;
    }

    private void txtKLThucTe_EditValueChanged(object sender, EventArgs e)
    {
      this._giaTriKLThucTe = this.txtKLThucTe.Text;
    }

    private void txtNhap0_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
        return;
      e.Handled = true;
    }

    private void txtNhapTai_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
        return;
      e.Handled = true;
    }

    private void txtNhapHeSo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!(sender is TextBox textBox))
        return;
      if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
        e.Handled = true;
      if (e.KeyChar != '.' || textBox.Text.IndexOf('.') <= -1)
        return;
      e.Handled = true;
    }

    private void txtNhap0_KeyDown(object sender, KeyEventArgs e)
    {
      if (this.Enter_Down_Nhap0 == null)
        return;
      this.Enter_Down_Nhap0((object) this, new KeyEventArgs(e.KeyCode));
    }

    private void txtNhapTai_KeyDown(object sender, KeyEventArgs e)
    {
      if (this.Enter_Down_NhapTai == null)
        return;
      this.Enter_Down_NhapTai((object) this, new KeyEventArgs(e.KeyCode));
    }

    private void txtNhapHeSo_KeyDown(object sender, KeyEventArgs e)
    {
      if (this.Enter_Down_NhapHeSo == null)
        return;
      this.Enter_Down_NhapHeSo((object) this, new KeyEventArgs(e.KeyCode));
    }

    private void btnChinh0_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonChinh0_Down == null)
        return;
      this.ButtonChinh0_Down((object) this, new EventArgs());
    }

    private void btnChinh0_MouseUp(object sender, MouseEventArgs e)
    {
      if (this.ButtonChinh0_Up == null)
        return;
      this.ButtonChinh0_Up((object) this, new EventArgs());
    }

    private void btnChinhTai_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonChinhTai_Down == null)
        return;
      this.ButtonChinhTai_Down((object) this, new EventArgs());
    }

    private void btnChinhTai_MouseUp(object sender, MouseEventArgs e)
    {
      if (this.ButtonChinhTai_Up == null)
        return;
      this.ButtonChinhTai_Up((object) this, new EventArgs());
    }

    public delegate void ButtonEventHandler(object sender, EventArgs e);

    public delegate void EnterKey(object sender, KeyEventArgs e);
  }
}
