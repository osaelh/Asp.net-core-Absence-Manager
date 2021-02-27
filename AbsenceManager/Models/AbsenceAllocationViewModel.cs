using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Models
{
    public class AbsenceAllocationViewModel
    {
        public int Id { get; set; }

        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        public int Period { get; set; }

        public StudentViewModel Student { get; set; }
        public string StudentId { get; set; }

        public DetailsAbsenceTypeViewModel AbsenceType { get; set; }
        public int AbsenceTypeId { get; set; }
        public IEnumerable<SelectListItem> Students { get; set; }
        public IEnumerable<SelectListItem> AbsenceTypes { get; set; }
    }
    public class CreateAbsenceAllocationViewModel
    {
        public int NumberUpdated { get; set; }
        public List<DetailsAbsenceTypeViewModel> AbsenceTypes;
    } 
    public class EditAbsenceAllocationViewModel
    {
        public int Id { get; set; }
        public StudentViewModel Student { get; set; }
        public string StudentId { get; set; }
        public int NumberofDays { get; set; }
        public DetailsAbsenceTypeViewModel AbsenceType { get; set; }
    }
    public class ViewAbsenceAllocationViewModel
    {
        public StudentViewModel Student { get; set; }
        public string StudentId { get; set; }
        public List<AbsenceAllocationViewModel> AbsenceAllocations { get; set; }
    }
}
