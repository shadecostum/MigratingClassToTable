using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratingClassToTable.Models
{
    internal class WorkStation
    {
        public int Id { get; set; }

        public string WsCode { get; set; }

        public string Floor { get; set; }

        public Employee Employee { get; set; }
    }
}
