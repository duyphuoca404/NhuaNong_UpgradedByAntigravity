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
using System.Threading.Tasks;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class FrmChinhCan : DialogViewBase, IFrmKiemDinhCan, IBase
  {
    private SendingToPLC _so = new SendingToPLC();
    private ReceivingFromPLC _ro = new ReceivingFromPLC();
    private PLCController _plcController;
    private SetPoint_NotHD _sp_NotHD = new SetPoint_NotHD();
    //private IContainer components;
    //private ucNhomChinhCan ucCanFD;
    //private ucNhomChinhCan ucCanAG;
    //private ucNhomChinhCan ucCanAP;
    //private ucNhomChinhCan ucCanSB;
    //private ucNhomChinhNhietDo ucNhietTS;
    //private ucNhomChinhNhietDo ucNhietAG;
    //private ucNhomChinhNhietDo ucNhietAP;
    //private ucNhomChinhNhietDo ucNhietTL;
    //private System.Windows.Forms.Timer timer1;

    public FrmChinhCan()
    {
      this.InitializeComponent();
      this.Name = nameof(FrmChinhCan);
      this.InitializeIndependentEvents();
    }

    private void InitializeIndependentEvents()
    {
      // Subscribe ModeChanged events for main hoppers
      this.ucCanFD.ModeChanged += (s, isManual) => { this._so.SendingCommand.HMI_Manual_Trigger_FD1 = isManual; this.SendData_DB_2_NewTread(); };
      this.ucCanAG.ModeChanged += (s, isManual) => { this._so.SendingCommand.HMI_Manual_Trigger_AGG = isManual; this.SendData_DB_2_NewTread(); };
      this.ucCanAP.ModeChanged += (s, isManual) => { this._so.SendingCommand.HMI_Manual_Trigger_AP = isManual; this.SendData_DB_2_NewTread(); };
      this.ucCanSB.ModeChanged += (s, isManual) => { this._so.SendingCommand.HMI_Manual_Trigger_SB = isManual; this.SendData_DB_2_NewTread(); };

      if (this.ucCanAG2 != null)
      {
        this.ucCanAG2.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG2_ButtonChinh0_Down);
        this.ucCanAG2.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG2_ButtonChinh0_Up);
        this.ucCanAG2.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG2_ButtonChinhTai_Down);
        this.ucCanAG2.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG2_ButtonChinhTai_Up);
        this.ucCanAG2.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanAG2_Enter_Down_Nhap0);
        this.ucCanAG2.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanAG2_Enter_Down_NhapTai);
        this.ucCanAG2.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanAG2_Enter_Down_NhapHeSo);
        this.ucCanAG2.ModeChanged += (s, isManual) => { this._so.SendingCommand.HMI_Manual_Trigger_IND_AGG2 = isManual; this.SendData_DB_2_NewTread(); };
      }
      if (this.ucCanAG3 != null)
      {
        this.ucCanAG3.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG3_ButtonChinh0_Down);
        this.ucCanAG3.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG3_ButtonChinh0_Up);
        this.ucCanAG3.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG3_ButtonChinhTai_Down);
        this.ucCanAG3.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG3_ButtonChinhTai_Up);
        this.ucCanAG3.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanAG3_Enter_Down_Nhap0);
        this.ucCanAG3.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanAG3_Enter_Down_NhapTai);
        this.ucCanAG3.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanAG3_Enter_Down_NhapHeSo);
        this.ucCanAG3.ModeChanged += (s, isManual) => { this._so.SendingCommand.HMI_Manual_Trigger_IND_AGG3 = isManual; this.SendData_DB_2_NewTread(); };
      }
      if (this.ucCanAG4 != null)
      {
        this.ucCanAG4.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG4_ButtonChinh0_Down);
        this.ucCanAG4.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG4_ButtonChinh0_Up);
        this.ucCanAG4.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG4_ButtonChinhTai_Down);
        this.ucCanAG4.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG4_ButtonChinhTai_Up);
        this.ucCanAG4.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanAG4_Enter_Down_Nhap0);
        this.ucCanAG4.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanAG4_Enter_Down_NhapTai);
        this.ucCanAG4.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanAG4_Enter_Down_NhapHeSo);
        this.ucCanAG4.ModeChanged += (s, isManual) => { this._so.SendingCommand.HMI_Manual_Trigger_IND_AGG4 = isManual; this.SendData_DB_2_NewTread(); };
      }
      if (this.ucCanAG5 != null)
      {
        this.ucCanAG5.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG5_ButtonChinh0_Down);
        this.ucCanAG5.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG5_ButtonChinh0_Up);
        this.ucCanAG5.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG5_ButtonChinhTai_Down);
        this.ucCanAG5.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG5_ButtonChinhTai_Up);
        this.ucCanAG5.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanAG5_Enter_Down_Nhap0);
        this.ucCanAG5.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanAG5_Enter_Down_NhapTai);
        this.ucCanAG5.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanAG5_Enter_Down_NhapHeSo);
        this.ucCanAG5.ModeChanged += (s, isManual) => { this._so.SendingCommand.HMI_Manual_Trigger_IND_AGG5 = isManual; this.SendData_DB_2_NewTread(); };
      }
      // Subscribe for ucCanAG (AGG1 in independent mode)
      this.ucCanAG.ModeChanged += (s, isManual) => {
        if (ConfigManager.TramTronConfig.WeighModeIndependent)
        {
          this._so.SendingCommand.HMI_Manual_Trigger_IND_AGG1 = isManual;
          this.SendData_DB_2_NewTread();
        }
      };
    }

    private void SendData_DB_6_Independent_NewThread()
    {
      new Thread(new ThreadStart(this.Send_Data_DB_6_Independent_To_PLC)).Start();
    }
    private double ConvertData(uint data)
    {
      double num1 = (double) data.ConvertToFloat();
      double num2;
      return num1 > 32000.0 || num1 < -32000.0 ? (num2 = 0.0) : num1;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (this._plcController == null || !this._plcController.IsConnected)
        return;
      
      try
      {
        byte[] data = this._plcController.ReadBytes(S7.Net.DataType.DataBlock, 6, 0, 2100);
        
        // Kiểm tra dữ liệu hợp lệ trước khi xử lý
        if (data == null || data.Length < 160)
          return;
        
        this.ReceiveData_DB6(data);
        this.BindReceivingOnline(this._ro);
      }
      catch (Exception)
      {
        // Bỏ qua lỗi truyền thông PLC, timer sẽ thử lại lần sau
      }
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
        // Write Bytes 14 and 15 for Independent Calibration Commands (Offsets 14, 15)
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 2, 14, new List<byte>()
        {
          this._so.Byte_14,
          this._so.Byte_15
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

    private void Send_Data_DB_6_Independent_To_PLC()
    {
      if (this._plcController == null)
      {
        int num = (int) MessageBox.Show("PLC MẤT KẾT NỐI");
      }
      else
      {
        // Independent Aggregates Calibration Data (Offsets from XML)
        // AGG1
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1296, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_ZERO_IND_AGG1).ToArray());
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1328, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_SPAN_IND_AGG1).ToArray());
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1360, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_IND_AGG1).ToArray());

        // AGG2
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1456, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_ZERO_IND_AGG2).ToArray());
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1488, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_SPAN_IND_AGG2).ToArray());
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1520, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_IND_AGG2).ToArray());

        // AGG3
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1616, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_ZERO_IND_AGG3).ToArray());
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1648, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_SPAN_IND_AGG3).ToArray());
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1680, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_IND_AGG3).ToArray());

        // AGG4
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1776, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_ZERO_IND_AGG4).ToArray());
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1808, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_SPAN_IND_AGG4).ToArray());
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1840, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_IND_AGG4).ToArray());

        // AGG5
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1936, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_ZERO_IND_AGG5).ToArray());
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 1968, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.KL_SPAN_IND_AGG5).ToArray());
        this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 6, 2000, MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HS_IND_AGG5).ToArray());
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

      // Independent Weighing Variables Mapping (Offsets from XML)
      // Chỉ đọc nếu mảng đủ lớn (PLC DB6 đã được mở rộng)
      if (a.Length >= 2068)
      {
        // AGG1
        this._ro.KL_ZERO_IND_AGG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1296], a[1297], a[1298], a[1299]));
        this._ro.KL_SPAN_IND_AGG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1328], a[1329], a[1330], a[1331]));
        this._ro.HS_IND_AGG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1360], a[1361], a[1362], a[1363]));
        this._ro.XUNG_IND_AGG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1392], a[1393], a[1394], a[1395]));
        this._ro.KLT_IND_AGG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1424], a[1425], a[1426], a[1427]));

        // AGG2
        this._ro.KL_ZERO_IND_AGG2 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1456], a[1457], a[1458], a[1459]));
        this._ro.KL_SPAN_IND_AGG2 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1488], a[1489], a[1490], a[1491]));
        this._ro.HS_IND_AGG2 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1520], a[1521], a[1522], a[1523]));
        this._ro.XUNG_IND_AGG2 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1552], a[1553], a[1554], a[1555]));
        this._ro.KLT_IND_AGG2 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1584], a[1585], a[1586], a[1587]));

        // AGG3
        this._ro.KL_ZERO_IND_AGG3 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1616], a[1617], a[1618], a[1619]));
        this._ro.KL_SPAN_IND_AGG3 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1648], a[1649], a[1650], a[1651]));
        this._ro.HS_IND_AGG3 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1680], a[1681], a[1682], a[1683]));
        this._ro.XUNG_IND_AGG3 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1712], a[1713], a[1714], a[1715]));
        this._ro.KLT_IND_AGG3 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1744], a[1745], a[1746], a[1747]));

        // AGG4
        this._ro.KL_ZERO_IND_AGG4 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1776], a[1777], a[1778], a[1779]));
        this._ro.KL_SPAN_IND_AGG4 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1808], a[1809], a[1810], a[1811]));
        this._ro.HS_IND_AGG4 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1840], a[1841], a[1842], a[1843]));
        this._ro.XUNG_IND_AGG4 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1872], a[1873], a[1874], a[1875]));
        this._ro.KLT_IND_AGG4 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1904], a[1905], a[1906], a[1907]));

        // AGG5
        this._ro.KL_ZERO_IND_AGG5 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1936], a[1937], a[1938], a[1939]));
        this._ro.KL_SPAN_IND_AGG5 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[1968], a[1969], a[1970], a[1971]));
        this._ro.HS_IND_AGG5 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[2000], a[2001], a[2002], a[2003]));
        this._ro.XUNG_IND_AGG5 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[2032], a[2033], a[2034], a[2035]));
        this._ro.KLT_IND_AGG5 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[2064], a[2065], a[2066], a[2067]));
      }
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

          if (this.ucCanAG2 != null && this.ucCanAG2.Visible)
          {
              this.ucCanAG2.GiaTri_Xung = this._ro.XUNG_IND_AGG2.ToString();
              this.ucCanAG2.GiaTri_KLThucTe = this._ro.KLT_IND_AGG2.ToString();
          }
          if (this.ucCanAG3 != null && this.ucCanAG3.Visible)
          {
              this.ucCanAG3.GiaTri_Xung = this._ro.XUNG_IND_AGG3.ToString();
              this.ucCanAG3.GiaTri_KLThucTe = this._ro.KLT_IND_AGG3.ToString();
          }
          if (this.ucCanAG4 != null && this.ucCanAG4.Visible)
          {
              this.ucCanAG4.GiaTri_Xung = this._ro.XUNG_IND_AGG4.ToString();
              this.ucCanAG4.GiaTri_KLThucTe = this._ro.KLT_IND_AGG4.ToString();
          }
          if (this.ucCanAG5 != null && this.ucCanAG5.Visible)
          {
              this.ucCanAG5.GiaTri_Xung = this._ro.XUNG_IND_AGG5.ToString();
              this.ucCanAG5.GiaTri_KLThucTe = this._ro.KLT_IND_AGG5.ToString();
          }
          // Note: AG1 is handled by ucCanAG (Standard/Combined mode) OR ucCanAG1 (Independent)?
          // In combined mode, ucCanAG displays AG1 logic.
          // In Independent mode, we reuse ucCanAG for AG1 or hide it?
          // Plan: Reuse ucCanAG for AG1. It's mapped to XUNG_AG1 (Combined).
          // But Independent AG1 is at 1392 (XUNG_IND_AGG1).
          // If we reuse ucCanAG, we might need to point it to XUNG_IND_AGG1 if Independent mode is ON.
          if (ConfigManager.TramTronConfig.WeighModeIndependent)
          {
              this.ucCanAG.GiaTri_Xung = this._ro.XUNG_IND_AGG1.ToString();
              this.ucCanAG.GiaTri_KLThucTe = this._ro.KLT_IND_AGG1.ToString();
          }
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
      Task.Run(() => {
          this._plcController = new PLCController();
      });
      // Visibility Logic
      bool isIndependent = ConfigManager.TramTronConfig.WeighModeIndependent;
      if (this.ucCanAG2 != null) this.ucCanAG2.Visible = isIndependent;
      if (this.ucCanAG3 != null) this.ucCanAG3.Visible = isIndependent;
      if (this.ucCanAG4 != null) this.ucCanAG4.Visible = isIndependent;
      if (this.ucCanAG5 != null) this.ucCanAG5.Visible = isIndependent;

      if (isIndependent)
      {
          if (this.ucCanAG != null) this.ucCanAG.NameGroup = "Cốt Liệu 1";
          // Keep original size for Independent mode (no change needed)
      }
      else
      {
          if (this.ucCanAG != null) this.ucCanAG.NameGroup = "Cốt Liệu Tổng";
          // Cumulative mode: Use tabPheuCanKhac as reference (largest non-independent tab)
          // tabPheuCanKhac has 3 UCs: FD(12,12), AP(400,12), SB(12,214) => max Y = 214+196 = 410
          // No size change needed - let XtraTabControl manage sizing
      }
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

      if (ConfigManager.TramTronConfig.WeighModeIndependent)
      {
          // Load Independent Config
          this.ucCanAG.GiaTri_Nhap0 = ConfigManager.TramTronConfig.KL_ZERO_IND_AGG1;
          this.ucCanAG.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.HS_IND_AGG1;
          this.ucCanAG.GiaTri_NhapTai = ConfigManager.TramTronConfig.KL_SPAN_IND_AGG1;

          if (this.ucCanAG2 != null)
          {
              this.ucCanAG2.GiaTri_Nhap0 = ConfigManager.TramTronConfig.KL_ZERO_IND_AGG2;
              this.ucCanAG2.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.HS_IND_AGG2;
              this.ucCanAG2.GiaTri_NhapTai = ConfigManager.TramTronConfig.KL_SPAN_IND_AGG2;
          }
          if (this.ucCanAG3 != null)
          {
              this.ucCanAG3.GiaTri_Nhap0 = ConfigManager.TramTronConfig.KL_ZERO_IND_AGG3;
              this.ucCanAG3.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.HS_IND_AGG3;
              this.ucCanAG3.GiaTri_NhapTai = ConfigManager.TramTronConfig.KL_SPAN_IND_AGG3;
          }
          if (this.ucCanAG4 != null)
          {
              this.ucCanAG4.GiaTri_Nhap0 = ConfigManager.TramTronConfig.KL_ZERO_IND_AGG4;
              this.ucCanAG4.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.HS_IND_AGG4;
              this.ucCanAG4.GiaTri_NhapTai = ConfigManager.TramTronConfig.KL_SPAN_IND_AGG4;
          }
          if (this.ucCanAG5 != null)
          {
              this.ucCanAG5.GiaTri_Nhap0 = ConfigManager.TramTronConfig.KL_ZERO_IND_AGG5;
              this.ucCanAG5.GiaTri_NhapHeSo = ConfigManager.TramTronConfig.HS_IND_AGG5;
              this.ucCanAG5.GiaTri_NhapTai = ConfigManager.TramTronConfig.KL_SPAN_IND_AGG5;
          }
      }
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

    // --- Independent Weighing Event Handlers ---

    // AG2
    private void ucCanAG2_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.KL_ZERO_IND_AGG2 = double.Parse(this.ucCanAG2.GiaTri_Nhap0);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.KL_ZERO_IND_AGG2 = this.ucCanAG2.GiaTri_Nhap0;
    }
    private void ucCanAG2_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.HS_IND_AGG2 = double.Parse(this.ucCanAG2.GiaTri_NhapHeSo);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.HS_IND_AGG2 = this.ucCanAG2.GiaTri_NhapHeSo;
    }
    private void ucCanAG2_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.KL_SPAN_IND_AGG2 = double.Parse(this.ucCanAG2.GiaTri_NhapTai);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.KL_SPAN_IND_AGG2 = this.ucCanAG2.GiaTri_NhapTai;
    }
    private void ucCanAG2_ButtonChinh0_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_IND_AGG2 = true;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG2_ButtonChinh0_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_IND_AGG2 = false;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG2_ButtonChinhTai_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_IND_AGG2 = true;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG2_ButtonChinhTai_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_IND_AGG2 = false;
      this.SendData_DB_2_NewTread();
    }

    // AG3
    private void ucCanAG3_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.KL_ZERO_IND_AGG3 = double.Parse(this.ucCanAG3.GiaTri_Nhap0);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.KL_ZERO_IND_AGG3 = this.ucCanAG3.GiaTri_Nhap0;
    }
    private void ucCanAG3_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.HS_IND_AGG3 = double.Parse(this.ucCanAG3.GiaTri_NhapHeSo);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.HS_IND_AGG3 = this.ucCanAG3.GiaTri_NhapHeSo;
    }
    private void ucCanAG3_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.KL_SPAN_IND_AGG3 = double.Parse(this.ucCanAG3.GiaTri_NhapTai);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.KL_SPAN_IND_AGG3 = this.ucCanAG3.GiaTri_NhapTai;
    }
    private void ucCanAG3_ButtonChinh0_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_IND_AGG3 = true;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG3_ButtonChinh0_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_IND_AGG3 = false;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG3_ButtonChinhTai_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_IND_AGG3 = true;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG3_ButtonChinhTai_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_IND_AGG3 = false;
      this.SendData_DB_2_NewTread();
    }

    // AG4
    private void ucCanAG4_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.KL_ZERO_IND_AGG4 = double.Parse(this.ucCanAG4.GiaTri_Nhap0);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.KL_ZERO_IND_AGG4 = this.ucCanAG4.GiaTri_Nhap0;
    }
    private void ucCanAG4_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.HS_IND_AGG4 = double.Parse(this.ucCanAG4.GiaTri_NhapHeSo);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.HS_IND_AGG4 = this.ucCanAG4.GiaTri_NhapHeSo;
    }
    private void ucCanAG4_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.KL_SPAN_IND_AGG4 = double.Parse(this.ucCanAG4.GiaTri_NhapTai);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.KL_SPAN_IND_AGG4 = this.ucCanAG4.GiaTri_NhapTai;
    }
    private void ucCanAG4_ButtonChinh0_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_IND_AGG4 = true;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG4_ButtonChinh0_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_IND_AGG4 = false;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG4_ButtonChinhTai_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_IND_AGG4 = true;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG4_ButtonChinhTai_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_IND_AGG4 = false;
      this.SendData_DB_2_NewTread();
    }

    // AG5
    private void ucCanAG5_Enter_Down_Nhap0(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.KL_ZERO_IND_AGG5 = double.Parse(this.ucCanAG5.GiaTri_Nhap0);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.KL_ZERO_IND_AGG5 = this.ucCanAG5.GiaTri_Nhap0;
    }
    private void ucCanAG5_Enter_Down_NhapHeSo(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.HS_IND_AGG5 = double.Parse(this.ucCanAG5.GiaTri_NhapHeSo);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.HS_IND_AGG5 = this.ucCanAG5.GiaTri_NhapHeSo;
    }
    private void ucCanAG5_Enter_Down_NhapTai(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return) return;
      this._sp_NotHD.KL_SPAN_IND_AGG5 = double.Parse(this.ucCanAG5.GiaTri_NhapTai);
      this.SendData_DB_6_Independent_NewThread();
      ConfigManager.TramTronConfig.KL_SPAN_IND_AGG5 = this.ucCanAG5.GiaTri_NhapTai;
    }
    private void ucCanAG5_ButtonChinh0_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_IND_AGG5 = true;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG5_ButtonChinh0_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_ZERO_IND_AGG5 = false;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG5_ButtonChinhTai_Down(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_IND_AGG5 = true;
      this.SendData_DB_2_NewTread();
    }
    private void ucCanAG5_ButtonChinhTai_Up(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SPAN_IND_AGG5 = false;
      this.SendData_DB_2_NewTread();
    }

    // Xóa các khai báo này vì đã được khai báo trong file FrmChinhCan.Designer.cs
    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && this.components != null)
    //    this.components.Dispose();
    //  base.Dispose(disposing);
    //}

    //private void InitializeComponent()
    //{
    //  this.components = (IContainer) new System.ComponentModel.Container();
    //  this.ucCanFD = new ucNhomChinhCan();
    //  this.ucCanAG = new ucNhomChinhCan();
    //  this.ucCanAP = new ucNhomChinhCan();
    //  this.ucCanSB = new ucNhomChinhCan();
    //  this.ucNhietTS = new ucNhomChinhNhietDo();
    //  this.ucNhietAG = new ucNhomChinhNhietDo();
    //  this.ucNhietAP = new ucNhomChinhNhietDo();
    //  this.ucNhietTL = new ucNhomChinhNhietDo();
    //  this.timer1 = new System.Windows.Forms.Timer(this.components);
    //  this.SuspendLayout();
    //  this.ucCanFD.GiaTri_KLThucTe = "1";
    //  this.ucCanFD.GiaTri_Nhap0 = "1";
    //  this.ucCanFD.GiaTri_NhapHeSo = "1";
    //  this.ucCanFD.GiaTri_NhapTai = "1";
    //  this.ucCanFD.GiaTri_Xung = "1";
    //  this.ucCanFD.Location = new Point(12, 12);
    //  this.ucCanFD.Name = "ucCanFD";
    //  this.ucCanFD.NameGroup = "Khối lượng FD";
    //  this.ucCanFD.Size = new Size(370, 196);
    //  this.ucCanFD.TabIndex = 0;
    //  this.ucCanFD.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinh0_Down);
    //  this.ucCanFD.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinh0_Up);
    //  this.ucCanFD.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinhTai_Down);
    //  this.ucCanFD.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanFD_ButtonChinhTai_Up);
    //  this.ucCanFD.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanFD_Enter_Down_Nhap0);
    //  this.ucCanFD.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanFD_Enter_Down_NhapTai);
    //  this.ucCanFD.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanFD_Enter_Down_NhapHeSo);
    //  this.ucCanAG.GiaTri_KLThucTe = "1";
    //  this.ucCanAG.GiaTri_Nhap0 = "1";
    //  this.ucCanAG.GiaTri_NhapHeSo = "1";
    //  this.ucCanAG.GiaTri_NhapTai = "1";
    //  this.ucCanAG.GiaTri_Xung = "1";
    //  this.ucCanAG.Location = new Point(12, 214);
    //  this.ucCanAG.Name = "ucCanAG";
    //  this.ucCanAG.NameGroup = "Khối lượng AGG";
    //  this.ucCanAG.Size = new Size(370, 196);
    //  this.ucCanAG.TabIndex = 1;
    //  this.ucCanAG.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinh0_Down);
    //  this.ucCanAG.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinh0_Up);
    //  this.ucCanAG.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinhTai_Down);
    //  this.ucCanAG.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAG_ButtonChinhTai_Up);
    //  this.ucCanAG.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_Nhap0);
    //  this.ucCanAG.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_NhapTai);
    //  this.ucCanAG.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanAG_Enter_Down_NhapHeSo);
    //  this.ucCanAP.GiaTri_KLThucTe = "1";
    //  this.ucCanAP.GiaTri_Nhap0 = "1";
    //  this.ucCanAP.GiaTri_NhapHeSo = "1";
    //  this.ucCanAP.GiaTri_NhapTai = "1";
    //  this.ucCanAP.GiaTri_Xung = "1";
    //  this.ucCanAP.Location = new Point(12, 416);
    //  this.ucCanAP.Name = "ucCanAP";
    //  this.ucCanAP.NameGroup = "Khối lượng AP";
    //  this.ucCanAP.Size = new Size(370, 196);
    //  this.ucCanAP.TabIndex = 2;
    //  this.ucCanAP.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinh0_Down);
    //  this.ucCanAP.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinh0_Up);
    //  this.ucCanAP.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinhTai_Down);
    //  this.ucCanAP.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanAP_ButtonChinhTai_Up);
    //  this.ucCanAP.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanAP_Enter_Down_Nhap0);
    //  this.ucCanAP.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanAP_Enter_Down_NhapTai);
    //  this.ucCanAP.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanAP_Enter_Down_NhapHeSo);
    //  this.ucCanSB.GiaTri_KLThucTe = "1";
    //  this.ucCanSB.GiaTri_Nhap0 = "1";
    //  this.ucCanSB.GiaTri_NhapHeSo = "1";
    //  this.ucCanSB.GiaTri_NhapTai = "1";
    //  this.ucCanSB.GiaTri_Xung = "1";
    //  this.ucCanSB.Location = new Point(12, 618);
    //  this.ucCanSB.Name = "ucCanSB";
    //  this.ucCanSB.NameGroup = "Khối lượng SB";
    //  this.ucCanSB.Size = new Size(370, 196);
    //  this.ucCanSB.TabIndex = 3;
    //  this.ucCanSB.ButtonChinh0_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinh0_Down);
    //  this.ucCanSB.ButtonChinh0_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinh0_Up);
    //  this.ucCanSB.ButtonChinhTai_Down += new ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinhTai_Down);
    //  this.ucCanSB.ButtonChinhTai_Up += new ucNhomChinhCan.ButtonEventHandler(this.ucCanSB_ButtonChinhTai_Up);
    //  this.ucCanSB.Enter_Down_Nhap0 += new ucNhomChinhCan.EnterKey(this.ucCanSB_Enter_Down_Nhap0);
    //  this.ucCanSB.Enter_Down_NhapTai += new ucNhomChinhCan.EnterKey(this.ucCanSB_Enter_Down_NhapTai);
    //  this.ucCanSB.Enter_Down_NhapHeSo += new ucNhomChinhCan.EnterKey(this.ucCanSB_Enter_Down_NhapHeSo);
    //  this.ucNhietTS.GiaTri_KLThucTe = (string) null;
    //  this.ucNhietTS.GiaTri_NhapHeSo = "";
    //  this.ucNhietTS.GiaTri_NhapT1 = (string) null;
    //  this.ucNhietTS.GiaTri_NhapT2 = (string) null;
    //  this.ucNhietTS.GiaTri_Xung = "";
    //  this.ucNhietTS.Location = new Point(413, 12);
    //  this.ucNhietTS.Name = "ucNhietTS";
    //  this.ucNhietTS.NameGroup = "Nhiệt độ Tan sấy";
    //  this.ucNhietTS.Size = new Size(370, 196);
    //  this.ucNhietTS.TabIndex = 4;
    //  this.ucNhietTS.ButtonChinhT1_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT1_Down);
    //  this.ucNhietTS.ButtonChinhT1_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT1_Up);
    //  this.ucNhietTS.ButtonChinhT2_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT2_Down);
    //  this.ucNhietTS.ButtonChinhT2_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTS_ButtonChinhT2_Up);
    //  this.ucNhietTS.Enter_Down_Nhap0 += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTS_Enter_Down_Nhap0);
    //  this.ucNhietTS.Enter_Down_NhapTai += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTS_Enter_Down_NhapTai);
    //  this.ucNhietTS.Enter_Down_NhapHeSo += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTS_Enter_Down_NhapHeSo);
    //  this.ucNhietAG.GiaTri_KLThucTe = (string) null;
    //  this.ucNhietAG.GiaTri_NhapHeSo = "";
    //  this.ucNhietAG.GiaTri_NhapT1 = (string) null;
    //  this.ucNhietAG.GiaTri_NhapT2 = (string) null;
    //  this.ucNhietAG.GiaTri_Xung = "";
    //  this.ucNhietAG.Location = new Point(409, 214);
    //  this.ucNhietAG.Name = "ucNhietAG";
    //  this.ucNhietAG.NameGroup = "Nhiệt độ AG";
    //  this.ucNhietAG.Size = new Size(370, 196);
    //  this.ucNhietAG.TabIndex = 5;
    //  this.ucNhietAG.ButtonChinhT1_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT1_Down);
    //  this.ucNhietAG.ButtonChinhT1_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT1_Up);
    //  this.ucNhietAG.ButtonChinhT2_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT2_Down);
    //  this.ucNhietAG.ButtonChinhT2_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAG_ButtonChinhT2_Up);
    //  this.ucNhietAG.Enter_Down_Nhap0 += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAG_Enter_Down_Nhap0);
    //  this.ucNhietAG.Enter_Down_NhapTai += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAG_Enter_Down_NhapTai);
    //  this.ucNhietAG.Enter_Down_NhapHeSo += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAG_Enter_Down_NhapHeSo);
    //  this.ucNhietAP.GiaTri_KLThucTe = (string) null;
    //  this.ucNhietAP.GiaTri_NhapHeSo = "";
    //  this.ucNhietAP.GiaTri_NhapT1 = (string) null;
    //  this.ucNhietAP.GiaTri_NhapT2 = (string) null;
    //  this.ucNhietAP.GiaTri_Xung = "";
    //  this.ucNhietAP.Location = new Point(409, 416);
    //  this.ucNhietAP.Name = "ucNhietAP";
    //  this.ucNhietAP.NameGroup = "Nhiệt độ Nhựa";
    //  this.ucNhietAP.Size = new Size(370, 196);
    //  this.ucNhietAP.TabIndex = 6;
    //  this.ucNhietAP.ButtonChinhT1_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT1_Down);
    //  this.ucNhietAP.ButtonChinhT1_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT1_Up);
    //  this.ucNhietAP.ButtonChinhT2_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT2_Down);
    //  this.ucNhietAP.ButtonChinhT2_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietAP_ButtonChinhT2_Up);
    //  this.ucNhietAP.Enter_Down_Nhap0 += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAP_Enter_Down_Nhap0);
    //  this.ucNhietAP.Enter_Down_NhapTai += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAP_Enter_Down_NhapTai);
    //  this.ucNhietAP.Enter_Down_NhapHeSo += new ucNhomChinhNhietDo.EnterKey(this.ucNhietAP_Enter_Down_NhapHeSo);
    //  this.ucNhietTL.GiaTri_KLThucTe = (string) null;
    //  this.ucNhietTL.GiaTri_NhapHeSo = "";
    //  this.ucNhietTL.GiaTri_NhapT1 = (string) null;
    //  this.ucNhietTL.GiaTri_NhapT2 = (string) null;
    //  this.ucNhietTL.GiaTri_Xung = "";
    //  this.ucNhietTL.Location = new Point(409, 618);
    //  this.ucNhietTL.Name = "ucNhietTL";
    //  this.ucNhietTL.NameGroup = "Nhiệt độ Túi lọc";
    //  this.ucNhietTL.Size = new Size(370, 196);
    //  this.ucNhietTL.TabIndex = 7;
    //  this.ucNhietTL.ButtonChinhT1_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT1_Down);
    //  this.ucNhietTL.ButtonChinhT1_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT1_Up);
    //  this.ucNhietTL.ButtonChinhT2_Down += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT2_Down);
    //  this.ucNhietTL.ButtonChinhT2_Up += new ucNhomChinhNhietDo.ButtonEventHandler(this.ucNhietTL_ButtonChinhT2_Up);
    //  this.ucNhietTL.Enter_Down_Nhap0 += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTL_Enter_Down_Nhap0);
    //  this.ucNhietTL.Enter_Down_NhapTai += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTL_Enter_Down_NhapTai);
    //  this.ucNhietTL.Enter_Down_NhapHeSo += new ucNhomChinhNhietDo.EnterKey(this.ucNhietTL_Enter_Down_NhapHeSo);
    //  this.timer1.Enabled = true;
    //  this.timer1.Tick += new EventHandler(this.timer1_Tick);
    //  this.AutoScaleDimensions = new SizeF(6f, 13f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.ClientSize = new Size(791, 818);
    //  this.Controls.Add((Control) this.ucNhietTL);
    //  this.Controls.Add((Control) this.ucNhietAP);
    //  this.Controls.Add((Control) this.ucNhietAG);
    //  this.Controls.Add((Control) this.ucNhietTS);
    //  this.Controls.Add((Control) this.ucCanSB);
    //  this.Controls.Add((Control) this.ucCanAP);
    //  this.Controls.Add((Control) this.ucCanAG);
    //  this.Controls.Add((Control) this.ucCanFD);
    //  this.IconOptions.Image = (Image) ResourceNhua.logoV_64;
    //  this.Name = nameof (FrmChinhCan);
    //  this.StartPosition = FormStartPosition.CenterScreen;
    //  this.Text = "Chỉnh cân";
    //  this.Load += new EventHandler(this.FrmChinhCan_Load);
    //  this.ResumeLayout(false);
    //}
  }
}
