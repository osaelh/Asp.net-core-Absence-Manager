using AbsenceManager.Contract;
using AbsenceManager.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Repository
{
    public class AbsenceRequestRepository : IAbsenceRequestRepository
    {
        private readonly ApplicationDbContext _db;
        public AbsenceRequestRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(AbsenceRequest entity)
        {
            _db.AbsenceRequests.Add(entity);
            return Save();
        }

        public bool Delete(AbsenceRequest entity)
        {
            _db.AbsenceRequests.Remove(entity);
            return Save();
        }

        public ICollection<AbsenceRequest> GetAll()
        {
            var AbsenceHistories = _db.AbsenceRequests
                .Include(x=>x.RequestingStudent)
                .Include(x=>x.AbsenceType)
                .Include(x=>x.ApprovedBy)
                .ToList();
            return AbsenceHistories;
        }

        public AbsenceRequest GetById(int id)
        {
            var AbsenceHistory = _db.AbsenceRequests
                .Include(x=>x.RequestingStudent)
                .Include(x=>x.AbsenceType)
                .Include(x=>x.ApprovedBy)
                .FirstOrDefault(x=>x.Id==id)
                ;
            return AbsenceHistory;
        }

        public bool IsExist(int id)
        {
            var exists = _db.AbsenceRequests.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var Changes = _db.SaveChanges();
            return Changes > 0;
        }

        public bool Update(AbsenceRequest entity)
        {
            _db.AbsenceRequests.Update(entity);
            return Save();
        }
    }
}
