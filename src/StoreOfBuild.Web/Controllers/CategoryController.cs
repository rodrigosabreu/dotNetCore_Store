using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StoreOfBuild.Web.Models;
using StoreOfBuild.Domain.Products;
using StoreOfBuild.Web.ViewsModels;

namespace StoreOfBuild.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryStorer _categoryStorer;

        public CategoryController(CategoryStorer categoryStorer)
        {
            _categoryStorer = categoryStorer;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateOrEdit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrEdit(CategoryViewModel viewModel)
        {

            //jeito velho de fazer, instanciando a classe
            //jeito novo de fazer,  injecao de dependencia
            //passar a classe CategoryStorer injetada no construtor desta classe
            //E consequente o repositorio tambem sera passar para o construtor
            //para que seja feita a injecao de dependencias tem que configurar os servicos
            //a injecao de depencia se encontra no projeto DI
            /*var repositorio = new repositorio();
            var storer = new CategoryStorer();*/

            _categoryStorer.Store(viewModel.Id, viewModel.Name);

            return View();
        }
       
    }
}
