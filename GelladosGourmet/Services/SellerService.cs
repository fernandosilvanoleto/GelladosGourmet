using GelladosGourmet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GelladosGourmet.Services
{
    public class SellerService
    {
        //readonly - é uma prática para previnir que não seja alterada
        private readonly GelladosGourmetContext _context;

        public SellerService(GelladosGourmetContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();// salvar no banco de dados;
        }
    }
}
