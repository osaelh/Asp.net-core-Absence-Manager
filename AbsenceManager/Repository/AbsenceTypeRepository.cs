using AbsenceManager.Contract;
using AbsenceManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbsenceManager.Repository
{
    public class AbsenceTypeRepository : IAbsenceTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public AbsenceTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(AbsenceType entity)
        {
           var AbsenceType = _db.AbsenceTypes.Add(entity);
            return Save();
        }

        public bool Delete(AbsenceType entity)
        {
            _db.AbsenceTypes.Remove(entity);
            return Save();
        }

        public ICollection<AbsenceType> GetAll()
        {
            var AbsenceTypes = _db.AbsenceTypes.ToList();
           return AbsenceTypes;
        }

        public AbsenceType GetById(int id)
        {
            var AbsenceType = _db.AbsenceTypes.Find(id);
            return AbsenceType;
        }

        public ICollection<AbsenceType> GetStudentsByAbsenceType(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(int id)
        {
            var exists = _db.AbsenceTypes.Any(q => q.Id == id);
            return exists;
        }

        public bool Save()
        {
          var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(AbsenceType entity)
        {
            _db.AbsenceTypes.Update(entity);
            return Save();
        }
    }
}
