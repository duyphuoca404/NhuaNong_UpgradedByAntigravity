// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.StatusConnected
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Management;
using System.Net.Http;
using System.Reflection;
using System.Text;

#nullable disable
namespace NhuaNong.Utils
{
  public class StatusConnected
  {
    private bool _isOpen;
    private static string _hostname = Environment.MachineName;
    private static string _namePlan = ConfigManager.TramTronConfig.TenCty;
    private static string _contact = ConfigManager.TramTronConfig.DienThoaiCty;
    private static string _cff = "VACM";
    private static string a = "XXX";
    private static string _productVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();

    public static void CheckOpenSof(bool isOpen, bool isControl)
    {
      ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
      Console.WriteLine("INFOR : " + new ComputerInfo().OSFullName);
      if (isOpen & isControl)
        StatusConnected.AddDataToServer(StatusConnected._hostname, StatusConnected._namePlan, "Running", "Running", StatusConnected._cff, StatusConnected._productVersion, StatusConnected.a);
      else if (isOpen && !isControl)
      {
        StatusConnected.AddDataToServer(StatusConnected._hostname, StatusConnected._namePlan, "Running", "Stopped", StatusConnected._cff, StatusConnected._productVersion, StatusConnected.a);
      }
      else
      {
        if (isOpen || isControl)
          return;
        StatusConnected.AddDataToServer(StatusConnected._hostname, StatusConnected._namePlan, "Stopped", "Stopped", StatusConnected._cff, StatusConnected._productVersion, StatusConnected.a);
      }
    }

    private static async void AddDataToServer(
      string NameMachine,
      string NamePlan,
      string ActiveStatus,
      string ControlStatus,
      string ConfigFile,
      string Version,
      string Contact)
    {
      Dictionary<string, string> dictionary = new Dictionary<string, string>()
      {
        {
          nameof (NameMachine),
          NameMachine
        },
        {
          nameof (NamePlan),
          NamePlan
        },
        {
          nameof (ActiveStatus),
          ActiveStatus
        },
        {
          nameof (ControlStatus),
          ControlStatus
        },
        {
          nameof (ConfigFile),
          ConfigFile
        },
        {
          nameof (Version),
          Version
        },
        {
          nameof (Contact),
          Contact
        }
      };
      using (HttpClient httpClient = new HttpClient())
      {
        try
        {
          HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("https://connected-six.vercel.app/connected/add", (HttpContent) new StringContent(JsonConvert.SerializeObject((object) dictionary), Encoding.UTF8, "application/json"));
          if (httpResponseMessage.IsSuccessStatusCode)
          {
            if (httpResponseMessage.ReasonPhrase == "OK")
              Console.WriteLine("OK");
            else
              Console.WriteLine("Fail");
          }
          else
            Console.WriteLine("Not Connected");
        }
        catch (System.Exception ex)
        {
          Console.WriteLine("No Connect");
        }
      }
    }
  }
}
