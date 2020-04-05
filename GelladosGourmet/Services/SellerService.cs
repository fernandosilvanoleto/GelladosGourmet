using GelladosGourmet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GelladosGourmet.Services.Exceptions;

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

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();// salvar no banco de dados;
        }

        public async Task<Seller> FindyByIdAsync(int id)
        {
            // função eager loading
            // tem como função carregar outros objetos, junto com o objeto principal, um join
            // a função include faz o join automatico, entre vendedor e departamento
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            var obj = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id não encontrado!!!");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            } catch(DbUpdateConcurrencyException e)
            {
                // controlador conversa com a camada de serviço, excessões do nível do acesso a dados, são capturados pelo service e repassado para o seu controlador
                // segregar as camadas
                // lançar uma excessão da camada de serviço, não outra camada
                throw new DbConcurrencyException(e.Message);
            }            
        }
    }
}
