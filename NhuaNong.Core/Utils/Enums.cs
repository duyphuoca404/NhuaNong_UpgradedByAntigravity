// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.Enums
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.ComponentModel.DataAnnotations;

#nullable disable
namespace NhuaNong.Utils
{
  public class Enums
  {
    public class VanHanh
    {
      public enum WeiSiloType
      {
        Silo = 1,
        Wei = 11, // 0x0000000B
      }
    }

    public enum FormAction
    {
      New,
      Edit,
      View,
    }

    public enum MsgType
    {
      Error,
      Info,
      Warning,
    }

    public enum RunningMode
    {
      [Display(Name = "Stand Alone")] StandAlone,
      [Display(Name = "Service")] Service,
    }

    public enum LanguageRes
    {
      [Display(Name = "English")] English,
      [Display(Name = "Vietnamese")] Vietnamese,
    }

    public enum ActiveEnum
    {
      [Display(Name = "Đang hoạt động")] Active = 1,
      [Display(Name = "Tạm ngưng")] Deactive = 2,
    }

    public enum SimMode
    {
      [Display(Name = "Mô phỏng")] Sim = 1,
      [Display(Name = "Bình thường")] Normal = 2,
    }

    public enum HopDongStatus
    {
      [Display(Name = "Mới")] New,
      [Display(Name = "Đang xử lý")] InProcess,
      [Display(Name = "Hủy")] Cancel,
      [Display(Name = "Đợi")] Close,
      [Display(Name = "Hoàn tất")] Completed,
    }

    public enum PhieuTronStatus
    {
      [Display(Name = "Mới")] New,
      [Display(Name = "Hủy")] Cancel,
      [Display(Name = "Đợi")] Waiting,
      [Display(Name = "Đang trộn")] InProcess,
      [Display(Name = "Trộn thất Bại")] Failed,
      [Display(Name = "Đã trộn")] Finished,
    }

    public enum DuLieuTronStatus
    {
      [Display(Name = "Mới")] New,
      [Display(Name = "Đang trộn")] Running,
      [Display(Name = "Tạm dừng")] Pause,
      [Display(Name = "Hủy")] Abort,
      [Display(Name = "Hoàn tất")] Finished,
    }

    public enum Unit
    {
      Kg,
      ml,
      m3,
    }

    public enum MeTronStatus
    {
      Mixing,
      Failed,
      Finished,
    }

    public enum SiloType
    {
      Agg,
      Ce,
      Wa,
      Add,
    }

    public enum TronOnlineCommand
    {
      Run,
      Pause,
      Stop,
      CancelAgg,
      CancelCe,
      CancelWa,
      StopCe,
      StopWa,
      StopAdd,
      RunMoPhong,
    }

    public enum TronOnlineState
    {
      Step0,
      Step1,
      Step2,
      Step3,
      Step4,
      Step5,
      Step6,
    }

    public enum TronProcess
    {
      S00_None = 0,
      S01_Init = 1,
      S02_NapCan = 2,
      S03_NapNoiTron = 3,
      S04_NoiTronFull = 5,
      S05_XaNoiTron = 6,
    }

    public enum FunctionType
    {
      Module,
      Menu,
      Function,
    }

    public class Exception
    {
      public enum MappingEx
      {
        [Display(Name = "PLCInputType does not match")] InputTypeNotMatch = -5, // 0xFFFFFFFB
        [Display(Name = "Invalid ending charater.")] EndingCharacter = -4, // 0xFFFFFFFC
        [Display(Name = "Invalid length of data.")] Length = -3, // 0xFFFFFFFD
        [Display(Name = "Invalid begining charater.")] BeginningCharacter = -2, // 0xFFFFFFFE
        [Display(Name = "Invalid data input.")] DataInput = -1, // 0xFFFFFFFF
      }
    }

    public class S7Connector
    {
      public enum CPUType
      {
        S7200 = 0,
        S7300 = 10, // 0x0000000A
        S7400 = 20, // 0x00000014
        S71200 = 30, // 0x0000001E
      }

      public enum ExceptionCode
      {
        ExceptionNo = 0,
        WrongCPU_Type = 1,
        ConnectionError = 2,
        IPAdressNotAvailable = 3,
        WrongVariableFormat = 10, // 0x0000000A
        WrongNumberReceivedBytes = 11, // 0x0000000B
        SendData = 20, // 0x00000014
        ReadData = 30, // 0x0000001E
        WriteData = 50, // 0x00000032
      }

      public enum DataType
      {
        Counter = 28, // 0x0000001C
        Timer = 29, // 0x0000001D
        Input = 129, // 0x00000081
        Output = 130, // 0x00000082
        Marker = 131, // 0x00000083
        DataBlock = 132, // 0x00000084
      }

      public enum VarType
      {
        Bit,
        Byte,
        Word,
        DWord,
        Int,
        DInt,
        Real,
        String,
        Timer,
        Counter,
      }
    }
  }
}
