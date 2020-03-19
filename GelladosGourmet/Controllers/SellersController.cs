using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}