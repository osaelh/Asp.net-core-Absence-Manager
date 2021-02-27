using AbsenceManager.Data;
using AbsenceManager.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Mapping
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<AbsenceType, DetailsAbsenceTypeViewModel>().ReverseMap();
            CreateMap<AbsenceType, CreateAbsenceTypeViewModel>().ReverseMap();
            CreateMap<AbsenceHistory, AbsenceHistoryViewModel>().ReverseMap();
            CreateMap<AbsenceAllocation, AbsenceAllocationViewModel>().ReverseMap();
            CreateMap<AbsenceAllocation, EditAbsenceAllocationViewModel>().ReverseMap();
            CreateMap<Student, StudentViewModel>().ReverseMap();

        }
    }
}
