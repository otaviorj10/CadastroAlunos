using AlunoApp.FileContext;
using AlunoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Providers.Entities;

namespace AlunoApp.Controllers
{
    public class MainController : Controller
    {

        

        public IActionResult Cadastrar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Cadastrar(AlunoModel aluno)
        {
            using (var repo = new AlunoAppContext())
            {

                if (ModelState.IsValid)
                {
                    repo.Add(aluno);
                    repo.SaveChanges();
                }
            }
            return View();



        }


        public IActionResult Consultar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Consultar(int id)
        {
            using (var repo = new AlunoAppContext())
            {


                AlunoModel aluno = repo.Aluno.Find(id);
                return RedirectToAction("AmostrarResultado", aluno);

            }


        }

        public IActionResult AmostrarResultado(AlunoModel model)
        {
            return View(model);
        }




        public IActionResult ExcluirAlunos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ExcluirAlunos(int id)
        {
            using (var repo = new AlunoAppContext())
            {
                AlunoModel aluno = repo.Aluno.Find(id);
                repo.Remove(aluno);
                repo.SaveChanges();
                return RedirectToAction("Cadastrar");

            }
        }


        public IActionResult UpdateALunos() { return View(); }

        [HttpPost]
        public  IActionResult UpdateALunos(int? id)
        {
            using ( var repo = new AlunoAppContext())
            {
                AlunoModel aluno = repo.Aluno.Find(id);

                return RedirectToAction("Update",aluno);
            }
        }


        public IActionResult Update()
        {
            {
                return View();
            }
            
        }

       [HttpPost]
       public IActionResult Update(AlunoModel aluno,int? id)
        {
            using (var repo = new AlunoAppContext())
            {
                repo.Aluno.Attach(aluno);
                repo.Entry(aluno).Property(p => p.DataDeNascimento).IsModified = true;
                repo.Entry(aluno).Property(p => p.Matricula).IsModified = true;
                repo.Entry(aluno).Property(p => p.Nome).IsModified = true;
                repo.Update(aluno);
                repo.SaveChanges();
            }
            return View("Consultar");
        }




    }
}
