using AbsenceManager.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Models
{
    public class AbsenceRequestViewModel
    {
        public int Id { get; set; }

        public StudentViewModel RequestingStudent { get; set; }
        [Display(Name = "Requesting Student ID")]
        public string RequestingStudentId { get; set; }
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Absence Type")]
        public AbsenceType AbsenceType { get; set; }
        [Display(Name = "Absence Type Id")]
        public int AbsenceTypeId { get; set; }
        [Display(Name = "Request Date")]
        public DateTime RequestDate { get; set; }
        [Display(Name = "Action Date")]
        public DateTime ActionDate { get; set; }
        [Display(Name = "Status")]
        public bool? Approved { get; set; }
        [Display(Name = "Approuved By")]

        public IdentityUser ApprovedBy { get; set; }
        public string ApprovedById { get; set; }
    }
    public class AdminAbsenceRequestViewModel
    {
        [Display(Name ="Total Requests")]
        public int TotalRequest { get; set; }
        [Display(Name = "Pending Requests")]
        public int PendingRequest { get; set; }
        [Display(Name = "Approuved Requests")]
        public int ApprouvedRequest { get; set; }
        [Display(Name = "Rejected Requests")]
        public int RejectedRequest { get; set; }
        public List<AbsenceRequestViewModel> AbsenceRequests { get; set; }
    }
    public class CreateAbsenceRequestViewModel
    {
        [Required]
        [Display(Name ="Start Date")]
        [DataType(DataType.Date)]
        public string StartDate { get; set; }
        [Required]
        [Display(Name ="End Date")]
        [DataType(DataType.Date)]
        public string EndDate { get; set; }
        public List<SelectListItem> AbsenceTypes { get; set; }
        [Display(Name = "Absence Type")]
        public int AbsenceTypeId { get; set; }
    }
}
