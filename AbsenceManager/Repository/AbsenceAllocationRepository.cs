﻿using AbsenceManager.Contract;
using AbsenceManager.Data;
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

        public ICollection<AbsenceAllocation> GetAll()
        {
           var AbsenceAllocations  = _db.AbsenceAllocations.ToList();
            return AbsenceAllocations;
        }

        public AbsenceAllocation GetById(int id)
        {
            var AbsenceAllocation = _db.AbsenceAllocations.Find(id);
            return AbsenceAllocation;
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