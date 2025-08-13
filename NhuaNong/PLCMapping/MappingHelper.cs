// Decompiled with JetBrains decompiler
// Type: NhuaNong.PLCMapping.MappingHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace NhuaNong.PLCMapping
{
  public class MappingHelper
  {
    public static string GetString_PLCDataType_Silo(int i)
    {
      string empty = string.Empty;
      switch (i)
      {
        case 0:
          return ">AG1";
        case 1:
          return ">AG2";
        case 2:
          return ">AG3";
        case 3:
          return ">AG4";
        default:
          throw new Exception("[NamDaiPhatTramTron] - Out of range [PLC DataType Silo]");
      }
    }

    public static List<byte> SeparateIntTo2Bytes(int intOrigin)
    {
      return new List<byte>()
      {
        (byte) (intOrigin >> 8 & (int) byte.MaxValue),
        (byte) (intOrigin & (int) byte.MaxValue)
      };
    }

    public static List<byte> SeparateFloatTo4Bytes(double floatOrigin)
    {
      byte[] byteArray = S7.Net.Types.Double.ToByteArray(floatOrigin);
      return new List<byte>()
      {
        byteArray[0],
        byteArray[1],
        byteArray[2],
        byteArray[3]
      };
    }

    public static int Merge2BytesIntoInt(byte byte1, byte byte2) => (int) byte1 << 8 ^ (int) byte2;

    public static uint Merge4BytesIntoInt(byte byte1, byte byte2, byte byte3, byte byte4)
    {
      byte[] numArray = new byte[4]
      {
        byte1,
        byte2,
        byte3,
        byte4
      };
      if (BitConverter.IsLittleEndian)
        Array.Reverse((Array) numArray);
      return BitConverter.ToUInt32(numArray, 0);
    }

    public static byte[] MapToSendingData_WithPLCDatatype(List<byte> lstByte, string strInputType)
    {
      byte[] dataWithPlcDatatype = new byte[strInputType.Length + lstByte.Count + 3];
      dataWithPlcDatatype[0] = (byte) 3;
      dataWithPlcDatatype[1] = (byte) (lstByte.Count + strInputType.Length + 1);
      byte[] bytes = new ASCIIEncoding().GetBytes(strInputType);
      int index = 2;
      int num1 = index;
      foreach (int num2 in bytes)
      {
        dataWithPlcDatatype[index] = bytes[index - num1];
        ++index;
      }
      int num3 = index;
      foreach (int num4 in lstByte)
      {
        dataWithPlcDatatype[index] = lstByte[index - num3];
        ++index;
      }
      dataWithPlcDatatype[dataWithPlcDatatype.Length - 1] = (byte) 13;
      return dataWithPlcDatatype;
    }

    public static byte[] MapToSendingData_WithPLCDatatype(
      List<int> lstIntOriginValue,
      string strInputType)
    {
      List<byte> lstByte = new List<byte>();
      foreach (int intOrigin in lstIntOriginValue)
        lstByte.AddRange((IEnumerable<byte>) MappingHelper.SeparateIntTo2Bytes(intOrigin));
      return MappingHelper.MapToSendingData_WithPLCDatatype(lstByte, strInputType);
    }

    public static int ValidateDataInput(byte[] plcBuff, string strInputTypeOK)
    {
      if (plcBuff.Length < 3)
        return -1;
      if (plcBuff[0] != (byte) 3)
        return -2;
      int num = (int) plcBuff[1] + 2;
      if (num != plcBuff.Length)
        return -3;
      if (plcBuff[num - 1] != (byte) 13)
        return -4;
      byte[] bytes = new byte[strInputTypeOK.Length];
      for (int index = 0; index < strInputTypeOK.Length; ++index)
        bytes[index] = plcBuff[index + 2];
      return Encoding.ASCII.GetString(bytes) != strInputTypeOK ? -5 : strInputTypeOK.Length + 2;
    }

    public static byte[] MapToReceivingData_WithoutPLCDatatype(byte[] plcBuff, int startIndex)
    {
      byte[] withoutPlcDatatype = new byte[plcBuff.Length - startIndex - 1];
      for (int index = 0; index < withoutPlcDatatype.Length; ++index)
        withoutPlcDatatype[index] = plcBuff[index + startIndex];
      return withoutPlcDatatype;
    }

    public static byte[] MapToReceivingData_WithoutPLCDatatype1(
      byte[] plcBuff,
      string strInputTypeOK)
    {
      if (plcBuff.Length < 3)
        throw new Exception("[NamDaiPhat] - Invalid data format.");
      if (plcBuff[0] != (byte) 3)
        throw new Exception("[NamDaiPhat] - Invalid begining charater.");
      int num1 = (int) plcBuff[1] + 2;
      if (num1 != plcBuff.Length)
        throw new Exception("[NamDaiPhat] - Invalid length of data.");
      if (plcBuff[num1 - 1] != (byte) 13)
        throw new Exception("[NamDaiPhat] - Invalid ending charater.");
      byte[] withoutPlcDatatype1 = new byte[plcBuff.Length - strInputTypeOK.Length - 3];
      int num2 = 2;
      int num3 = num2;
      byte[] bytes = new byte[strInputTypeOK.Length];
      for (int index = 0; index < strInputTypeOK.Length; ++index)
      {
        bytes[index] = plcBuff[index + num3];
        ++num2;
      }
      if (Encoding.ASCII.GetString(bytes) != strInputTypeOK)
        throw new Exception("[NamDaiPhat] - MapToReceivingData_WithoutPLCDatatype - PLCInputType does not match");
      int num4 = num2;
      for (int index = 0; index < withoutPlcDatatype1.Length; ++index)
        withoutPlcDatatype1[index] = plcBuff[index + num4];
      return withoutPlcDatatype1;
    }

    public static bool ByteArraysEqual(byte[] a1, byte[] a2)
    {
      if (a1.Length != a2.Length)
        return false;
      for (int index = 0; index < a1.Length; ++index)
      {
        if ((int) a1[index] != (int) a2[index])
          return false;
      }
      return true;
    }
  }
}
