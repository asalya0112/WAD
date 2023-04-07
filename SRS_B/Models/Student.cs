using System;

namespace StudentsRecordSystem.Models
{
    public class Student
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string Course { get; set; }
        public int Age { get; set; }
        public Module StudentModule { get; set; }
        
    }
        
}

