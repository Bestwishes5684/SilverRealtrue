using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SilverRealtrue.ModelsAndContex
{
    public partial class Check
    {
        [Display(Name ="Номер чека")]
        public int IdCheck { get; set; }

        [Display(Name = "Дата создания чека ")]
        public DateTime? DateCheck { get; set; }

        [Display(Name = "Департамент")]
        public int? DepartmentCheck { get; set; }

        [Display(Name = "Норма Серебра")]
        public string NormCheck { get; set; }

        [Display(Name = "тип серебра")]
        public int SilverTypeCheck { get; set; }

        [Display(Name = "Площадь покрытия")]
        public decimal? CoverageCheck { get; set; }
        [Display(Name = "Количество")]
        public int? AmountCheck { get; set; }
        [Display(Name = "Децимальный номер")]
        public int DecimalCheck { get; set; }

        [Display(Name = "Номер заказа")]
        public string? OrderCheck { get; set; }


    
        public virtual DecimalNumber DecimalCheckNavigation { get; set; }
      
        public virtual SilverType SilverTypeCheckNavigation { get; set; }
    }
}
