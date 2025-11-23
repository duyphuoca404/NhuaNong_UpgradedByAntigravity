// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.BKDatabase
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Data.Entity;

#nullable disable
namespace NhuaNong.Utils
{
  public class BKDatabase
  {
    private readonly string _connectionString;

    public BKDatabase(string connectionString) => this._connectionString = connectionString;

    public static void BackupDatabase(string databaseName)
    {
      string sql = "BACKUP DATABASE " + databaseName + " TO DISK = 'D:\\Uduino\\TT.BAK'";
      using (DEPTramTronEntities tramTronEntities = new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString))
        tramTronEntities.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sql);
    }
  }
}
