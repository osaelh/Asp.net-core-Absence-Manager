using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Data
{
    public class AbsenceHistory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("RequestingStudentId")]
        public Student RequestingStudent { get; set; }
        public string RequestingStudentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("AbsenceTypeId")]
        public AbsenceType AbsenceType { get; set; }
        public int AbsenceTypeId { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ActionDate { get; set; }
        public bool? Approved { get; set; }
        [ForeignKey("ApprovedById")]
        public Student ApprovedBy { get; set; }
        public string ApprovedById { get;set; }
    }
}
