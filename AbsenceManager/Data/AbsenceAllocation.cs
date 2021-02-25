using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Data
{
    public class AbsenceAllocation
    {
        [Key]
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        public string StudentId { get; set; }
        [ForeignKey("AbsenceTypeId")]
        public AbsenceType AbsenceType { get; set; }
        public int AbsenceTypeId { get; set; }
    }
}
