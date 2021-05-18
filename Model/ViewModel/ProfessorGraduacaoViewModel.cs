using System;
namespace WebAPiColaborativo.Model
{
    public class ProfessorGraduacaoViewModel
    {
        public ProfessorGraduacaoViewModel(string graduacao)
        {
            Graduacao = graduacao;
        }

        public string Graduacao { get; set; }
    }
}
