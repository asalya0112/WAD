using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsRecordSystem.Models;
using StudentsRecordSystem.Repository;
using System.Transactions;
using StudentsRecordSystem.DAL;

namespace StudentsRecordSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    
        
        public class StudentController : ControllerBase
        {
            private readonly IStudentRepository _studentRepository;
            public StudentController(IStudentRepository studentRepository)
            {
                _studentRepository = studentRepository;
            }
            // GET: api/Student
            [HttpGet]
            public IActionResult Get()
            {
                var students = _studentRepository.GetStudents();
                return new OkObjectResult(students);
                //return new string[] { "value1", "value2" };
            }
            // GET: api/Student/5
            [HttpGet, Route("{id}", Name = "GetS")]
            public IActionResult Get(int id)
            {
                var student = _studentRepository.GetStudentById(id);
                return new OkObjectResult(student);
                //return "value";
            }
            // POST: api/Student
            [HttpPost]
            public IActionResult Post([FromBody] Student student)
            {
                using (var scope = new TransactionScope())
                {
                    _studentRepository.InsertStudent(student);
                    scope.Complete();
                    return CreatedAtAction(nameof(Get), new { id = student.Id }, student);
                }
            }
            // PUT: api/Student/5
            [HttpPut("{id}")]
            public IActionResult Put([FromBody] Student student)
            {
                if (student != null)
                {
                    using (var scope = new TransactionScope())
                    {
                        _studentRepository.UpdateStudent(student);
                        scope.Complete();
                        return new OkResult();
                    }
                }
                return new NoContentResult();
            }
            // DELETE: api/ApiWithActions/5
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                _studentRepository.DeleteStudent(id);
                return new OkResult();
            }
        }
    }

