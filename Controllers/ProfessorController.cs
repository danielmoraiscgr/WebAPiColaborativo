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
    public class ProfessorController : ControllerBase
    {
        private readonly Professor _professores;

        public ProfessorController()
        {
            _professores = new Professor();

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_professores.GetProfessores());
        }

        [HttpGet("api/graduacao/{id}")]
        public ProfessorGraduacaoViewModel BuscarGraduacaoProfessorById(int id)
        {
            var listaProfessores = _professores.GetProfessores();

            var professor = listaProfessores.Where(p => p.Id == id).FirstOrDefault();

            if (professor != null)
            {
                return new ProfessorGraduacaoViewModel(professor.Graduacao);
            }

            return null; 
        }
    }
}
