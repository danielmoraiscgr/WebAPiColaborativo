using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using WebAPiColaborativo.Data;
using WebAPiColaborativo.Interfaces;

namespace WebAPiColaborativo.Model
{
    public class Professor :IProfessor
    {
        public Professor(int id, string nome, string graduacao)
        {
            Id = id;
            Nome = nome;
            Graduacao = graduacao;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Graduacao { get; set; }

        private readonly DbContext _dbContext;

        public Professor()
        {
            _dbContext = new DbContext();
        }

        public List<Professor> GetProfessores()
        {
            var json = File.ReadAllText(_dbContext.CaminhoBancoProfessores());
            var listaDisciplinas = JsonConvert.DeserializeObject<List<Professor>>(json);

            return listaDisciplinas;
        }

        public Professor GetById(int id)
        {
            var listaProfessores = this.GetProfessores();
            var professor = listaProfessores.SingleOrDefault(p => p.Id == id);           

            return professor;
        }


    }
}
