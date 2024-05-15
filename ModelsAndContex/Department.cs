using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverRealtrue.ModelsAndContex
{
    public partial class Department
    {
        public int CodeDepartment { get; set; }

        public bool IsAtWorkDepartment { get; set; }

        public virtual ICollection<Check> Check { get; set; }

        public virtual ICollection<Norm> Norm { get; set; }

    }
}
