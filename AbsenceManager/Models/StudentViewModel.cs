using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Models
{
    public class StudentViewModel
    {
        public string Id { get; set; }
        [Display(Name ="Username :")]
        public string UserName { get; set; }
        public string Email { get; set; }
        [Display(Name ="First Name :")]
        public string FirstName { get; set; }
        [Display(Name ="Last Name :")]
        public string LastName { get; set; }
        public string Adress { get; set; }
        [Display(Name ="Date Of Birth :")]
        public DateTime DateOfBirth { get; set; }
    }
}
