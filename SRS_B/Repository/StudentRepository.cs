using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.EntityFrameworkCore;
using StudentsRecordSystem.DAL;
using StudentsRecordSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentsRecordSystem.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _dbContext;
        public StudentRepository(StudentContext dbContext)
        {
            _dbContext = dbContext;
        }

       

        public void DeleteStudent(int studentId)
        {
            var student = _dbContext.Students.Find(studentId);
            _dbContext.Students.Remove(student);
            Save();
        }

        public void DeleteStudent(Student student)
        {
            throw new System.NotImplementedException();
        }

        public Student GetStudentById(int studentId)
        {
            var stud = _dbContext.Students.Find(studentId);
            //_dbContext.Entry(stud).Reference(s => s.StudentModule).Load();
            return stud;
        }

        public IEnumerable<Student> GetStudents()
        {
            return _dbContext.Students.ToList();
            //.Include(s => s.StudentModule).ToList();
        }

        public void InsertStudent(Student student)
        {
            student.StudentModule = _dbContext.Modules.Find(student.StudentModule.Id);
            _dbContext.Add(student);
            Save();
        }

        public void UpdateStudent(Student student)
        {
            _dbContext.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}

