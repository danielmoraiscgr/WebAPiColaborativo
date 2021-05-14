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

        [HttpGet("{id}")]
        public Disciplina Get(int id)
        {
            try
            {
                var disciplina = _disciplinas.GetDisciplinas().Where(d => d.Id == id).FirstOrDefault();

                if (disciplina == null)
                {
                    return null;
                }

                return disciplina;
            }
            catch
            {
                return null;

            }
        }

        [HttpPost]
        public Disciplina Post([FromBody] Disciplina disciplina)
        {
            _disciplinas.Inserir(disciplina);

            return disciplina;
        }

        [HttpPut("{id}")]
        public Disciplina Put(int id, [FromBody] Disciplina disciplina)
        {
            _disciplinas.AtualizarDisciplina(id, disciplina);

            return disciplina;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _disciplinas.Deletar(id);
        }

    }
}
