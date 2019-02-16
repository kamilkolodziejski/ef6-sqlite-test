using SQLiteTest.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTest.Core.Repository
{
    public interface IScriptRepository
    {
        void AddScriptLog(ScriptLog log);
        IEnumerable<ScriptLog> Browse();
        ScriptLog Get(int id);
    }
}