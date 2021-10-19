using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlunosWeb.Models
{
    public class Turma
    {
        [Key]
        public int TurmaId { get; set; }
        public string NomeTurma { get; set; }



        public  int AlunoId { get; set; }
        public List<Aluno> alunos { get; set; }= new List<Aluno>();
    }
}
