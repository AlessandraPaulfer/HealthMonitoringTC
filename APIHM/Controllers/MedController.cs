using APIHM.Services.Interfaces;
using AutoMapper;
using Common;
using Microsoft.AspNetCore.Mvc;

namespace APIHM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedController : ControllerBase
    {
        private readonly IMedService _medService;
        public readonly IMapper _mapper;
        public MedController(IMedService medService, IMapper mapper)
        {
            _medService = medService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("Create")]
        public IActionResult Add(MedModel model)
        {
            _medService.AddMed(new MedModel()
            {
                PersonId = model.PersonId,
                Date = DateTime.UtcNow,
                Descri = model.Descri,
                Quantity = model.Quantity,
                Type = model.Type
            });

            return Ok(new { response = "Está criado" });
        }

        [HttpPost("GetFromPerson")]
        public IActionResult GetFromPerson(int id)
        {
            var result = _medService.GetFromPerson(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPatch("Update")]
        public IActionResult Update(MedModel med)
        {
            _medService.UpdateMed(med);

            return Ok(new { response = "Está atualizado" });
        }

        [HttpDelete()]
        public IActionResult Delete(int id)
        {
            _medService.DeleteMed(id);

            return Ok(new { response = "OK" });
        }
    }
}
