using System;
using System.Collections.Generic;
using WebAPiColaborativo.Model;

namespace WebAPiColaborativo.Interfaces
{
    public interface IProfessor
    {
        List<Professor> GetProfessores();
        Professor GetById(int id);
    }
}
