// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.SendingToPLC
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Utils;
using System.Collections;

#nullable disable
namespace NhuaNong.MasterData
{
  public class SendingToPLC
  {
    private byte _Byte_0;
    private byte _Byte_1;
    private byte _Byte_2;
    private byte _Byte_3;
    private byte _Byte_4;
    private byte _Byte_5;
    private byte _Byte_6;
    private byte _Byte_7;
    private byte _Byte_8;
    private byte _Byte_9;
    private byte _Byte_10;
    private byte _Byte_11;
    private byte _Byte_12;
    private SendingCommand _objSC = new SendingCommand();

    public byte Byte_0
    {
      get
      {
        this._Byte_0 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.F1_NN_RUN,
          [1] = this._objSC.F2_SW_PAU,
          [2] = this._objSC.F3_NN_STOP,
          [3] = this._objSC.F4_SW_SIM,
          [4] = this._objSC.SW_MAN_AUTO,
          [5] = this._objSC.SW_XA_COT_LIEU,
          [6] = this._objSC.SW_NAP_NOI_TRON,
          [7] = this._objSC.SW_XA_NOI_TRON
        });
        return this._Byte_0;
      }
      set => this._Byte_0 = value;
    }

    public byte Byte_1
    {
      get
      {
        this._Byte_1 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.NN_NOI_TRON,
          [1] = this._objSC.NN_BTX,
          [2] = this._objSC.NN_BTN,
          [3] = this._objSC.NN_TANG_SAY,
          [4] = this._objSC.NN_BOM_DAU,
          [5] = this._objSC.NN_GAU_COT_LIEU,
          [6] = this._objSC.NN_SAN_RUNG,
          [7] = this._objSC.NN_GAU_FD
        });
        return this._Byte_1;
      }
      set => this._Byte_1 = value;
    }

    public byte Byte_2
    {
      get
      {
        this._Byte_2 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.NN_VIT_TAI_FD,
          [1] = this._objSC.NN_BOM_SBS,
          [2] = this._objSC.NN_QUAT_GIO,
          [3] = this._objSC.NN_BOM_NUOC,
          [4] = this._objSC.NN_MO_CUA,
          [5] = this._objSC.NN_DONG_CUA,
          [6] = this._objSC.NN_MNK,
          [7] = this._objSC.SW_XA_CL1
        });
        return this._Byte_2;
      }
      set => this._Byte_2 = value;
    }

    public byte Byte_3
    {
      get
      {
        this._Byte_3 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.SW_XA_CL2,
          [1] = this._objSC.SW_XA_CL3,
          [2] = this._objSC.SW_XA_CL4,
          [3] = this._objSC.SW_XA_CL5,
          [4] = this._objSC.NN_CAN_AG1,
          [5] = this._objSC.NN_CAN_AG2,
          [6] = this._objSC.NN_CAN_AG3,
          [7] = this._objSC.NN_CAN_AG4
        });
        return this._Byte_3;
      }
      set => this._Byte_3 = value;
    }

    public byte Byte_4
    {
      get
      {
        this._Byte_4 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.NN_CAN_AG5,
          [1] = this._objSC.NN_CAN_FD1,
          [2] = this._objSC.NN_CAN_AP1,
          [3] = this._objSC.NN_CAN_SB1,
          [4] = this._objSC.SW_XA_W_AG1,
          [5] = this._objSC.SW_XA_W_FD1,
          [6] = this._objSC.SW_XA_W_AP1,
          [7] = this._objSC.SW_XA_W_SB1
        });
        return this._Byte_4;
      }
      set => this._Byte_4 = value;
    }

    public byte Byte_5
    {
      get
      {
        this._Byte_5 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.NN_BOMTUOINHUA,
          [1] = this._objSC.NN_XAHETAGG,
          [2] = this._objSC.NN_DAU_DOT,
          [3] = this._objSC.SW_PHEU_SBS,
          [4] = this._objSC.NN_NOTE_5,
          [5] = this._objSC.NN_NOTE_6,
          [6] = this._objSC.NN_NOTE_7,
          [7] = this._objSC.NN_FU_AG1
        });
        return this._Byte_5;
      }
      set => this._Byte_5 = value;
    }

    public byte Byte_6
    {
      get
      {
        this._Byte_6 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.NN_FU_AG2,
          [1] = this._objSC.NN_FU_AG3,
          [2] = this._objSC.NN_FU_AG4,
          [3] = this._objSC.NN_FU_AG5,
          [4] = this._objSC.NN_FU_FD1,
          [5] = this._objSC.NN_FU_AP1,
          [6] = this._objSC.NN_FU_SB1,
          [7] = this._objSC.SW_PA_AG1
        });
        return this._Byte_6;
      }
      set => this._Byte_6 = value;
    }

    public byte Byte_7
    {
      get
      {
        this._Byte_7 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.SW_PA_AG2,
          [1] = this._objSC.SW_PA_AG3,
          [2] = this._objSC.SW_PA_AG4,
          [3] = this._objSC.SW_PA_AG5,
          [4] = this._objSC.SW_PA_FD1,
          [5] = this._objSC.SW_PA_AP1,
          [6] = this._objSC.SW_PA_SB1,
          [7] = this._objSC.NN_ZERO_AG1
        });
        return this._Byte_7;
      }
      set => this._Byte_7 = value;
    }

    public byte Byte_8
    {
      get
      {
        this._Byte_8 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.NN_SPAN_AG1,
          [1] = this._objSC.NN_ZERO_FD1,
          [2] = this._objSC.NN_SPAN_FD1,
          [3] = this._objSC.NN_ZERO_AP1,
          [4] = this._objSC.NN_SPAN_AP1,
          [5] = this._objSC.NN_ZERO_SB1,
          [6] = this._objSC.NN_SPAN_SB1,
          [7] = this._objSC.NN_ZERO_TEMP_1
        });
        return this._Byte_8;
      }
      set => this._Byte_8 = value;
    }

    public byte Byte_9
    {
      get
      {
        this._Byte_9 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.NN_SPAN_TEMP_1,
          [1] = this._objSC.NN_ZERO_TEMP_2,
          [2] = this._objSC.NN_SPAN_TEMP_2,
          [3] = this._objSC.NN_ZERO_TEMP_3,
          [4] = this._objSC.NN_SPAN_TEMP_3,
          [5] = this._objSC.NN_ZERO_TEMP_4,
          [6] = this._objSC.NN_SPAN_TEMP_4,
          [7] = this._objSC.NN_RUNG_AG1
        });
        return this._Byte_9;
      }
      set => this._Byte_9 = value;
    }

    public byte Byte_10
    {
      get
      {
        this._Byte_10 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.NN_RUNG_FD1,
          [1] = this._objSC.NN_RUNG_SB1,
          [2] = this._objSC.XAC_NHAN_CAN_DU,
          [3] = this._objSC.XNC_AUT_AG1,
          [4] = this._objSC.XNC_AUT_AG2,
          [5] = this._objSC.XNC_AUT_AG3,
          [6] = this._objSC.XNC_AUT_AG4,
          [7] = this._objSC.XNC_AUT_AG5
        });
        return this._Byte_10;
      }
      set => this._Byte_10 = value;
    }

    public byte Byte_11
    {
      get
      {
        this._Byte_11 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.XNC_AUT_FD1,
          [1] = this._objSC.XNC_AUT_AP1,
          [2] = this._objSC.XNC_AUT_SB1,
          [3] = this._objSC.BUTRU_AGG1,
          [4] = this._objSC.BUTRU_AGG2,
          [5] = this._objSC.BUTRU_AGG3,
          [6] = this._objSC.BUTRU_AGG4,
          [7] = this._objSC.BUTRU_AGG5
        });
        return this._Byte_11;
      }
      set => this._Byte_11 = value;
    }

    public byte Byte_12
    {
      get
      {
        this._Byte_12 = Converter.ConvertBitArrayToByte(new BitArray(8)
        {
          [0] = this._objSC.BUTRU_FD1,
          [1] = this._objSC.BUTRU_AP1,
          [2] = this._objSC.BUTRU_SB1,
          [3] = this._objSC.NN_RUNG_CL1,
          [4] = this._objSC.NN_RUNG_CL2,
          [5] = this._objSC.NN_RUNG_CL3
        });
        return this._Byte_12;
      }
      set => this._Byte_12 = value;
    }

    public int SIM_WeiAgg1 { get; set; }

    public int SIM_WeiAgg2 { get; set; }

    public int SIM_WeiAgg3 { get; set; }

    public int SIM_WeiAgg4 { get; set; }

    public int SIM_WeiAgg5 { get; set; }

    public int SIM_WeiCe1 { get; set; }

    public int SIM_WeiCe2 { get; set; }

    public int SIM_WeiWa1 { get; set; }

    public int SIM_WeiWa2 { get; set; }

    public int SIM_WeiAdd1 { get; set; }

    public int SIM_WeiAdd2 { get; set; }

    public int ThemBotNuoc { get; set; }

    public int DeNuocTrenCan { get; set; }

    public int SoMeDis { get; set; }

    public int ThemBotNuoc2 { get; set; }

    public int DeNuocTrenCan2 { get; set; }

    public int LogicCanCe1 { get; set; }

    public int LogicCanCe2 { get; set; }

    public int LogicCanAdd1 { get; set; }

    public int TiLeNoiTron1 { get; set; }

    public int TiLeNoiTron2 { get; set; }

    public double KL_Chinh0_Agg { get; set; }

    public double KL_ChinhTai_Agg { get; set; }

    public double KL_Chinh0_Ce { get; set; }

    public double KL_ChinhTai_Ce { get; set; }

    public double KL_Chinh0_Wa { get; set; }

    public double KL_ChinhTai_Wa { get; set; }

    public SendingCommand SendingCommand
    {
      get => this._objSC;
      set => this._objSC = value;
    }

    public void ResetValues() => this._objSC.ResetValues();
  }
}
