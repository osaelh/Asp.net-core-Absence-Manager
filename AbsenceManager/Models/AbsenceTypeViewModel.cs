using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Models
{
    public class DetailsAbsenceTypeViewModel
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name ="Creation Date")]
        public DateTime?  DateCreated { get; set; }
    }
    public class CreateAbsenceTypeViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
