// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.TramTronLogger
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Xml;

#nullable disable
namespace NhuaNong.Utils
{
  public class TramTronLogger
  {
    protected static string _logFilePath = string.Empty;
    private static StreamWriter _sw = (StreamWriter) null;
    private static string _logFile = string.Empty;
    private static string _logPath = string.Empty;

    public static bool WriteInfo(string msg)
    {
      try
      {
        if (TramTronLogger._logPath == string.Empty)
          TramTronLogger.LogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FolderLogs");
        if (!Directory.Exists(TramTronLogger._logPath))
          Directory.CreateDirectory(TramTronLogger._logPath);
        DateTime dateTime = DateTime.Now;
        dateTime = dateTime.Date;
        string path2 = "_inf_" + dateTime.ToString("yyyy-MM-dd") + ".txt";
        string str = Path.Combine(TramTronLogger._logPath, path2);
        if (!System.IO.File.Exists(str))
          System.IO.File.Create(str).Close();
        TramTronLogger.WriteOperationLog(str, msg);
        return true;
      }
      catch
      {
        return false;
      }
    }

    public static bool WriteError(System.Exception ex)
    {
      try
      {
        if (TramTronLogger._logPath == string.Empty)
        {
          TramTronLogger.LogPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "OperXL");
          if (!Directory.Exists(TramTronLogger._logPath))
            Directory.CreateDirectory(TramTronLogger._logPath);
        }
        if (TramTronLogger._logFile == string.Empty)
          TramTronLogger.LogFile = TramTronLogger.AutoGenerateLogFile();
        if (!Directory.Exists(TramTronLogger._logPath))
          Directory.CreateDirectory(TramTronLogger._logPath);
        if (!System.IO.File.Exists(TramTronLogger._logFilePath))
          System.IO.File.Create(TramTronLogger._logFilePath).Close();
        TramTronLogger.WriteErrorLog(TramTronLogger._logFilePath, ex);
        return true;
      }
      catch
      {
        return false;
      }
    }

    private static string AutoGenerateLogFile()
    {
      DateTime dateTime = DateTime.Now;
      dateTime = dateTime.Date;
      return dateTime.ToString("yyyy-MM-dd") + ".txt";
    }

    public static bool ErrorRoutine(bool bLogType, System.Exception objException)
    {
      bool flag;
      try
      {
        if (!TramTronLogger.CheckLoggingEnabled())
        {
          flag = true;
        }
        else
        {
          if (bLogType)
          {
            string str = "ErrorSample";
            if (!EventLog.SourceExists(str))
              EventLog.CreateEventSource(objException.Message, str);
            new EventLog() { Source = str }.WriteEntry(objException.Message, EventLogEntryType.Error);
          }
          else if (!TramTronLogger.CustomErrorRoutine(objException))
            return false;
          flag = true;
        }
      }
      catch (System.Exception ex)
      {
        flag = false;
      }
      return flag;
    }

    private static bool CheckLoggingEnabled()
    {
      string empty = string.Empty;
      string statusConfigFileName = TramTronLogger.GetLoggingStatusConfigFileName();
      return statusConfigFileName.Equals(string.Empty) || TramTronLogger.GetValueFromXml(statusConfigFileName);
    }

    private static string GetLoggingStatusConfigFileName()
    {
      string path1 = AppDomain.CurrentDomain.BaseDirectory + "LoggingStatus.Config";
      if (System.IO.File.Exists(path1))
        return path1;
      string path2 = TramTronLogger.GetApplicationPath() + "LoggingStatus.Config";
      return System.IO.File.Exists(path2) ? path2 : string.Empty;
    }

    private static bool GetValueFromXml(string strXmlPath)
    {
      try
      {
        FileStream inStream = new FileStream(strXmlPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.Load((Stream) inStream);
        string str = xmlDocument.GetElementsByTagName("LoggingEnabled").Item(0).InnerText.ToString();
        return !str.Equals("0") && str.Equals("1");
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        return false;
      }
    }

    private static bool CustomErrorRoutine(System.Exception objException)
    {
      string empty = string.Empty;
      string logFilePath;
      if (TramTronLogger._logFilePath.Equals(string.Empty))
      {
        logFilePath = TramTronLogger.GetLogFilePath();
      }
      else
      {
        if (!System.IO.File.Exists(TramTronLogger._logFilePath))
        {
          if (!TramTronLogger.CheckDirectory(TramTronLogger._logFilePath))
            return false;
          new FileStream(TramTronLogger._logFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite).Close();
        }
        logFilePath = TramTronLogger._logFilePath;
      }
      bool flag = true;
      if (!TramTronLogger.WriteErrorLog(logFilePath, objException))
        flag = false;
      return flag;
    }

    public static string GetHDDSerial()
    {
      ArrayList arrayList = new ArrayList();
      foreach (ManagementObject managementObject in new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive").Get())
        arrayList.Add((object) new HardDrive()
        {
          Model = managementObject["Model"].ToString(),
          Type = managementObject["InterfaceType"].ToString()
        });
      ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
      int index = 0;
      foreach (ManagementObject managementObject in managementObjectSearcher.Get())
      {
        ((HardDrive) arrayList[index]).SerialNo = managementObject["SerialNumber"] != null ? managementObject["SerialNumber"].ToString() : "None";
        ++index;
        if (arrayList.Count == index)
          break;
      }
      string hddSerial = string.Empty;
      foreach (HardDrive hardDrive in arrayList)
        hddSerial = hardDrive.SerialNo;
      return hddSerial;
    }

    public static string GetComputer_LanIP()
    {
      try
      {
        foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
        {
          if (address.AddressFamily.ToString() == "InterNetwork")
            return address.ToString();
        }
        return "-";
      }
      catch (System.Exception ex)
      {
        return "Local IP Address Not Found!";
      }
    }

    public static string GetComputer_InternetIP()
    {
      try
      {
        return new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Replace("<html><head><title>Current IP Check</title></head><body>Current IP Address: ", string.Empty).Replace("</body></html>", string.Empty);
      }
      catch (System.Exception ex)
      {
        return "Internet IP Not Found!";
      }
    }

    public static string GetLocalIPAddress()
    {
      try
      {
        foreach (IPAddress address in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
        {
          if (address.AddressFamily == AddressFamily.InterNetwork)
            return address.ToString();
        }
        return "-";
      }
      catch (System.Exception ex)
      {
        return "Local IP Address Not Found!";
      }
    }

    private static bool WriteErrorLog(string strPathName, System.Exception objException)
    {
      string empty = string.Empty;
      try
      {
        TramTronLogger._sw = new StreamWriter(strPathName, true);
        TramTronLogger._sw.WriteLine("Source\t\t: " + objException.Source.ToString().Trim());
        TramTronLogger._sw.WriteLine("Method\t\t: " + objException.TargetSite.Name.ToString());
        StreamWriter sw1 = TramTronLogger._sw;
        DateTime now = DateTime.Now;
        string str1 = "Date\t\t: " + now.ToShortDateString();
        sw1.WriteLine(str1);
        StreamWriter sw2 = TramTronLogger._sw;
        now = DateTime.Now;
        string str2 = "Time\t\t: " + now.ToLongTimeString();
        sw2.WriteLine(str2);
        TramTronLogger._sw.WriteLine("Computer\t: " + Dns.GetHostName().ToString());
        TramTronLogger._sw.WriteLine("Error\t\t: " + objException.Message.ToString().Trim());
        TramTronLogger._sw.WriteLine("Inner\t\t: " + (objException.InnerException != null ? objException.InnerException.Message : string.Empty));
        TramTronLogger._sw.WriteLine("Stack Trace\t: " + objException.StackTrace.ToString().Trim());
        TramTronLogger._sw.WriteLine("==================================================================");
        TramTronLogger._sw.Flush();
        TramTronLogger._sw.Close();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    private static bool WriteOperationLog(string strPathName, string actionOper)
    {
      string empty = string.Empty;
      try
      {
        TramTronLogger._sw = new StreamWriter(strPathName, true);
        TramTronLogger._sw.WriteLine("User\t\t: " + GlobalValues.DisplayUser);
        StreamWriter sw1 = TramTronLogger._sw;
        DateTime now = DateTime.Now;
        string str1 = "Date\t\t: " + now.ToShortDateString();
        sw1.WriteLine(str1);
        StreamWriter sw2 = TramTronLogger._sw;
        now = DateTime.Now;
        string str2 = "Time\t\t: " + now.ToLongTimeString();
        sw2.WriteLine(str2);
        TramTronLogger._sw.WriteLine("Computer\t: " + Dns.GetHostName().ToString());
        TramTronLogger._sw.WriteLine("Description\t: " + actionOper);
        TramTronLogger._sw.WriteLine("==================================================================");
        TramTronLogger._sw.Flush();
        TramTronLogger._sw.Close();
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    private static bool WriteString(string strPathName, List<string> list)
    {
      string empty = string.Empty;
      try
      {
        if (list != null)
        {
          TramTronLogger._sw = new StreamWriter(strPathName, true);
          TramTronLogger._sw.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
          TramTronLogger._sw.WriteLine("Date\t\t: " + DateTime.Now.ToShortDateString());
          TramTronLogger._sw.WriteLine("Time\t\t: " + DateTime.Now.ToLongTimeString());
          foreach (string str in list)
            TramTronLogger._sw.WriteLine(str);
          TramTronLogger._sw.WriteLine("==================================================================");
          TramTronLogger._sw.Flush();
          TramTronLogger._sw.Close();
        }
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    private static string GetLogFilePath()
    {
      string logFilePath;
      try
      {
        string str = AppDomain.CurrentDomain.BaseDirectory + AppDomain.CurrentDomain.RelativeSearchPath + "//LogFile.txt";
        if (System.IO.File.Exists(str))
          logFilePath = str;
        else if (!TramTronLogger.CheckDirectory(str))
        {
          logFilePath = string.Empty;
        }
        else
        {
          new FileStream(str, FileMode.OpenOrCreate, FileAccess.ReadWrite).Close();
          logFilePath = str;
        }
      }
      catch (System.Exception ex)
      {
        logFilePath = string.Empty;
      }
      return logFilePath;
    }

    private static bool CheckDirectory(string strLogPath)
    {
      try
      {
        int length = strLogPath.Trim().LastIndexOf("\\");
        string path = strLogPath.Trim().Substring(0, length);
        if (!Directory.Exists(path))
          Directory.CreateDirectory(path);
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    private static string GetApplicationPath()
    {
      try
      {
        string str1 = AppDomain.CurrentDomain.BaseDirectory.ToString();
        int length1 = str1.LastIndexOf("\\");
        string str2 = string.Empty;
        if (0 < length1)
          str2 = str1.Substring(0, length1);
        int length2 = str2.LastIndexOf("\\");
        string str3 = string.Empty;
        if (0 < length2)
          str3 = str2.Substring(0, length2);
        return str3.Replace("bin", "");
      }
      catch (System.Exception ex)
      {
        return string.Empty;
      }
    }

    public static string LogFile
    {
      set
      {
        TramTronLogger._logFile = value;
        TramTronLogger._logFilePath = Path.Combine(TramTronLogger._logPath, TramTronLogger._logFile);
      }
    }

    public static string LogPath
    {
      set
      {
        TramTronLogger._logPath = value;
        TramTronLogger._logFilePath = Path.Combine(TramTronLogger._logPath, TramTronLogger._logFile);
      }
    }

    public static string LogFilePath
    {
      get => TramTronLogger._logFilePath;
      set => TramTronLogger._logFilePath = value;
    }
  }
}
