using AutoMapperQueryProjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperQueryProjection.Controllers
{
    [ApiController]
    [Route("person")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var result = await _personService.GetAll();
            return Ok(result);
        }
    }
}
