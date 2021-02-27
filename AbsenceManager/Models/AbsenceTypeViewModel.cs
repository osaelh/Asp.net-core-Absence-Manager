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
        [Required]
        [Display(Name ="Default number of days")]
        [Range(1,25,ErrorMessage ="Please enter a valid number")]
        public int DefaultDays { get; set; }
        [Display(Name ="Creation Date")]
        public DateTime?  DateCreated { get; set; }
    }
    public class CreateAbsenceTypeViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Default number of days")]
        [Range(1, 25, ErrorMessage = "Please enter a valid number")]
        public int DefaultDays { get; set; }
    }
}
