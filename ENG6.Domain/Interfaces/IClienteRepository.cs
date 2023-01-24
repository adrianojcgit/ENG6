using ENG6.Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ENG6.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetClientes();
        Task<Cliente> GetById(int? id);
        Task<Cliente> Create(Cliente cliente);
        Task<Cliente> Update(Cliente cliente);
        Task<Cliente> Remove(Cliente cliente);
    }
}
