using System;
namespace WebAPiColaborativo.Data
{
    public class DbContext
    {
        public string CaminhoBancoDisciplinas()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"dbDisciplinas.json";
        }

        public string CaminhoBancoProfessores()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"dbProfessores.json";
        }
    }
}
