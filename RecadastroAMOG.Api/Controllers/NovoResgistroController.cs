using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace RecadastroAMOG.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NovoResgistroController : ControllerBase
    {
        [HttpPost]
        public IActionResult create(ExpandoObject teste)
        {

            return Ok();
        }
    }
}
