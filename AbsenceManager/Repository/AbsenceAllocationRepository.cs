using AbsenceManager.Contract;
using AbsenceManager.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Repository
{
    public class AbsenceAllocationRepository : IAbsenceAllocationRepository
    {
        private readonly ApplicationDbContext _db;
        public AbsenceAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CheckAllocation(int AbsenceTypeId, string StudentId)
        {
            var period = DateTime.Now.Year;
            return GetAll()
                .Where(q => q.StudentId == StudentId && q.AbsenceTypeId == AbsenceTypeId && q.Period == period)
                .Any();
        }

        public bool Create(Data.AbsenceAllocation entity)
        {
            _db.AbsenceAllocations.Add(entity);
             return Save();
        }

        public bool Delete(AbsenceAllocation entity)
        {
            _db.AbsenceAllocations.Remove(entity);
            return Save();
        }

        public ICollection<AbsenceAllocation> GetAbsenceAllocationsByStudent(string id)
        {
            var period = DateTime.Now.Year;
            return GetAll()
                .Where(q => q.StudentId == id && q.Period==period)
                .ToList();
        }

        public ICollection<AbsenceAllocation> GetAll()
        {
            var AbsenceAllocations = _db.AbsenceAllocations
                .Include(q => q.AbsenceType)
                .Include(q=>q.Student)
                .ToList();
            return AbsenceAllocations;
        }

        public AbsenceAllocation GetById(int id)
        {
            var AbsenceAllocation = _db.AbsenceAllocations
                .Include(q => q.AbsenceType)
                .Include(q => q.Student)
                .FirstOrDefault(q=>q.Id==id);


            return AbsenceAllocation;
        }

        public bool IsExist(int id)
        {
            var exists = _db.AbsenceAllocations.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(AbsenceAllocation entity)
        {
            _db.AbsenceAllocations.Update(entity);
            return Save();
        }
    }
}
