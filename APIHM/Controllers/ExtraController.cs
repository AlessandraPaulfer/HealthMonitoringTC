using APIHM.Services.Interfaces;
using AutoMapper;
using Common;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIHM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExtraController : ControllerBase
    {
        private readonly IExtraService _extraService;
        public readonly IMapper _mapper;
        public ExtraController(IExtraService extraService, IMapper mapper)
        {
            _extraService = extraService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("Create")]
        public IActionResult Add(ExtraModel model)
        {
            _extraService.AddExtra(new ExtraModel()
            {
                PersonId = model.PersonId,
                Date = DateTime.UtcNow,
                Descri = model.Descri,
                Quantity = model.Quantity
            });

            return Ok(new { response = "Está criado" });
        }

        [HttpPost("GetFromPerson")]
        public IActionResult GetFromPerson(int id)
        {
            var result = _extraService.GetFromPerson(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPatch("Update")]
        public IActionResult Update(ExtraModel med)
        {
            _extraService.UpdateExtra(med);

            return Ok(new { response = "Está atualizado" });
        }

        [HttpDelete()]
        public IActionResult Delete(int id)
        {
            _extraService.DeleteExtra(id);

            return Ok(new { response = "OK" });
        }
    }
}
