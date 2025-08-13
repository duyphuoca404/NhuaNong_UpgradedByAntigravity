// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.FrmChinhCan
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.PLCMapping;
using NhuaNong.PLCModule;
using NhuaNong.UserControls;
using NhuaNong.Utils;
using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class FrmChinhCan : DialogViewBase, IFrmKiemDinhCan, IBase
  {
    private SendingToPLC _so = new SendingToPLC();
    private ReceivingFromPLC _ro = new ReceivingFromPLC();
    private PLCController _plcController = new PLCController();
    private SetPoint_NotHD _sp_NotHD = new SetPoint_NotHD();
    private IContainer components;
    private ucNhomChinhCan ucCanFD;
    private ucNhomChinhCan ucCanAG;
    private ucNhomChinhCan ucCanAP;
    private ucNhomChinhCan ucCanSB;
    private ucNhomChinhNhietDo ucNhietTS;
    private ucNhomChinhNhietDo ucNhietAG;
    private ucNhomChinhNhietDo ucNhietAP;
    private ucNhomChinhNhietDo ucNhietTL;
    private System.Windows.Forms.Timer timer1;

    public FrmChinhCan() => this.InitializeComponent();

    private double ConvertData(uint data)
    {
      double num1 = (double) data.ConvertToFloat();
      double num2;
      return num1 > 32000.0 || num1 < -32000.0 ? (num2 = 0.0) : num1;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (!this._plcController.IsConnected)
        return;
      this.ReceiveData_DB6(this._plcController.ReadBytes(S7.Net.DataType.DataBlock, 6, 0, 160));
      this.BindReceivingOnline(this._ro);
    }

    private void SendData_DB_2_NewTread()
    {
      new Thread(new ThreadStart(this.Send_Data_DB_2_To_PLC)).Start();
    }

    private void SendData_DB_6_NewTread()
    {
      new Thread(new ThreadStart(this.Send_Data_DB_6_To_PLC)).Start();
    }

    private void Send_Data_DB_2_To_PLC()
    {
      if (this._plcController == null)
      {
        int num = (int) MessageBox.Show("PLC MẤT KẾT NỐI");
      }
      else
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 2, 7, new List<byte>()
        {
          this._so.Byte_7,
          this._so.Byte_8,
          this._so.Byte_9
        }.ToArray());
    }

    private void Send_Data_DB_6_To_PLC()
    {
      if (this._plcController == null)
      {
        int num = (int) MessageBox.Show("PLC MẤT KẾT NỐI");
      }
      else
      {
        List<byte> byteList = new List<byte>();
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_ZERO_AG1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_SPAN_AG1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_ZERO_FD1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_SPAN_FD1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_ZERO_AP1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_SPAN_AP1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_ZERO_SB1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_SPAN_SB1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.ZERO_TEMP_TS));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.SPAN_TEMP_TS));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.ZERO_TEMP_AG));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.SPAN_TEMP_AG));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.ZERO_TEMP_AP));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.SPAN_TEMP_AP));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.ZERO_TEMP_TL));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.SPAN_TEMP_TL));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_AG1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_FD1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_AP1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_SB1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_TEMP1));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_TEMP2));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_TEMP3));
        byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_TEMP4));
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 0, byteList.ToArray());
      }
    }

    private void ReceiveData_DB6(byte[] a)
    {
      this._ro.KL_ZERO_AG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[0], a[1], a[2], a[3]));
      this._ro.KL_SPAN_AG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[4], a[5], a[6], a[7]));
      this._ro.KL_ZERO_FD1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[8], a[9], a[10], a[11]));
      this._ro.KL_SPAN_FD1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[12], a[13], a[14], a[15]));
      this._ro.KL_ZERO_AP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[16], a[17], a[18], a[19]));
      this._ro.KL_SPAN_AP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[20], a[21], a[22], a[23]));
      this._ro.KL_ZERO_SB1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[24], a[25], a[26], a[27]));
      this._ro.KL_SPAN_SB1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[28], a[29], a[30], a[31]));
      this._ro.ZERO_TEMP_TS = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[32], a[33], a[34], a[35]));
      this._ro.SPAN_TEMP_TS = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[36], a[37], a[38], a[39]));
      this._ro.ZERO_TEMP_AG = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[40], a[41], a[42], a[43]));
      this._ro.SPAN_TEMP_AG = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[44], a[45], a[46], a[47]));
      this._ro.ZERO_TEMP_AP = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[48], a[49], a[50], a[51]));
      this._ro.SPAN_TEMP_AP = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[52], a[53], a[54], a[55]));
      this._ro.ZERO_TEMP_TL = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[56], a[57], a[58], a[59]));
      this._ro.SPAN_TEMP_TL = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[60], a[61], a[62], a[63]));
      this._ro.HS_AG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[64], a[65], a[66], a[67]));
      this._ro.HS_FD1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[68], a[69], a[70], a[71]));
      this._ro.HS_AP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[72], a[73], a[74], a[75]));
      this._ro.HS_SB1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[76], a[77], a[78], a[79]));
      this._ro.HS_TEMP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[80], a[81], a[82], a[83]));
      this._ro.HS_TEMP2 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[84], a[85], a[86], a[87]));
      this._ro.HS_TEMP3 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[88], a[89], a[90], a[91]));
      this._ro.HS_TEMP4 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[92], a[93], a[94], a[95]));
      this._ro.XUNG_AG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[96], a[97], a[98], a[99]));
      this._ro.XUNG_FD1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[100], a[101], a[102], a[103]));
      this._ro.XUNG_AP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[104], a[105], a[106], a[107]));
      this._ro.XUNG_SB1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[108], a[109], a[110], a[111]));
      this._ro.XUNG_TEMP_TS = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[112], a[113], a[114], a[115]));
      this._ro.XUNG_TEMP_AG = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[116], a[117], a[118], a[119]));
      this._ro.XUNG_TEMP_AP = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[120], a[121], a[122], a[123]));
      this._ro.XUNG_TEMP_TL = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[124], a[125], a[126], a[(int) sbyte.MaxValue]));
      this._ro.KLT_AG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[128], a[129], a[130], a[131]));
      this._ro.KLT_FD1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[132], a[133], a[134], a[135]));
      this._ro.KLT_AP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[136], a[137], a[138], a[139]));
      this._ro.KLT_SB1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[140], a[141], a[142], a[143]));
      this._ro.NDT_TS = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[144], a[145], a[146], a[147]));
      this._ro.NDT_AG = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[148], a[149], a[150], a[151]));
      this._ro.NDT_AP = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[152], a[153], a[154], a[155]));
      this._ro.NDT_TL = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[156], a[157], a[158], a[159]));
    }

    private void BindReceivingOnline(ReceivingFromPLC ro)
    {
      try
      {
        if (this.InvokeRequired)
        {
          this.Invoke((Delegate) (() => this.BindReceivingOnline(ro)));
        }
        else
        {
          this.ucCanFD.GiaTri_Xung = this._ro.XUNG_FD1.ToString();
          this.ucCanAG.GiaTri_Xung = this._ro.XUNG_AG1.ToString();
          this.ucCanAP.GiaTri_Xung = this._ro.XUNG_AP1.ToString();
          this.ucCanSB.GiaTri_Xung = this._ro.XUNG_SB1.ToString();
          this.ucNhietTS.GiaTri_Xung = this._ro.XUNG_TEMP_TS.ToString();
          this.ucNhietAG.GiaTri_Xung = this._ro.XUNG_TEMP_AG.ToString();
          this.ucNhietAP.GiaTri_Xung = this._ro.XUNG_TEMP_AP.ToString();
          this.ucNhietTL.GiaTri_Xung = this._ro.XUNG_TEMP_TL.ToString();
          this.ucCanFD.GiaTri_KLThucTe = this._ro.KLT_FD1.ToString();
          this.ucCanAG.GiaTri_KLThucTe = this._ro.KLT_AG1.ToString();
          this.ucCanAP.GiaTri_KLThucTe = this._ro.KLT_AP1.ToString();
          this.ucCanSB.GiaTri_KLThucTe = this._ro.KLT_SB1.ToString();
          this.ucNhietTS.GiaTri_KLThucTe = this._ro.NDT_TS.ToString();
          this.ucNhietAG.GiaTri_KLThucTe = this._ro.NDT_AG.ToString();
          this.ucNhietAP.GiaTri_KLThucTe = this._ro.NDT_AP.ToString();
          this.ucNhietTL.GiaTri_KLThucTe = this._ro.NDT_TL.ToString();
        }
      }
      catch (ThreadAbortException ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void FrmChinhCan_Load(object sender, EventArgs e)
    {
      this.timer1.Interval = 100;
      this.timer1.Start();
    }

    private void LoadDataSaved()
    {
      this.ucCanFD.GiaTri_Nhap0 = ConfigManager.TramTronConfig.KL_ZERO_CEM1;
      this.ucCanFD.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.Para01;
      this.ucCanFD.GiaTri_NhapTai = ConfigManager.TramTronConfig.KL_SPAN_CEM1;
      this.ucCanAG.GiaTri_Nhap0 = ConfigManager.TramTronConfig.KL_ZERO_AGG1;
      this.ucCanAG.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.Para02;
      this.ucCanAG.GiaTri_NhapTai = ConfigManager.TramTronConfig.KL_SPAN_AGG1;
      this.ucCanAP.GiaTri_Nhap0 = ConfigManager.TramTronConfig.KL_ZERO_WA1;
      this.ucCanAP.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.Para03;
      this.ucCanAP.GiaTri_NhapTai = ConfigManager.TramTronConfig.KL_SPAN_WA1;
      this.ucCanSB.GiaTri_Nhap0 = ConfigManager.TramTronConfig.KL_ZERO_ADD1;
      this.ucCanSB.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.Para04;
      this.ucCanSB.GiaTri_NhapTai = ConfigManager.TramTronConfig.KL_SPAN_ADD1;
      this.ucNhietTS.GiaTri_NhapT1 = ConfigManager.TramTronConfig.KL_ZERO_AGG2;
      this.ucNhietTS.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.Para05;
      this.ucNhietTS.GiaTri_NhapT2 = ConfigManager.TramTronConfig.KL_SPAN_AGG2;
      this.ucNhietAG.GiaTri_NhapT1 = ConfigManager.TramTronConfig.KL_ZERO_AGG3;
      this.ucNhietAG.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.Para06;
      this.ucNhietAG.GiaTri_NhapT2 = ConfigManager.TramTronConfig.KL_SPAN_AGG3;
      this.ucNhietAP.GiaTri_NhapT1 = ConfigManager.TramTronConfig.KL_ZERO_AGG4;
      this.ucNhietAP.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.Para07;
      this.ucNhietAP.GiaTri_NhapT2 = ConfigManager.TramTronConfig.KL_SPAN_AGG4;
      this.ucNhietTL.GiaTri_NhapT1 = ConfigManager.TramTronConfig.KL_ZERO_AGG5;
      this.ucNhietTL.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.Para08;
      this.ucNhietTL.GiaTri_NhapT2 = ConfigManager.TramTronConfig.KL_SPAN_AGG5;
    }

    private void ucCanFD_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.KL_ZERO_FD1 = double.Parse(this.ucCanFD.GiaTri_Nhap0);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_ZERO_CEM1 = this.ucCanFD.GiaTri_Nhap0;
    }

    private void ucCanFD_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.HS_FD1 = double.Parse(this.ucCanFD.GiaTri_NhapHeSo);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.Para01 = this.ucCanFD.GiaTri_NhapHeSo;
    }

    private void ucCanFD_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.KL_SPAN_FD1 = double.Parse(this.ucCanFD.GiaTri_NhapTai);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_SPAN_CEM1 = this.ucCanFD.GiaTri_NhapTai;
    }

    private void ucCanFD_ButtonChinh0_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_FD1 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanFD_ButtonChinh0_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_FD1 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanFD_ButtonChinhTai_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_FD1 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanFD_ButtonChinhTai_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_FD1 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanAG_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.KL_ZERO_AG1 = double.Parse(this.ucCanAG.GiaTri_Nhap0);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_ZERO_AGG1 = this.ucCanAG.GiaTri_Nhap0;
    }

    private void ucCanAG_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.HS_AG1 = double.Parse(this.ucCanAG.GiaTri_NhapHeSo);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.Para02 = this.ucCanAG.GiaTri_NhapHeSo;
    }

    private void ucCanAG_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.KL_SPAN_AG1 = double.Parse(this.ucCanAG.GiaTri_NhapTai);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_SPAN_AGG1 = this.ucCanAG.GiaTri_NhapTai;
    }

    private void ucCanAG_ButtonChinh0_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_AG1 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanAG_ButtonChinh0_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_AG1 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanAG_ButtonChinhTai_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_AG1 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanAG_ButtonChinhTai_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_AG1 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanAP_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.KL_ZERO_AP1 = double.Parse(this.ucCanAP.GiaTri_Nhap0);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_ZERO_WA1 = this.ucCanAP.GiaTri_Nhap0;
    }

    private void ucCanAP_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.HS_AP1 = double.Parse(this.ucCanAP.GiaTri_NhapHeSo);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.Para03 = this.ucCanAP.GiaTri_NhapHeSo;
    }

    private void ucCanAP_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.KL_SPAN_AP1 = double.Parse(this.ucCanAP.GiaTri_NhapTai);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_SPAN_WA1 = this.ucCanAP.GiaTri_NhapTai;
    }

    private void ucCanAP_ButtonChinh0_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_AP1 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanAP_ButtonChinh0_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_AP1 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanAP_ButtonChinhTai_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_AP1 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanAP_ButtonChinhTai_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_AP1 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanSB_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.KL_ZERO_SB1 = double.Parse(this.ucCanSB.GiaTri_Nhap0);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_ZERO_ADD1 = this.ucCanSB.GiaTri_Nhap0;
    }

    private void ucCanSB_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.HS_SB1 = double.Parse(this.ucCanSB.GiaTri_NhapHeSo);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.Para04 = this.ucCanSB.GiaTri_NhapHeSo;
    }

    private void ucCanSB_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.KL_SPAN_SB1 = double.Parse(this.ucCanSB.GiaTri_NhapTai);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_SPAN_ADD1 = this.ucCanSB.GiaTri_NhapTai;
    }

    private void ucCanSB_ButtonChinh0_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_SB1 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanSB_ButtonChinh0_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_SB1 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanSB_ButtonChinhTai_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_SB1 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucCanSB_ButtonChinhTai_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_SB1 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietTS_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.ZERO_TEMP_TS = double.Parse(this.ucNhietTS.GiaTri_NhapT1);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_ZERO_AGG2 = this.ucNhietTS.GiaTri_NhapT1;
    }

    private void ucNhietTS_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.HS_TEMP1 = double.Parse(this.ucNhietTS.GiaTri_NhapHeSo);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.Para05 = this.ucNhietTS.GiaTri_NhapHeSo;
    }

    private void ucNhietTS_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.SPAN_TEMP_TS = double.Parse(this.ucNhietTS.GiaTri_NhapT2);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_SPAN_AGG2 = this.ucNhietTS.GiaTri_NhapT2;
    }

    private void ucNhietTS_ButtonChinhT1_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_TEMP_1 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietTS_ButtonChinhT1_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_TEMP_1 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietTS_ButtonChinhT2_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_TEMP_1 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietTS_ButtonChinhT2_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_TEMP_1 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietAG_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.ZERO_TEMP_AG = double.Parse(this.ucNhietAG.GiaTri_NhapT1);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_ZERO_AGG3 = this.ucNhietAG.GiaTri_NhapT1;
    }

    private void ucNhietAG_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.HS_TEMP2 = double.Parse(this.ucNhietAG.GiaTri_NhapHeSo);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.Para06 = this.ucNhietAG.GiaTri_NhapHeSo;
    }

    private void ucNhietAG_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.SPAN_TEMP_AG = double.Parse(this.ucNhietAG.GiaTri_NhapT2);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_SPAN_AGG3 = this.ucNhietAG.GiaTri_NhapT2;
    }

    private void ucNhietAG_ButtonChinhT1_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_TEMP_2 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietAG_ButtonChinhT1_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_TEMP_2 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietAG_ButtonChinhT2_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_TEMP_2 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietAG_ButtonChinhT2_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_TEMP_2 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietAP_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.ZERO_TEMP_AP = double.Parse(this.ucNhietAP.GiaTri_NhapT1);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_ZERO_AGG4 = this.ucNhietAP.GiaTri_NhapT1;
    }

    private void ucNhietAP_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.HS_TEMP3 = double.Parse(this.ucNhietAP.GiaTri_NhapHeSo);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.Para07 = this.ucNhietAP.GiaTri_NhapHeSo;
    }

    private void ucNhietAP_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.SPAN_TEMP_AP = double.Parse(this.ucNhietAP.GiaTri_NhapT2);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_SPAN_AGG4 = this.ucNhietAP.GiaTri_NhapT2;
    }

    private void ucNhietAP_ButtonChinhT1_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_TEMP_3 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietAP_ButtonChinhT1_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_TEMP_3 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietAP_ButtonChinhT2_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_TEMP_3 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietAP_ButtonChinhT2_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_TEMP_3 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietTL_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.ZERO_TEMP_TL = double.Parse(this.ucNhietTL.GiaTri_NhapT1);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_ZERO_AGG5 = this.ucNhietTL.GiaTri_NhapT1;
    }

    private void ucNhietTL_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.HS_TEMP4 = double.Parse(this.ucNhietTL.GiaTri_NhapHeSo);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.Para08 = this.ucNhietTL.GiaTri_NhapHeSo;
    }

    private void ucNhietTL_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      this._sp_NotHD.SPAN_TEMP_TL = double.Parse(this.ucNhietTL.GiaTri_NhapT2);
      this.SendData_DB_6_NewTread();
      ConfigManager.TramTronConfig.KL_SPAN_AGG5 = this.ucNhietTL.GiaTri_NhapT2;
    }

    private void ucNhietTL_ButtonChinhT1_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_TEMP_4 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietTL_ButtonChinhT1_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_TEMP_4 = false;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietTL_ButtonChinhT2_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_TEMP_4 = true;
      this.SendData_DB_2_NewTread();
    }

    private void ucNhietTL_ButtonChinhT2_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_TEMP_4 = false;
      this.SendData_DB_2_NewTread();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.ucCanFD = new ucNhomChinhCan();
      this.ucCanAG = new ucNhomChinhCan();
      this.ucCanAP = new ucNhomChinhCan();
      this.ucCanSB = new ucNhomChinhCan();
      this.ucNhietTS = new ucNhomChinhNhietDo();
      this.ucNhietAG = new ucNhomChinhNhietDo();
      this.ucNhietAP = new ucNhomChinhNhietDo();
      this.ucNhietTL = new ucNhomChinhNhietDo();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      this.ucCanFD.GiaTri_KLThucTe = "1";
      this.ucCanFD.GiaTri_Nhap0 = "1";
      this.ucCanFD.GiaTri_NhapHeSo = "1";
      this.ucCanFD.GiaTri_NhapTai = "1";
      this.ucCanFD.GiaTri_Xung = "1";
      this.ucCanFD.Location = new Point(12, 12);
      this.ucCanFD.Name = "ucCanFD";
      this.ucCanFD.NameGroup = "Khối lượng FD";
      this.ucCanFD.Size = new Size(370, 196);
      this.ucCanFD.TabIndex = 0;
      this.ucCanFD.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinh0_Down);
      this.ucCanFD.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinh0_Up);
      this.ucCanFD.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinhTai_Down);
      this.ucCanFD.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinhTai_Up);
      this.ucCanFD.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanFD_Enter_Down_Nhap0);
      this.ucCanFD.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanFD_Enter_Down_NhapTai);
      this.ucCanFD.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanFD_Enter_Down_NhapHeSo);
      this.ucCanAG.GiaTri_KLThucTe = "1";
      this.ucCanAG.GiaTri_Nhap0 = "1";
      this.ucCanAG.GiaTri_NhapHeSo = "1";
      this.ucCanAG.GiaTri_NhapTai = "1";
      this.ucCanAG.GiaTri_Xung = "1";
      this.ucCanAG.Location = new Point(12, 214);
      this.ucCanAG.Name = "ucCanAG";
      this.ucCanAG.NameGroup = "Khối lượng AGG";
      this.ucCanAG.Size = new Size(370, 196);
      this.ucCanAG.TabIndex = 1;
      this.ucCanAG.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinh0_Down);
      this.ucCanAG.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinh0_Up);
      this.ucCanAG.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinhTai_Down);
      this.ucCanAG.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinhTai_Up);
      this.ucCanAG.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_Nhap0);
      this.ucCanAG.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_NhapTai);
      this.ucCanAG.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_NhapHeSo);
      this.ucCanAP.GiaTri_KLThucTe = "1";
      this.ucCanAP.GiaTri_Nhap0 = "1";
      this.ucCanAP.GiaTri_NhapHeSo = "1";
      this.ucCanAP.GiaTri_NhapTai = "1";
      this.ucCanAP.GiaTri_Xung = "1";
      this.ucCanAP.Location = new Point(12, 416);
      this.ucCanAP.Name = "ucCanAP";
      this.ucCanAP.NameGroup = "Khối lượng AP";
      this.ucCanAP.Size = new Size(370, 196);
      this.ucCanAP.TabIndex = 2;
      this.ucCanAP.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinh0_Down);
      this.ucCanAP.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinh0_Up);
      this.ucCanAP.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinhTai_Down);
      this.ucCanAP.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinhTai_Up);
      this.ucCanAP.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanAP_Enter_Down_Nhap0);
      this.ucCanAP.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanAP_Enter_Down_NhapTai);
      this.ucCanAP.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanAP_Enter_Down_NhapHeSo);
      this.ucCanSB.GiaTri_KLThucTe = "1";
      this.ucCanSB.GiaTri_Nhap0 = "1";
      this.ucCanSB.GiaTri_NhapHeSo = "1";
      this.ucCanSB.GiaTri_NhapTai = "1";
      this.ucCanSB.GiaTri_Xung = "1";
      this.ucCanSB.Location = new Point(12, 618);
      this.ucCanSB.Name = "ucCanSB";
      this.ucCanSB.NameGroup = "Khối lượng SB";
      this.ucCanSB.Size = new Size(370, 196);
      this.ucCanSB.TabIndex = 3;
      this.ucCanSB.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinh0_Down);
      this.ucCanSB.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinh0_Up);
      this.ucCanSB.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinhTai_Down);
      this.ucCanSB.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinhTai_Up);
      this.ucCanSB.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanSB_Enter_Down_Nhap0);
      this.ucCanSB.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanSB_Enter_Down_NhapTai);
      this.ucCanSB.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanSB_Enter_Down_NhapHeSo);
      this.ucNhietTS.GiaTri_KLThucTe = (string) null;
      this.ucNhietTS.GiaTri_NhapHeSo = "";
      this.ucNhietTS.GiaTri_NhapT1 = (string) null;
      this.ucNhietTS.GiaTri_NhapT2 = (string) null;
      this.ucNhietTS.GiaTri_Xung = "";
      this.ucNhietTS.Location = new Point(413, 12);
      this.ucNhietTS.Name = "ucNhietTS";
      this.ucNhietTS.NameGroup = "Nhiệt độ Tan sấy";
      this.ucNhietTS.Size = new Size(370, 196);
      this.ucNhietTS.TabIndex = 4;
      this.ucNhietTS.ButtonChinhT1_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT1_Down);
      this.ucNhietTS.ButtonChinhT1_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT1_Up);
      this.ucNhietTS.ButtonChinhT2_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT2_Down);
      this.ucNhietTS.ButtonChinhT2_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT2_Up);
      this.ucNhietTS.Enter_Down_Nhap0 += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTS_Enter_Down_Nhap0);
      this.ucNhietTS.Enter_Down_NhapTai += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTS_Enter_Down_NhapTai);
      this.ucNhietTS.Enter_Down_NhapHeSo += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTS_Enter_Down_NhapHeSo);
      this.ucNhietAG.GiaTri_KLThucTe = (string) null;
      this.ucNhietAG.GiaTri_NhapHeSo = "";
      this.ucNhietAG.GiaTri_NhapT1 = (string) null;
      this.ucNhietAG.GiaTri_NhapT2 = (string) null;
      this.ucNhietAG.GiaTri_Xung = "";
      this.ucNhietAG.Location = new Point(409, 214);
      this.ucNhietAG.Name = "ucNhietAG";
      this.ucNhietAG.NameGroup = "Nhiệt độ AG";
      this.ucNhietAG.Size = new Size(370, 196);
      this.ucNhietAG.TabIndex = 5;
      this.ucNhietAG.ButtonChinhT1_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT1_Down);
      this.ucNhietAG.ButtonChinhT1_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT1_Up);
      this.ucNhietAG.ButtonChinhT2_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT2_Down);
      this.ucNhietAG.ButtonChinhT2_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT2_Up);
      this.ucNhietAG.Enter_Down_Nhap0 += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAG_Enter_Down_Nhap0);
      this.ucNhietAG.Enter_Down_NhapTai += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAG_Enter_Down_NhapTai);
      this.ucNhietAG.Enter_Down_NhapHeSo += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAG_Enter_Down_NhapHeSo);
      this.ucNhietAP.GiaTri_KLThucTe = (string) null;
      this.ucNhietAP.GiaTri_NhapHeSo = "";
      this.ucNhietAP.GiaTri_NhapT1 = (string) null;
      this.ucNhietAP.GiaTri_NhapT2 = (string) null;
      this.ucNhietAP.GiaTri_Xung = "";
      this.ucNhietAP.Location = new Point(409, 416);
      this.ucNhietAP.Name = "ucNhietAP";
      this.ucNhietAP.NameGroup = "Nhiệt độ Nhựa";
      this.ucNhietAP.Size = new Size(370, 196);
      this.ucNhietAP.TabIndex = 6;
      this.ucNhietAP.ButtonChinhT1_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT1_Down);
      this.ucNhietAP.ButtonChinhT1_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT1_Up);
      this.ucNhietAP.ButtonChinhT2_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT2_Down);
      this.ucNhietAP.ButtonChinhT2_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT2_Up);
      this.ucNhietAP.Enter_Down_Nhap0 += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAP_Enter_Down_Nhap0);
      this.ucNhietAP.Enter_Down_NhapTai += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAP_Enter_Down_NhapTai);
      this.ucNhietAP.Enter_Down_NhapHeSo += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAP_Enter_Down_NhapHeSo);
      this.ucNhietTL.GiaTri_KLThucTe = (string) null;
      this.ucNhietTL.GiaTri_NhapHeSo = "";
      this.ucNhietTL.GiaTri_NhapT1 = (string) null;
      this.ucNhietTL.GiaTri_NhapT2 = (string) null;
      this.ucNhietTL.GiaTri_Xung = "";
      this.ucNhietTL.Location = new Point(409, 618);
      this.ucNhietTL.Name = "ucNhietTL";
      this.ucNhietTL.NameGroup = "Nhiệt độ Túi lọc";
      this.ucNhietTL.Size = new Size(370, 196);
      this.ucNhietTL.TabIndex = 7;
      this.ucNhietTL.ButtonChinhT1_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT1_Down);
      this.ucNhietTL.ButtonChinhT1_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT1_Up);
      this.ucNhietTL.ButtonChinhT2_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT2_Down);
      this.ucNhietTL.ButtonChinhT2_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT2_Up);
      this.ucNhietTL.Enter_Down_Nhap0 += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTL_Enter_Down_Nhap0);
      this.ucNhietTL.Enter_Down_NhapTai += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTL_Enter_Down_NhapTai);
      this.ucNhietTL.Enter_Down_NhapHeSo += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTL_Enter_Down_NhapHeSo);
      this.timer1.Enabled = true;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(791, 818);
      this.Controls.Add((Control) this.ucNhietTL);
      this.Controls.Add((Control) this.ucNhietAP);
      this.Controls.Add((Control) this.ucNhietAG);
      this.Controls.Add((Control) this.ucNhietTS);
      this.Controls.Add((Control) this.ucCanSB);
      this.Controls.Add((Control) this.ucCanAP);
      this.Controls.Add((Control) this.ucCanAG);
      this.Controls.Add((Control) this.ucCanFD);
      this.IconOptions.Image = (Image) ResourceNhua.logoV_64;
      this.Name = nameof (FrmChinhCan);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Chỉnh cân";
      this.Load += new EventHandler(this.FrmChinhCan_Load);
      this.ResumeLayout(false);
    }
  }
}
