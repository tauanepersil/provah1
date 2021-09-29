using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prova1bimestre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova1bimestre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculoFreteController : ControllerBase
    {


       [HttpGet]

       public ActionResult ola()
        {
            return Ok("ola");
        }


       [HttpPost("CalcularFrete")]


       public ActionResult CalcularFrete(Dimensoes dimensoes)
        {
            

            if (dimensoes.TipoPostagem == 1) 
            {
                return Ok("Frete escolhido foi PAC :" + ((dimensoes.ComprimentoCm * dimensoes.LarguraCm * dimensoes.AlturaCm ) / 6000));
            }
            if (dimensoes.TipoPostagem == 2)
            {
                return Ok("Frete escolhido foi SEDEX :" + ((dimensoes.ComprimentoCm * dimensoes.LarguraCm * dimensoes.AlturaCm) * 10 / 6000 ));
            }
            if (dimensoes.TipoPostagem == 3)
            {
                return Ok("Frete escolhido foi SEDEX 10 :" + ((dimensoes.ComprimentoCm * dimensoes.LarguraCm * dimensoes.AlturaCm) * 20 / 6000 ));
            }
            if (dimensoes.TipoPostagem == 4)
            {
                return Ok("Frete escolhido foi SEDEX 12 :" + ((dimensoes.ComprimentoCm * dimensoes.LarguraCm * dimensoes.AlturaCm) * 30 / 6000));
            }


            

                return BadRequest("Tipo de frete não informado");
        }
        
         
    }
}
