using EstudoWebApiAspNetCore.Models;
using EstudoWebApiAspNetCore.Services;
using EstudoWebApiAspNetCore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstudoWebApiAspNetCore.Controllers
{
    [Route("api/palavras")]
    public class PalavrasController : ControllerBase 
    {
        private readonly IPalavraService _service;
        public PalavrasController(IPalavraService service)
        {
            _service = service;
        }


        [HttpPost]
        public ActionResult Cadastrar([FromBody] Palavra palavra)
        {
            _service.Cadastrar(palavra);
            return Ok(true);
        }

        [HttpGet]
        public ActionResult ObterTodas()
        {
            var result = _service.Todas();
            return Ok(result);
        }

        [HttpGet("{id}", Name = "ObterPalavra")]
        public ActionResult obter(int id) {
            var result = _service.Obter(id);
            return Ok(result);
        }
    }
}
