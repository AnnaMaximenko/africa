using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using africa.Data;

namespace africa.Controllers
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
