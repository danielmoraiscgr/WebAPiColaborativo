using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPiColaborativo.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPiColaborativo.Controllers
{
    [Route("api/[controller]")]
    public class DisciplinaController : ControllerBase
    {
        private readonly Disciplina _disciplinas;

        public DisciplinaController()
        {
            _disciplinas = new Disciplina();

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_disciplinas.GetDisciplinas());
        }
    }
}
