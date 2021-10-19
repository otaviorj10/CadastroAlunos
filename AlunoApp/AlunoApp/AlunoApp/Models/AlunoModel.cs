using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace AlunoApp.Models
{
    [DataContract]
    public class AlunoModel
    {
        [Key]
        public  int AlunoId { internal  get;  set; }

        [Display(Name ="Nome : ")]
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento : ")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDeNascimento { get; set; }


        [Display(Name = "Matricula : ")]
        [Required(ErrorMessage ="Não deve ter matriculas repitidas")]
        public string Matricula { get; set; }
    }
}
