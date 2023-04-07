using StudentsRecordSystem.Models;
using System.Collections.Generic;

namespace StudentsRecordSystem.Repository
{
    public interface IModuleRepository
    {
        void InsertModule(Module module);
        void UpdateModule(Module module);
        void DeleteModule(Module module);
        Module GetModuleById(int Id);
        IEnumerable<Module> GetModule();
        void InsertModule(System.Reflection.Module module);
        void UpdateModule(System.Reflection.Module module);
        void DeleteModule(int id);
    }
}
