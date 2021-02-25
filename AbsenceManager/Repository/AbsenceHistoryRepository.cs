using AbsenceManager.Contract;
using AbsenceManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Repository
{
    public class AbsenceHistoryRepository : IAbsenceHistoryRepository
    {
        private readonly ApplicationDbContext _db;
        public AbsenceHistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(AbsenceHistory entity)
        {
            _db.AbsenceHistories.Add(entity);
            return Save();
        }

        public bool Delete(AbsenceHistory entity)
        {
            _db.AbsenceHistories.Remove(entity);
            return Save();
        }

        public ICollection<AbsenceHistory> GetAll()
        {
            var AbsenceHistories = _db.AbsenceHistories.ToList();
            return AbsenceHistories;
        }

        public AbsenceHistory GetById(int id)
        {
            var AbsenceHistory = _db.AbsenceHistories.Find(id);
            return AbsenceHistory;
        }

        public bool IsExist(int id)
        {
            var exists = _db.AbsenceHistories.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
            var Changes = _db.SaveChanges();
            return Changes > 0;
        }

        public bool Update(AbsenceHistory entity)
        {
            _db.AbsenceHistories.Update(entity);
            return Save();
        }
    }
}
