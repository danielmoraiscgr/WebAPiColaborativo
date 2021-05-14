using System;
using System.Collections.Generic;
using WebAPiColaborativo.Model;

namespace WebAPiColaborativo.Interfaces
{
    public interface IDisciplina
    {
        List<Disciplina> GetDisciplinas();
        bool AtualizarDbDisciplina(List<Disciplina> listaDisciplinas);
        Disciplina Inserir(Disciplina disciplica);
        Disciplina AtualizarDisciplina(int id, Disciplina disciplina);
        bool Deletar(int id);
    }

}
