using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverRealtrue.ModelsAndContex
{
    public partial class SilverType
    {
        public SilverType()
        {
            Check = new HashSet<Check>();
        }

        public int CodeSilverType { get; set; }

        [DisplayName("Вид серебра")]
        public string TitleSilverType { get; set; }

        public virtual ICollection<Check> Check { get; set; }
    }
}
