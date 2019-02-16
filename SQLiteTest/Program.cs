using SQLiteTest.Core.Model;
using SQLiteTest.Core.Repository;
using SQLiteTest.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            IScriptRepository repository = new ScriptRepository();
            ScriptLog log = new ScriptLog();
            log.AppName = "Test";
            log.Author = "test";
            repository.AddScriptLog(log);
            var logs  = repository.Browse();
            foreach(ScriptLog tmpLog in logs) 
            {
                Console.WriteLine($"ID: {tmpLog.Id}\tApp Name: {tmpLog.AppName}\t{(tmpLog.Author != null ? $"Author: {tmpLog.Author}" : "")}");
            }
            Console.ReadKey();
        }
    }
}
