﻿using AbsenceManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Contract
{
   public interface IAbsenceTypeRepository: IRepositoryBase<AbsenceType>
    {
        ICollection<AbsenceType> GetStudentsByAbsenceType(int id);
    }
}
