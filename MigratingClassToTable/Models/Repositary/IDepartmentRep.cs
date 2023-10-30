using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratingClassToTable.Models.Repositary
{
    internal interface IDepartmentRep
    {
        public List<Department> GetAllData();
    }
}
