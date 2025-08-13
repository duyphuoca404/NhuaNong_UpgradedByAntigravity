// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.ServiceConfig
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

//using System.Data.EntityClient;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;

#nullable disable
namespace NhuaNong.Utils
{
  public class ServiceConfig : ConfigBase
  {
    private const string FILENAME = "ServiceConfig.xml";
    private const string CONFIG_PATH = "/configuration/Service";

    public ServiceConfig()
      : base("ServiceConfig.xml", "/configuration/Service")
    {
    }

    public string DataProvider
    {
      get => this[nameof (DataProvider)];
      set => this[nameof (DataProvider)] = value;
    }

    public string ServerName
    {
      get => this[nameof (ServerName)];
      set => this[nameof (ServerName)] = value;
    }

    public string DatabaseName
    {
      get => this[nameof (DatabaseName)];
      set => this[nameof (DatabaseName)] = value;
    }

    public string UserID
    {
      get => this[nameof (UserID)];
      set => this[nameof (UserID)] = value;
    }

    public string Password
    {
      get => this[nameof (Password)];
      set => this[nameof (Password)] = value;
    }

    public string ConnectionString
    {
      get
      {
        string connectionString = string.Empty;
        switch (this.DataProvider)
        {
          case "System.Data.SqlClient":
            connectionString = new EntityConnectionStringBuilder()
            {
              Metadata = "res://*",
              Provider = "System.Data.SqlClient",
              ProviderConnectionString = new SqlConnectionStringBuilder()
              {
                InitialCatalog = this.DatabaseName,
                DataSource = this.ServerName,
                IntegratedSecurity = false,
                UserID = this.UserID,
                Password = this.Password
              }.ConnectionString
            }.ConnectionString;
            break;
        }
        return connectionString;
      }
    }
  }
}
