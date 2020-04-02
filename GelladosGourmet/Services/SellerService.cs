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

        public Seller FindyById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
