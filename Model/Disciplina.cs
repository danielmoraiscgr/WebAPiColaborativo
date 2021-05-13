using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using WebAPiColaborativo.Data;

namespace WebAPiColaborativo.Model
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int CargaHoraria { get; set; }
        public string Professor { get; set; }

        private readonly DbContext _dbContext;

        public Disciplina()
        {
            _dbContext = new DbContext();
        }

        public List<Disciplina> GetDisciplinas()
        {
            var json = File.ReadAllText(_dbContext.CaminhoBanco());
            var listaDisciplinas = JsonConvert.DeserializeObject<List<Disciplina>>(json);

            return listaDisciplinas; 
        }


    }
}
