using AplicacaoFullStack.Data;
using AplicacaoFullStack.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicacaoFullStack.Services
{
    public class ClienteService : IClienteService
    {
        private readonly AppDbContext dbContext;

        public ClienteService(AppDbContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task Add(Cliente cliente)
        {
            await dbContext.AddAsync(cliente);
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(Cliente cliente)
        {
            dbContext.Update(cliente);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(Cliente cliente)
        {
            dbContext.Remove(cliente);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Cliente> GetBy(Guid id)
        {
            var cliente = await dbContext.Clientes.FirstOrDefaultAsync(c => c.id == id);

            return cliente;
        }

        public async Task<List<Cliente>> FindAll()
        {
            var clientes = await dbContext.Clientes.ToListAsync();

            return clientes;
        }
    }
}
