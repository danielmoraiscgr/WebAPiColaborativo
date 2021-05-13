using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public bool AtualizarDbDisciplina(List<Disciplina> listaDisciplinas)
        {
            var json = JsonConvert.SerializeObject(listaDisciplinas, Formatting.Indented);
            File.WriteAllText(_dbContext.CaminhoBanco(), json);
            return true;
        }

        public Disciplina Inserir(Disciplina disciplica)
        {
            var listaDisciplina = this.GetDisciplinas();
            var maxId = listaDisciplina.Max(d => d.Id);

            disciplica.Id = maxId + 1;
            listaDisciplina.Add(disciplica);
            AtualizarDbDisciplina(listaDisciplina);
            return disciplica;
        }

        public Disciplina AtualizarDisciplina(int id, Disciplina disciplina)
        {
            var listaDisciplinas = this.GetDisciplinas();
            var itemIndex = listaDisciplinas.FindIndex(d => d.Id == id);
            if (itemIndex >= 0)
            {
                disciplina.Id = id;
                listaDisciplinas[itemIndex] = disciplina;
            }
            else
            {
                return null;
            }

            AtualizarDbDisciplina(listaDisciplinas);

            return disciplina;
        }

        public bool Deletar(int id)
        {
            var listaDisciplinas = this.GetDisciplinas();
            var itemIndex = listaDisciplinas.FindIndex(d => d.Id == id);
            if (itemIndex >= 0)
            {
                listaDisciplinas.RemoveAt(itemIndex);
            }
            else
            {
                return false;
            }
            AtualizarDbDisciplina(listaDisciplinas);

            return true;
        }

    }
}
