using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GelladosGourmet.Models;
using Microsoft.EntityFrameworkCore;

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

        // transformando nosso método em assíncrono
        public async Task<List<Department>> FindAllAsync()
        {
            // agora a nossa função está assincrona
            // a gente coloca await para avisar ao compilador que é assincrono
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
