using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTest.Core.Model
{
    [Table("SCRIPT_LOGS")]
    public class ScriptLog
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("APP_NAME")]
        public String AppName { get; set; }

        [Column("AUTHOR")]
        public String Author { get; set; }

    }
}
