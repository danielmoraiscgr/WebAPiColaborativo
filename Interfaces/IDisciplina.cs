using System;
using System.Collections.Generic;
using WebAPiColaborativo.Model;

namespace WebAPiColaborativo.Interfaces
{
    public interface IDisciplina
    {
        public List<Disciplina> GetDisciplinas();
        public bool AtualizarDbDisciplina(List<Disciplina> listaDisciplinas);
        public Disciplina Inserir(Disciplina disciplica);
        public Disciplina AtualizarDisciplina(int id, Disciplina disciplina);
        public bool Deletar(int id);
    }

}
