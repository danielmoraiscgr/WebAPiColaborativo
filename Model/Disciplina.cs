using System;
namespace WebAPiColaborativo.Model
{
    public class Disciplina
    {
        public Disciplina(int id, string nome, string curso, int cargaHoraria, string professor)
        {
            Id = id;
            Nome = nome;
            Curso = curso;
            CargaHoraria = cargaHoraria;
            Professor = professor;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int CargaHoraria { get; set; }
        public string Professor { get; set; }
    }
}
