using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPiColaborativo.Model;

public class IDprofessorgrad
{
    public IDprofessorgrad()
    {
        public async Task<IActionResult> Update([FromBody] professor professor, int id, string graducao)
        {
            try
            {
                if (id != professor.Id)
                {
                    return null;
                }
            }   if (id != graducao.ToString)

                return null;
        }