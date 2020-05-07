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
        //APP -- /api/palavras
        [Route("")]
        [HttpGet]
        public ActionResult ObterTodas()
        {
            return Ok(true);
        }
    }
}
