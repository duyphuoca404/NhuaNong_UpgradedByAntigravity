// Decompiled with JetBrains decompiler
// Type: NhuaNong.PLCModule.PLCController
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Utils;
using S7.Net;
using S7.Net.Types;
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace NhuaNong.PLCModule
{
  public class PLCController
  {
    private Plc _plc;
    private int mutexTime = 500;
    private int retryEventReleaseNum = 5;
    private int maxNumberErrorAccepted = 10;
    private int numberError;
    private static AutoResetEvent _event = new AutoResetEvent(false);
    private bool isReconnecting;

    public PLCController() => this.Init();

    public void Init()
    {
      this._plc = new Plc(CpuType.S71200, ConfigManager.TramTronConfig.LANIP, (short) 0, (short) 1);
      try
      {
        this._plc.Open();
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
      }
    }

    public async Task ReConnectAsync()
    {
      Task task = await Task.Factory.StartNew<Task>((Func<Task>) (async () =>
      {
        this._plc = new Plc(CpuType.S71200, ConfigManager.TramTronConfig.LANIP, (short) 0, (short) 1);
        try
        {
          this._plc.OpenAsync();
        }
        catch (System.Exception ex)
        {
          TramTronLogger.WriteError(ex);
        }
      }));
    }

    public async void AttemptReconnect()
    {
      if (this.isReconnecting)
        return;
      this.isReconnecting = true;
      try
      {
        await this.ReConnectAsync();
      }
      finally
      {
        this.isReconnecting = false;
      }
    }

    public bool IsConnected => this._plc.IsConnected;

    private void RetryEventRelease()
    {
      for (int index = 0; index < this.retryEventReleaseNum; ++index)
      {
        try
        {
          PLCController._event.Set();
          break;
        }
        catch (System.Exception ex)
        {
          TramTronLogger.WriteError(ex);
        }
      }
    }

    private void HandleException()
    {
      ++this.numberError;
      if (this.numberError != this.maxNumberErrorAccepted)
        return;
      this.numberError = 0;
      if (this._plc != null)
        this._plc.Close();
      this.Init();
    }

    public void WriteStruct(object structValue, int DB, int startByteAddr)
    {
      try
      {
        PLCController._event.WaitOne(this.mutexTime);
        byte[] bytes = Struct.ToBytes(structValue);
        this.WriteBytes(S7.Net.DataType.DataBlock, DB, startByteAddr, bytes);
      }
      catch (System.Exception ex)
      {
        this.HandleException();
      }
      finally
      {
        this.RetryEventRelease();
      }
    }

    public void WriteBytes(S7.Net.DataType DataType, int DB, int StartByteAdr, byte[] value)
    {
      try
      {
        PLCController._event.WaitOne(this.mutexTime);
        this._plc.WriteBytes(DataType, DB, StartByteAdr, value);
      }
      catch (System.Exception ex)
      {
        this.HandleException();
      }
      finally
      {
        this.RetryEventRelease();
      }
    }

    public byte[] ReadBytes(S7.Net.DataType DataType, int DB, int StartByteAdr, int count)
    {
      byte[] numArray = new byte[300];
      try
      {
        PLCController._event.WaitOne(this.mutexTime);
        numArray = this._plc.ReadBytes(DataType, DB, StartByteAdr, count);
      }
      catch (System.Exception ex)
      {
        this.HandleException();
      }
      finally
      {
        this.RetryEventRelease();
      }
      return numArray;
    }

    public void WriteBit(S7.Net.DataType DataType, int DB, int StartByteAdr, int BitAdr, bool value)
    {
      try
      {
        PLCController._event.WaitOne(this.mutexTime);
        this._plc.WriteBit(DataType, DB, StartByteAdr, BitAdr, value);
      }
      catch (System.Exception ex)
      {
        this.HandleException();
      }
      finally
      {
        this.RetryEventRelease();
      }
    }

    public string CheckConnection()
    {
      string empty = string.Empty;
      return this._plc.IsConnected ? empty : "not connected";
    }
  }
}
