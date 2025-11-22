using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.UserControls
{
  public partial class ucNhomChinhNhietDo : UserControl
  {
    private string _nameGroup;
    private string _giaTriXung;
    private string _giaTriNhap0;
    private string _giaTriNhapTai;
    private string _giaTriNhapHeSo;
    private string _giaTriKLThucTe;
    

    public event ucNhomChinhNhietDo.ButtonEventHandler ButtonChinhT1_Down;

    public event ucNhomChinhNhietDo.ButtonEventHandler ButtonChinhT1_Up;

    public event ucNhomChinhNhietDo.ButtonEventHandler ButtonChinhT2_Down;

    public event ucNhomChinhNhietDo.ButtonEventHandler ButtonChinhT2_Up;

    public event ucNhomChinhNhietDo.EnterKey Enter_Down_Nhap0;

    public event ucNhomChinhNhietDo.EnterKey Enter_Down_NhapTai;

    public event ucNhomChinhNhietDo.EnterKey Enter_Down_NhapHeSo;

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

    public string GiaTri_NhapT1
    {
      get => this._giaTriNhap0;
      set
      {
        this._giaTriNhap0 = value;
        this.txtNhap0.Text = this._giaTriNhap0;
      }
    }

    public string GiaTri_NhapT2
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

    public ucNhomChinhNhietDo()
    {
      this.InitializeComponent();
      this.Name = nameof(ucNhomChinhNhietDo);
    }

    private void txtXung_EditValueChanged(object sender, EventArgs e)
    {
      this.GiaTri_Xung = this.txtXung.Text;
    }

    private void txtNhap0_EditValueChanged(object sender, EventArgs e)
    {
      this.GiaTri_NhapT1 = this.txtNhap0.Text;
    }

    private void txtNhapTai_EditValueChanged(object sender, EventArgs e)
    {
      this.GiaTri_NhapT2 = this.txtNhapTai.Text;
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
      if (this.ButtonChinhT1_Down == null)
        return;
      this.ButtonChinhT1_Down((object) this, new EventArgs());
    }

    private void btnChinh0_MouseUp(object sender, MouseEventArgs e)
    {
      if (this.ButtonChinhT1_Up == null)
        return;
      this.ButtonChinhT1_Up((object) this, new EventArgs());
    }

    private void btnChinhTai_MouseDown(object sender, MouseEventArgs e)
    {
      if (this.ButtonChinhT2_Down == null)
        return;
      this.ButtonChinhT2_Down((object) this, new EventArgs());
    }

    private void btnChinhTai_MouseUp(object sender, MouseEventArgs e)
    {
      if (this.ButtonChinhT2_Up == null)
        return;
      this.ButtonChinhT2_Up((object) this, new EventArgs());
    }

    

    public delegate void ButtonEventHandler(object sender, EventArgs e);

    public delegate void EnterKey(object sender, KeyEventArgs e);
  }
}
