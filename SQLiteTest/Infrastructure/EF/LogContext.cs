using SQLiteTest.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTest.Infrastructure.EF
{
    [DbConfigurationType(typeof(LogDbConfiguration))]
    public class LogContext : DbContext
    {
        public LogContext()
            : base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = "QlikLogDatabase.sqlite.db", ForeignKeys = true}.ConnectionString
            }, true)
        {
            Database.SetInitializer<LogContext>(new CreateDatabaseIfNotExists<LogContext>());
        }

        public DbSet<ScriptLog> ScriptLogs { get; set; }
    }
}
