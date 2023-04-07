using StudentsRecordSystem.DAL;
using StudentsRecordSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentsRecordSystem.Repository
{
    public class ModuleRepository: IModuleRepository
    {
        private readonly StudentContext _dbContext;
        public ModuleRepository(StudentContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteModule(int moduleid)
        {
            var module = _dbContext.Modules.Find(moduleid);
            _dbContext.Modules.Remove(module);
            Save();
        }
        public Module GetModuleById(int Id)
        {
            var cate = _dbContext.Modules.Find(Id);
            return cate;
        }
        public IEnumerable<Module> GetModule()
        {
            return _dbContext.Modules.ToList();
        }
        public void InsertModule(Module module)
        {
            _dbContext.Add(module);
            Save();
        }
        public void UpdateModule(Module module)
        {
            _dbContext.Entry(module).State =
           Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void DeleteModule(Module module)
        {
            throw new System.NotImplementedException();
        }

        public void InsertModule(System.Reflection.Module module)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateModule(System.Reflection.Module module)
        {
            throw new System.NotImplementedException();
        }
    }
}
