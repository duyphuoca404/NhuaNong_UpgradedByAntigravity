// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.TronOnlineAttributes
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

#nullable disable
namespace NhuaNong.MasterData
{
  internal class TronOnlineAttributes
  {
    private bool _IsRunning;
    private bool _WeiEnd;
    private bool _MarkAsSendSetpoint;
    private bool _MarkAsSendSetpointSuccess;
    private bool _HeThongAuto;
    private bool _XaNoiTronAuto;
    private bool _NapLieuAuto;
    private bool _HopperDischarging;
    private bool _HopperDischargingChanged;
    private bool _MixerRunning;
    private bool _MixerRunningChanged;
    private bool _MixerDischarging;
    private bool _MixerDischargingChanged;
    private bool _Mixer50Discharging;
    private bool _Mixer50DischargingChanged;

    internal event TronOnlineAttributes.WeiEventHandler WeiRunningStatusChanged;

    internal bool IsRunning
    {
      get => this._IsRunning;
      set
      {
        if (this._IsRunning != value && this.WeiRunningStatusChanged != null)
          this.WeiRunningStatusChanged(value);
        this._IsRunning = value;
      }
    }

    internal bool WeiEnd
    {
      get => this._WeiEnd;
      set => this._WeiEnd = value;
    }

    internal bool MarkAsSendSetpoint
    {
      get => this._MarkAsSendSetpoint;
      set => this._MarkAsSendSetpoint = value;
    }

    internal bool MarkAsSendSetpointSuccess
    {
      get => this._MarkAsSendSetpointSuccess;
      set => this._MarkAsSendSetpointSuccess = value;
    }

    private bool HeThongAuto
    {
      get => this._HeThongAuto;
      set => this._HeThongAuto = value;
    }

    private bool XaNoiTronAuto
    {
      get => this._XaNoiTronAuto;
      set => this._XaNoiTronAuto = value;
    }

    private bool NapLieuAuto
    {
      get => this._NapLieuAuto;
      set => this._NapLieuAuto = value;
    }

    internal bool HopperDischarging
    {
      get => this._HopperDischarging;
      set
      {
        if (this._HopperDischarging != value)
          this._HopperDischargingChanged = true;
        this._HopperDischarging = value;
      }
    }

    private bool HopperDischargingChanged
    {
      get
      {
        int num = this._HopperDischargingChanged ? 1 : 0;
        this._HopperDischargingChanged = false;
        return num != 0;
      }
    }

    internal bool MixerRunning
    {
      get => this._MixerRunning;
      set
      {
        if (this._MixerRunning != value)
          this._MixerRunningChanged = true;
        this._MixerRunning = value;
      }
    }

    internal bool MixerRunningChanged
    {
      get
      {
        int num = this._MixerRunningChanged ? 1 : 0;
        this._MixerRunningChanged = false;
        return num != 0;
      }
    }

    internal bool MixerDischarging
    {
      get => this._MixerDischarging;
      set
      {
        if (this._MixerDischarging != value)
          this._MixerDischargingChanged = true;
        this._MixerDischarging = value;
      }
    }

    internal bool MixerDischargingChanged
    {
      get
      {
        int num = this._MixerDischargingChanged ? 1 : 0;
        this._MixerDischargingChanged = false;
        return num != 0;
      }
    }

    internal bool Mixer50Discharging
    {
      get => this._Mixer50Discharging;
      set
      {
        if (this._Mixer50Discharging != value)
          this._Mixer50DischargingChanged = true;
        this._Mixer50Discharging = value;
      }
    }

    internal bool Mixer50DischargingChanged
    {
      get
      {
        int num = this._Mixer50DischargingChanged ? 1 : 0;
        this._Mixer50DischargingChanged = false;
        return num != 0;
      }
    }

    internal bool CheckConditionForRunning()
    {
      return this._MarkAsSendSetpoint && this._MarkAsSendSetpointSuccess;
    }

    internal void ResetConditionForRunning()
    {
      this._MarkAsSendSetpoint = false;
      this._MarkAsSendSetpointSuccess = true;
    }

    internal void ResetAttributes()
    {
      this._IsRunning = false;
      this._MarkAsSendSetpoint = false;
      this._MarkAsSendSetpointSuccess = true;
    }

    internal delegate void WeiEventHandler(bool isRunning);
  }
}
