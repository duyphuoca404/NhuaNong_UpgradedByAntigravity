// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.Validation
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

#nullable disable
namespace NhuaNong.Utils
{
  public class Validation
  {
    private const string CONNECTION_STRING = "server={0};database={1};user id={2};pwd={3}";

    public static int ValidateDatabase(
      string server,
      string database,
      string username,
      string password)
    {
      string empty = string.Empty;
      try
      {
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select name from sysDataBases", new SqlConnection(string.Format("server={0};database={1};user id={2};pwd={3}", (object) server, (object) "master", (object) username, (object) password)));
        DataSet dataSet1 = new DataSet();
        DataSet dataSet2 = dataSet1;
        sqlDataAdapter.Fill(dataSet2, "TableNames");
        foreach (DataRow row in (InternalDataCollectionBase) dataSet1.Tables["TableNames"].Rows)
        {
          if (database == row[0].ToString())
            return 1;
        }
        return 0;
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        return -1;
      }
    }

    public static bool ValidateDBConnection(
      string server,
      string database,
      string username,
      string password)
    {
      SqlConnection sqlConnection = new SqlConnection(string.Format("server={0};database={1};user id={2};pwd={3}", (object) server, (object) database, (object) username, (object) password));
      try
      {
        sqlConnection.Open();
        return true;
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        return false;
      }
      finally
      {
        if (sqlConnection.State != ConnectionState.Closed)
          sqlConnection.Close();
      }
    }

    public static bool ValidateServerIPConnection(string serverIP)
    {
      try
      {
        PingReply pingReply;
        using (Ping ping = new Ping())
          pingReply = ping.Send(serverIP);
        return pingReply.Status == IPStatus.Success;
      }
      catch (PingException ex)
      {
        TramTronLogger.WriteError((System.Exception) ex);
        return false;
      }
    }
  }
}
