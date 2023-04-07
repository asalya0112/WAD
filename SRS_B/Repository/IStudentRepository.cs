using StudentsRecordSystem.Models;
using System.Collections;
using System.Collections.Generic;

namespace StudentsRecordSystem.Repository
{
    public interface IStudentRepository
    {
        void InsertStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);
        Student GetStudentById(int id);
        IEnumerable<Student> GetStudents();
        void DeleteStudent(int id);
    }
}
