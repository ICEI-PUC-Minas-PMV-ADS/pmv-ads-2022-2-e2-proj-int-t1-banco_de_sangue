﻿using BancoDeSangue.Models;
using BancoDeSangue.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BancoDeSangue.Controllers
{
    public class Formulario : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Criar(FormularioModel formularioModel)
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }

    }
}



    
