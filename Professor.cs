using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPiColaborativo
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Graduacao { get; set; }


       

    }
}
