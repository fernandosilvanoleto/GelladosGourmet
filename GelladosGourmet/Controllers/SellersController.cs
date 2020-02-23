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
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}