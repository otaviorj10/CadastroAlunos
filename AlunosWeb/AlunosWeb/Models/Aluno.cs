using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlunosWeb.Models
{
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }
        public string NomeAluno { get; set; }


        public   int ProvaId { get; set; }
        public ICollection<Prova> provas { get; set; }



        public int TurmaId { get; set; }
        public Turma Turma { get; set; }


    }
}
