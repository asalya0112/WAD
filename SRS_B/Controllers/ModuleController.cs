using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsRecordSystem.Models;
using StudentsRecordSystem.Repository;
using System.Transactions;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentsRecordSystem.Controllers
{
    [Route("api/Module")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        private readonly IModuleRepository _moduleRepository;
        public ModuleController(IModuleRepository moduleRepository)
        {
            _moduleRepository = moduleRepository;
        }
        // GET: api/Module
        [HttpGet]
        public IActionResult Get()
        {
            var module = _moduleRepository.GetModule();
            return new OkObjectResult(module);
        }
        // GET: api/Module/5
        [HttpGet("{id}", Name = "GetM")]
        public IActionResult Get(int id)
        {
            var module = _moduleRepository.GetModuleById(id);
            return new OkObjectResult(module);
        }
        // POST: api/Module
        [HttpPost]
        public IActionResult Post([FromBody] Module module)
        {
            using (var scope = new TransactionScope())
            {
                _moduleRepository.InsertModule(module);
                scope.Complete();
                return CreatedAtAction(nameof(Get),  new { id = module.Id }, module);
            }
        }
        // PUT: api/Module/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Module module)
        {
            if (module != null)
            {
                using (var scope = new TransactionScope())
                {
                    _moduleRepository.UpdateModule(module);
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
            _moduleRepository.DeleteModule(id);
            return new OkResult();
        }
    }
}
