using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GelladosGourmet.Models;

namespace GelladosGourmet.Services
{
    public class DepartmentService
    {
        //readonly - é uma prática para previnir que não seja alterada
        private readonly GelladosGourmetContext _context;

        public DepartmentService(GelladosGourmetContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
