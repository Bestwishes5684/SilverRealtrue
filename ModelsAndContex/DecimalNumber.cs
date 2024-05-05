using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverRealtrue.ModelsAndContex
{
    public partial class DecimalNumber
    {
        public DecimalNumber()
        {
            Check = new HashSet<Check>();
        }

        public int IdDecimal { get; set; }
        public string TitleDecimal { get; set; }

        public virtual ICollection<Check> Check { get; set; }
    }
}
