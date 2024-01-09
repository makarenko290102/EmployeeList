using EmployeeList.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeePersonalityController : ControllerBase
    {
        private readonly DataContext _context;

        public EmployeePersonalityController(DataContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult<List<EmployeePersonality>>> AddEmployee(EmployeePersonality employee)
        {
            _context.EmployeePersonalities.Add(employee);
            await _context.SaveChangesAsync();

            return Ok(await _context.EmployeePersonalities.ToListAsync());
        }
        [HttpGet]
        public async Task<ActionResult<List<EmployeePersonality>>> GetAllEmployee()
        {
            return Ok(await _context.EmployeePersonalities.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeePersonality>> GetEmployee(int id)
        {
            var employee = await _context.EmployeePersonalities.FindAsync(id);
            if(employee == null)
            {
                return BadRequest("Сотрудник не найден по ID");
            }
            return Ok(employee);
        }

    }
}
