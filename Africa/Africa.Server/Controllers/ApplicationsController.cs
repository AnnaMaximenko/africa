using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Africa.Server.Data;
using System.ComponentModel.DataAnnotations;

namespace Africa.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : ControllerBase
    {
        private readonly ApplicationsContext _context;

        public ApplicationsController(ApplicationsContext context)
        {
            _context = context;
        }

        // GET: api/Applications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Application>>> GetApplications()
        {
            return await _context.Applications.ToListAsync();
        }

        // GET: api/Applications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CreateApplicationModel>> GetApplication(int id)
        {
            var application = await _context.Applications.FindAsync(id);

            if (application == null)
            {
                return NotFound();
            }
            var result = new CreateApplicationModel();
            result.Name = application.Name;
            result.PhoneNumber = application.PhoneNumber;
            result.Email = application.Email;

            return result;
        }

        // PUT: api/Applications/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplication(int id, Application application)
        {
            if (id != application.Id)
            {
                return BadRequest();
            }

            _context.Entry(application).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Applications
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ApplicationCreateResult> PostApplication(CreateApplicationModel applicationModel)
        {
            var application = new Application();
            application.Name = applicationModel.Name;
            application.PhoneNumber = applicationModel.PhoneNumber;
            application.Email = applicationModel.Email;
            

            _context.Applications.Add(application);
            await _context.SaveChangesAsync();

            var result = new ApplicationCreateResult();
            result.Id = application.Id;
            result.Name = application.Name;

            return result;
        }

        // DELETE: api/Applications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplication(int id)
        {
            var application = await _context.Applications.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }

            _context.Applications.Remove(application);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApplicationExists(int id)
        {
            return _context.Applications.Any(e => e.Id == id);
        }
    }
}

public class CreateApplicationModel
{
    public string Name { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }
}

public class ApplicationCreateResult
{
    public int Id { get; set; }
    public string Name { get; set; }
}
