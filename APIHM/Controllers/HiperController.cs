using APIHM.Services;
using APIHM.Services.Interfaces;
using APIHM.Validator;
using AutoMapper;
using Common;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Collections.Generic;
using Repository.Entities;
using Repository.Repositories;


namespace APIHM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HiperController : ControllerBase
    {
        private readonly IHiperService _hiperService;
        public readonly IMapper _mapper;
        public HiperController(IHiperService hiperService, IMapper mapper)
        {
            _hiperService = hiperService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost("Create")]
        public IActionResult Add(HiperModel model)
        {
            _hiperService.AddHiper(new HiperModel()
            {
                PersonId = model.PersonId,
                Date = DateTime.UtcNow,
                Sistolica = model.Sistolica,
                Diastolica = model.Diastolica,
                Batimentos = model.Batimentos
            });

            return Ok(new { response = "Está criado" });
        }

        [HttpPost("GetFromPerson")]
        public IActionResult GetFromPerson(int id)
        {
            var result = _hiperService.GetFromPerson(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("GetPeriod")]
        public IActionResult GetPeriod(DataModel data)
        {
            var result = _hiperService.HiperPeriod(data);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPatch("Update")]
        public IActionResult Update(HiperModel hiper)
        {
            _hiperService.UpdateHiper(hiper);

            return Ok(new { response = "Está atualizado" });
        }

        [HttpDelete()]
        public IActionResult Delete(int id)
        {
            _hiperService.DeleteHiper(id);

            return Ok(new { response = "OK" });
        }
    }
}
