using Application.Services;

using CodeChallenge.Extensions;
using CodeChallenge.Models;

using Microsoft.AspNetCore.Mvc;

namespace CodeChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodeChallengeController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<CodeChallengeController> _logger;
        private readonly IEmployeeService employeeService;

        public CodeChallengeController(ILogger<CodeChallengeController> logger, IEmployeeService employeeService)
        {
            _logger = logger;
            this.employeeService = employeeService;
        }

        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            try
            {
                var listEmployee = employeeService.GetAllEmployee();
                return listEmployee.ToControllerEmployee();
            }
            catch (Exception ex)
            {
                return new List<Employee>();
            }

        }

        [HttpGet("SetNewManager")]
        public HttpResult SetNewManager(int idManager, int idEmployee)
        {
            try
            {
                employeeService.SetNewManager(idManager, idEmployee);
                return new HttpResult(200);
            }
            catch(Exception ex)
            {
                return new HttpResult(500);
            }
        }
    }
}