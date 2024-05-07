using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverRealtrue.ModelsAndContex
{
    public partial class Check
    {
        [DisplayName ("Номер чека")]
        public int IdCheck { get; set; }

        [DisplayName ("Дата создания чека ")]
        public DateTime? DateCheck { get; set; }

        [DisplayName ("Номер цеха")]
        public int? DepartmentCheck { get; set; }

        [DisplayName ("Норма Серебра")]
        public string NormCheck { get; set; }

        [DisplayName ("Вид серебра")]
        public int SilverTypeCheck { get; set; }

        [DisplayName ("Площадь покрытия")]
        public decimal? CoverageCheck { get; set; }
        [DisplayName ("Количество")]
        public int? AmountCheck { get; set; }
        [DisplayName ("Децимальный номер")]
        public int DecimalCheck { get; set; }

        [DisplayName ("Номер заказа")]
        public string? OrderCheck { get; set; }


    
        public virtual DecimalNumber DecimalCheckNavigation { get; set; }
      
        public virtual SilverType SilverTypeCheckNavigation { get; set; }
    }
}
