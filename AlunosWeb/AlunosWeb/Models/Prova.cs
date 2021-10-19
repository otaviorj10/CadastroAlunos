using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlunosWeb.Models
{
    public class Prova
    {
        [Key]
        public int ProvaId { get; set; }
        public string NomeMateria { get; set; }
        public double NotaDaProva { get; set; }


        public int AlunoId { get; set; }
        public Aluno aluno { get; set; }
    }
}
