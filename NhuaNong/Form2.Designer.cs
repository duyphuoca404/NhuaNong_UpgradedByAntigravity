namespace NhuaNong
{
  partial class Form2
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.vanHanh1 = new NhuaNong.MasterData.VanHanh();
      this.SuspendLayout();
      // 
      // vanHanh1
      // 
      this.vanHanh1.BackColor = System.Drawing.Color.Gainsboro;
      this.vanHanh1.Caption = "Vận hành";
      this.vanHanh1.IsRunBTC = false;
      this.vanHanh1.IsRunBTX = true;
      this.vanHanh1.IsRunNoiTron = false;
      this.vanHanh1.Location = new System.Drawing.Point(1, 1);
      this.vanHanh1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
      this.vanHanh1.Name = "vanHanh1";
      this.vanHanh1.Size = new System.Drawing.Size(2560, 1349);
      this.vanHanh1.TabIndex = 0;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(3182, 1325);
      this.Controls.Add(this.vanHanh1);
      this.Name = "Form2";
      this.Text = "Form2";
      this.ResumeLayout(false);

    }

    #endregion

    private MasterData.VanHanh vanHanh1;
  }
}