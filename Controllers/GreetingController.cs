using Microsoft.AspNetCore.Mvc;
using PraticeAPI.Service.Interface;
using PraticeAPI.Service;
namespace PraticeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreetingController : ControllerBase
    {
        private readonly IGreetingService _greetingService;

        public GreetingController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        [HttpGet("{name}")]
        public IActionResult GetGreeting(string name)
        {
            var greeting = _greetingService.GetGreeting(name);
            return Ok(greeting);
        }
    }
}