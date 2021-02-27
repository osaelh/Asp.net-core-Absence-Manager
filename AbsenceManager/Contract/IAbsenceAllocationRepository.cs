using AbsenceManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Contract
{
   public interface IAbsenceAllocationRepository:IRepositoryBase<AbsenceAllocation>
    {
      bool CheckAllocation(int AbsenceTypeId, string StudentId);
        ICollection<AbsenceAllocation> GetAbsenceAllocationsByStudent(string id);
    }
}
