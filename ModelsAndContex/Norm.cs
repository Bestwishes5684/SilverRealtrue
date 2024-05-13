using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverRealtrue.ModelsAndContex
{
    public partial class Norm
    {
        public int IdNorm { get; set; }

        public int DecimalNorm { get; set; }

        public int SilverTypeNorm { get; set; }

        public string TitleNorm { get; set; }

        public int DepartmentNorm { get; set; }

        public virtual DecimalNumber DecimalNormNavigation { get; set; }

        public virtual SilverType SilverTypeNormNavigation { get; set; }

    }
}
