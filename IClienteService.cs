using AplicacaoFullStack.Models;

namespace AplicacaoFullStack.Services
{
    public interface IClienteService
    {
        Task Add(Cliente cliente);

        Task Update(Cliente cliente);

        Task Delete(Cliente cliente);

        Task<Cliente> GetBy(Guid id);

        Task<List<Cliente>> FindAll();
    }
}
