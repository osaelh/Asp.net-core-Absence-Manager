using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Models
{
    public class AbsenceHistoryViewModel
    {
        public int Id { get; set; }
        public StudentViewModel RequestingStudent { get; set; }
        public string RequestingStudentId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public DetailsAbsenceTypeViewModel AbsenceType { get; set; }
        public IEnumerable<SelectListItem> AbsenceTypes { get; set; }
        public int AbsenceTypeId { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ActionDate { get; set; }
        public bool? Approved { get; set; }
        public StudentViewModel ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
    }
}
