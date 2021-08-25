using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Technical_Challenge.Models;

namespace Technical_Challenge.Controllers
{
    public class DivisoresController : MainController
    {
        [HttpGet("{entrada:int}")]
        public async Task<ActionResult> ObterDivisores(int entrada)
        {
            //if (entrada <= 0) return BadRequest();

             var CalculoDivisor =  await Calcular(entrada);
            return Ok(CalculoDivisor);
        }

        private Task<CalculoDivisor> Calcular(int entrada)
        {
            CalculoDivisor calculoDivisor = new CalculoDivisor();
            calculoDivisor.ObterDivisores(entrada);

            return Task.FromResult(calculoDivisor);
        }
    }
}
