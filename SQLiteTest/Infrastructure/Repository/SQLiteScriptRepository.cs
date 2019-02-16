using SQLiteTest.Core.Model;
using SQLiteTest.Core.Repository;
using SQLiteTest.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTest.Infrastructure.Repository
{
    public class ScriptRepository : IScriptRepository
    {
        private readonly LogContext _context;

        public ScriptRepository()
        {
            _context = new LogContext();
        }

        public void AddScriptLog(ScriptLog log)
        {
            _context.ScriptLogs.Add(log);
            _context.SaveChanges();
        }

        public IEnumerable<ScriptLog> Browse()
        {
            return _context.ScriptLogs.ToList();
        }

        public ScriptLog Get(int id)
        {
            return _context.ScriptLogs.Single(x => x.Id == id);
        }
    }
}
