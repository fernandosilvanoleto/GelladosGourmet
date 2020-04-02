using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GelladosGourmet.Models;
using GelladosGourmet.Models.ViewModels;
using GelladosGourmet.Services;
using Microsoft.AspNetCore.Mvc;

namespace GelladosGourmet.Controllers
{ 
    public class SellersController : Controller
    {
        // aqui faço referência a pasta de Services, que tem a pasta SellerService
        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        // fazendo injeção de dependência
        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            // controller acessando o model
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Criar()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments};
            return View(viewModel);
        }

        [HttpPost] // isso é anotation
        [ValidateAntiForgeryToken] //anti-request
        public IActionResult Criar(Seller seller)
        {
            // só passando o Id do Departamento que o Framework irá conhecer o departmento correto, não precisando fazer mais nada
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
            // colocando o nameof, eu não preciso ficar preocupado com a mudança de nomes que o Index pode sofrer -- boa dica de programação
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _sellerService.FindyById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }
}