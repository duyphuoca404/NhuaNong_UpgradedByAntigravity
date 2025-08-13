// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.ReceivingFromPLC
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Utils;
using System.Collections;

#nullable disable
namespace NhuaNong.MasterData
{
  internal class ReceivingFromPLC
  {
    private byte _statusIO_00;
    private byte _statusIO_01;
    private byte _statusIO_02;
    private byte _statusIO_03;
    private byte _statusIO_04;
    private byte _statusIO_05;
    private byte _statusIO_06;
    private byte _statusIO_07;
    private byte _statusIO_08;
    private byte _statusIO_09;
    private byte _statusIO_SAVE;
    private bool _Save_Report;
    private double _PV_SILO_1;
    private double _PV_SILO_2;
    private double _PV_SILO_3;
    private double _Per_WCEM_1;
    private double _WE_CEM_1;
    private double _SMC_CEM_1;
    private double _SMX_CEM_1;
    private double _PV_SILO_4;
    private double _PV_SILO_5;
    private double _Per_WCEM_2;
    private double _WE_CEM_2;
    private double _SMC_CEM_2;
    private double _SMX_CEM_2;
    private double _PV_WA_1;
    private double _Per_WWA_1;
    private double _WE_WA_1;
    private double _SMC_WA_1;
    private double _SMX_WA_1;
    private double _PV_WA_2;
    private double _Per_WWA_2;
    private double _WE_WA_2;
    private double _SMC_WA_2;
    private double _SMX_WA_2;
    private double _PV_ADD_1;
    private double _PV_ADD_2;
    private double _PV_ADD_3;
    private double _Per_WADD_1;
    private double _WE_ADD_1;
    private double _SMC_ADD_1;
    private double _SMX_ADD_1;
    private double _PV_ADD_4;
    private double _PV_ADD_5;
    private double _PV_ADD_6;
    private double _Per_WADD_2;
    private double _WE_ADD_2;
    private double _SMC_ADD_2;
    private double _SMX_ADD_2;
    private double _SMC_SKIP;
    private double _SMX_SKIP;
    private double _SMC_PTG;
    private double _SMX_PTG;
    private double _SMC_MIXER;
    private double _SMX_MIXER;
    private double _ThoiGianThucTron;
    private double _ThoiGianThucXa;
    private double _PheuChoStatus;

    public bool TH_NOI_TRON { get; set; }

    public bool TH_BTX { get; set; }

    public bool TH_BTN { get; set; }

    public bool TH_TANG_SAY { get; set; }

    public bool TH_GAU_COT_LIEU { get; set; }

    public bool TH_GAU_FD { get; set; }

    public bool TH_SANG_RUNG { get; set; }

    public bool TH_CUA_DONG { get; set; }

    public bool TH_CUA_MO { get; set; }

    public bool TH_MNK { get; set; }

    public bool TH_TRAN_AG1 { get; set; }

    public bool TH_TRAN_AG2 { get; set; }

    public bool TH_TRAN_AG3 { get; set; }

    public bool TH_TRAN_AG4 { get; set; }

    public bool TH_TRAN_AG5 { get; set; }

    public bool TH_TRAN_FD1 { get; set; }

    public bool TH_TRAN_SB1 { get; set; }

    public bool TH_SILO_FD_HIGHT { get; set; }

    public bool TH_SILO_FD_LOW { get; set; }

    public bool NOI_TRON { get; set; }

    public bool BTX { get; set; }

    public bool BTN { get; set; }

    public bool TANG_SAY { get; set; }

    public bool BOM_DAU { get; set; }

    public bool GAU_COT_LIEU { get; set; }

    public bool SAN_RUNG { get; set; }

    public bool GAU_FD { get; set; }

    public bool VIT_TAI_FD { get; set; }

    public bool BOM_SBS { get; set; }

    public bool QUAT_GIO { get; set; }

    public bool BOM_NUOC { get; set; }

    public bool MO_CUA { get; set; }

    public bool DONG_CUA { get; set; }

    public bool MNK { get; set; }

    public bool XA_CL1 { get; set; }

    public bool XA_CL2 { get; set; }

    public bool XA_CL3 { get; set; }

    public bool XA_CL4 { get; set; }

    public bool XA_CL5 { get; set; }

    public bool CAN_AG1 { get; set; }

    public bool CAN_AG2 { get; set; }

    public bool CAN_AG3 { get; set; }

    public bool CAN_AG4 { get; set; }

    public bool CAN_AG5 { get; set; }

    public bool CAN_FD1 { get; set; }

    public bool CAN_AP1 { get; set; }

    public bool CAN_SB1 { get; set; }

    public bool XA_W_AG1 { get; set; }

    public bool XA_W_FD1 { get; set; }

    public bool XA_W_AP1 { get; set; }

    public bool XA_W_SB1 { get; set; }

    public bool BOM_TUOi_NHUA { get; set; }

    public bool TIN_HIEU_DAU_DOT { get; set; }

    public bool NOTE_3 { get; set; }

    public bool NOTE_4 { get; set; }

    public bool NOTE_5 { get; set; }

    public bool NOTE_6 { get; set; }

    public bool NOTE_7 { get; set; }

    public bool RUNNING { get; set; }

    public bool SIMULATION { get; set; }

    public bool MIXER_FULL { get; set; }

    public bool TTC_AG1 { get; set; }

    public bool TTC_AG2 { get; set; }

    public bool TTC_AG3 { get; set; }

    public bool TTC_AG4 { get; set; }

    public bool TTC_AG5 { get; set; }

    public bool TTC_FD1 { get; set; }

    public bool TTC_AP1 { get; set; }

    public bool TTC_SB1 { get; set; }

    public double KL_ZERO_AG1 { get; set; }

    public double KL_SPAN_AG1 { get; set; }

    public double KL_ZERO_FD1 { get; set; }

    public double KL_SPAN_FD1 { get; set; }

    public double KL_ZERO_AP1 { get; set; }

    public double KL_SPAN_AP1 { get; set; }

    public double KL_ZERO_SB1 { get; set; }

    public double KL_SPAN_SB1 { get; set; }

    public double ZERO_TEMP_TS { get; set; }

    public double SPAN_TEMP_TS { get; set; }

    public double ZERO_TEMP_AG { get; set; }

    public double SPAN_TEMP_AG { get; set; }

    public double ZERO_TEMP_AP { get; set; }

    public double SPAN_TEMP_AP { get; set; }

    public double ZERO_TEMP_TL { get; set; }

    public double SPAN_TEMP_TL { get; set; }

    public double HS_AG1 { get; set; }

    public double HS_FD1 { get; set; }

    public double HS_AP1 { get; set; }

    public double HS_SB1 { get; set; }

    public double HS_TEMP1 { get; set; }

    public double HS_TEMP2 { get; set; }

    public double HS_TEMP3 { get; set; }

    public double HS_TEMP4 { get; set; }

    public double XUNG_AG1 { get; set; }

    public double XUNG_FD1 { get; set; }

    public double XUNG_AP1 { get; set; }

    public double XUNG_SB1 { get; set; }

    public double XUNG_TEMP_TS { get; set; }

    public double XUNG_TEMP_AG { get; set; }

    public double XUNG_TEMP_AP { get; set; }

    public double XUNG_TEMP_TL { get; set; }

    public double KLT_AG1 { get; set; }

    public double KLT_FD1 { get; set; }

    public double KLT_AP1 { get; set; }

    public double KLT_SB1 { get; set; }

    public double NDT_TS { get; set; }

    public double NDT_AG { get; set; }

    public double NDT_AP { get; set; }

    public double NDT_TL { get; set; }

    public double PV_AG1 { get; set; }

    public double Per_WAG1 { get; set; }

    public double WE_AG1 { get; set; }

    public double SMC_AG1 { get; set; }

    public double SMX_AG1 { get; set; }

    public double PV_AG2 { get; set; }

    public double SMC_AG2 { get; set; }

    public double SMX_AG2 { get; set; }

    public double PV_AG3 { get; set; }

    public double SMC_AG3 { get; set; }

    public double SMX_AG3 { get; set; }

    public double PV_AG4 { get; set; }

    public double SMC_AG4 { get; set; }

    public double SMX_AG4 { get; set; }

    public double PV_AG5 { get; set; }

    public double SMC_AG5 { get; set; }

    public double SMX_AG5 { get; set; }

    public double PV_FD1 { get; set; }

    public double Per_WFD1 { get; set; }

    public double WE_FD1 { get; set; }

    public double SMC_FD1 { get; set; }

    public double SMX_FD1 { get; set; }

    public double PV_AP1 { get; set; }

    public double Per_WAP1 { get; set; }

    public double WE_AP1 { get; set; }

    public double SMC_AP1 { get; set; }

    public double SMX_AP1 { get; set; }

    public double PV_SB1 { get; set; }

    public double Per_WSB1 { get; set; }

    public double WE_SB1 { get; set; }

    public double SMC_SB1 { get; set; }

    public double SMX_SB1 { get; set; }

    public double SMC_MIXER { get; set; }

    public double SMX_MIXER { get; set; }

    public double TG_THUC_TRON { get; set; }

    public double TG_THUC_XA { get; set; }

    public double SMT { get; set; }

    public double M3_ME { get; set; }

    public double PVM_AG1 { get; set; }

    public double PVM_AG2 { get; set; }

    public double PVM_AG3 { get; set; }

    public double PVM_AG4 { get; set; }

    public double PVM_AG5 { get; set; }

    public double PVM_FD1 { get; set; }

    public double PVM_AP1 { get; set; }

    public double PVM_SB1 { get; set; }

    public double TEMP_TUILOC { get; set; }

    public double TEMP_AGG { get; set; }

    public double TEMP_TANSAY { get; set; }

    public double TEMP_NHUA { get; set; }

    public bool SAVE_REPORT { get; set; }

    public double RE_PV_AGG1_R { get; set; }

    public double RE_PVM_AGG1_R { get; set; }

    public double RE_PV_AGG2_R { get; set; }

    public double RE_PVM_AGG2_R { get; set; }

    public double RE_PV_AGG3_R { get; set; }

    public double RE_PVM_AGG3_R { get; set; }

    public double RE_PV_AGG4_R { get; set; }

    public double RE_PVM_AGG4_R { get; set; }

    public double RE_PV_AGG5_R { get; set; }

    public double RE_PVM_AGG5_R { get; set; }

    public double RE_TEMP_TS_R { get; set; }

    public double RE_TEMP_AG_R { get; set; }

    public double RE_PV_FD1_R { get; set; }

    public double RE_PVM_FD1_R { get; set; }

    public double RE_PV_AP1_R { get; set; }

    public double RE_PVM_AP1_R { get; set; }

    public double RE_TEMP_AP_R { get; set; }

    public double RE_PV_SB1_R { get; set; }

    public double RE_PVM_SB1_R { get; set; }

    public byte StatusIO_00
    {
      set
      {
        this._statusIO_00 = value;
        BitArray bitArray = Converter.ConvertByteToBitArray(this._statusIO_00);
        this.TH_NOI_TRON = bitArray[0];
        this.TH_BTX = bitArray[1];
        this.TH_BTN = bitArray[2];
        this.TH_TANG_SAY = bitArray[3];
        this.TH_GAU_COT_LIEU = bitArray[4];
        this.TH_GAU_FD = bitArray[5];
        this.TH_SANG_RUNG = bitArray[6];
        this.TH_CUA_DONG = bitArray[7];
      }
    }

    public byte StatusIO_01
    {
      set
      {
        this._statusIO_01 = value;
        BitArray bitArray = Converter.ConvertByteToBitArray(this._statusIO_01);
        this.TH_CUA_MO = bitArray[0];
        this.TH_MNK = bitArray[1];
        this.TH_TRAN_AG1 = bitArray[2];
        this.TH_TRAN_AG2 = bitArray[3];
        this.TH_TRAN_AG3 = bitArray[4];
        this.TH_TRAN_AG4 = bitArray[5];
        this.TH_TRAN_AG5 = bitArray[6];
        this.TH_TRAN_FD1 = bitArray[7];
      }
    }

    public byte StatusIO_02
    {
      set
      {
        this._statusIO_02 = value;
        BitArray bitArray = Converter.ConvertByteToBitArray(this._statusIO_02);
        this.TH_TRAN_SB1 = bitArray[0];
        this.TH_SILO_FD_HIGHT = bitArray[1];
        this.TH_SILO_FD_LOW = bitArray[2];
        this.NOI_TRON = bitArray[3];
        this.BTX = bitArray[4];
        this.BTN = bitArray[5];
        this.TANG_SAY = bitArray[6];
        this.BOM_DAU = bitArray[7];
      }
    }

    public byte StatusIO_03
    {
      set
      {
        this._statusIO_03 = value;
        BitArray bitArray = Converter.ConvertByteToBitArray(this._statusIO_03);
        this.GAU_COT_LIEU = bitArray[0];
        this.SAN_RUNG = bitArray[1];
        this.GAU_FD = bitArray[2];
        this.VIT_TAI_FD = bitArray[3];
        this.BOM_SBS = bitArray[4];
        this.QUAT_GIO = bitArray[5];
        this.BOM_NUOC = bitArray[6];
        this.MO_CUA = bitArray[7];
      }
    }

    public byte StatusIO_04
    {
      set
      {
        this._statusIO_04 = value;
        BitArray bitArray = Converter.ConvertByteToBitArray(this._statusIO_04);
        this.DONG_CUA = bitArray[0];
        this.MNK = bitArray[1];
        this.XA_CL1 = bitArray[2];
        this.XA_CL2 = bitArray[3];
        this.XA_CL3 = bitArray[4];
        this.XA_CL4 = bitArray[5];
        this.XA_CL5 = bitArray[6];
        this.CAN_AG1 = bitArray[7];
      }
    }

    public byte StatusIO_05
    {
      set
      {
        this._statusIO_05 = value;
        BitArray bitArray = Converter.ConvertByteToBitArray(this._statusIO_05);
        this.CAN_AG2 = bitArray[0];
        this.CAN_AG3 = bitArray[1];
        this.CAN_AG4 = bitArray[2];
        this.CAN_AG5 = bitArray[3];
        this.CAN_FD1 = bitArray[4];
        this.CAN_AP1 = bitArray[5];
        this.CAN_SB1 = bitArray[6];
        this.XA_W_AG1 = bitArray[7];
      }
    }

    public byte StatusIO_06
    {
      set
      {
        this._statusIO_06 = value;
        BitArray bitArray = Converter.ConvertByteToBitArray(this._statusIO_06);
        this.XA_W_FD1 = bitArray[0];
        this.XA_W_AP1 = bitArray[1];
        this.XA_W_SB1 = bitArray[2];
        this.BOM_TUOi_NHUA = bitArray[3];
        this.TIN_HIEU_DAU_DOT = bitArray[4];
        this.NOTE_3 = bitArray[5];
        this.NOTE_4 = bitArray[6];
        this.NOTE_5 = bitArray[7];
      }
    }

    public byte StatusIO_07
    {
      set
      {
        this._statusIO_07 = value;
        BitArray bitArray = Converter.ConvertByteToBitArray(this._statusIO_07);
        this.NOTE_6 = bitArray[0];
        this.NOTE_7 = bitArray[1];
        this.RUNNING = bitArray[2];
        this.SIMULATION = bitArray[3];
        this.MIXER_FULL = bitArray[4];
        this.TTC_AG1 = bitArray[5];
        this.TTC_AG2 = bitArray[6];
        this.TTC_AG3 = bitArray[7];
      }
    }

    public byte StatusIO_08
    {
      set
      {
        this._statusIO_08 = value;
        BitArray bitArray = Converter.ConvertByteToBitArray(this._statusIO_08);
        this.TTC_AG4 = bitArray[0];
        this.TTC_AG5 = bitArray[1];
        this.TTC_FD1 = bitArray[2];
        this.TTC_AP1 = bitArray[3];
        this.TTC_SB1 = bitArray[4];
      }
    }

    public byte StatusIO_09
    {
      set
      {
        this._statusIO_09 = value;
        Converter.ConvertByteToBitArray(this._statusIO_09);
      }
    }

    public byte StatusIO_SAVEREPORT
    {
      set
      {
        this._statusIO_SAVE = value;
        this.SAVE_REPORT = Converter.ConvertByteToBitArray(this._statusIO_SAVE)[0];
      }
    }
  }
}
