using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GelladosGourmet.Models;
using GelladosGourmet.Services;
using Microsoft.AspNetCore.Mvc;

namespace GelladosGourmet.Controllers
{ 
    public class SellersController : Controller
    {
        // aqui faço referência a pasta de Services, que tem a pasta SellerService
        private readonly SellerService _sellerService;

        // fazendo injeção de dependência
        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            // controller acessando o model
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost] // isso é anotation
        [ValidateAntiForgeryToken] //anti-request
        public IActionResult Criar(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
            // colocando o nameof, eu não preciso ficar preocupado com a mudança de nomes que o Index pode sofrer -- boa dica de programação
        }
    }
}