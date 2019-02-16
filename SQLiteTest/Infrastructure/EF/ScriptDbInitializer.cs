using System.Data.Entity;

namespace SQLiteTest.Infrastructure.EF
{
    public class ScriptDbInitializer : CreateDatabaseIfNotExists<LogContext>
    {
    }
}