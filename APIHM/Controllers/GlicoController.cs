using APIHM.Services.Interfaces;
using AutoMapper;
using Common;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIHM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GlicoController : ControllerBase
    {
        private readonly IGlicoService _glicoService;
        public readonly IMapper _mapper;
        public GlicoController(IGlicoService glicoService, IMapper mapper)
        {
            _glicoService = glicoService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("Create")]
        public IActionResult Add(GlicoModel model)
        {
            _glicoService.AddGlico(new GlicoModel()
            {
                PersonId = model.PersonId,
                Date = DateTime.UtcNow,
                Value = model.Value,
                Batimentos = model.Batimentos,
                Categoria = model.Categoria
            });

            return Ok(new { response = "Está criado" });
        }

        [HttpPost("GetFromPerson")]
        public IActionResult GetFromPerson(int id)
        {
            var result = _glicoService.GetFromPerson(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPatch("Update")]
        public IActionResult Update(GlicoModel glico)
        {
            _glicoService.UpdateGlico(glico);

            return Ok(new { response = "Está atualizado" });
        }

        [HttpDelete()]
        public IActionResult Delete(int id)
        {
            _glicoService.DeleteGlico(id);

            return Ok(new { response = "OK" });
        }
    }
}
