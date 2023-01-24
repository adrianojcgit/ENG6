using ENG6.Domain.Entites;
using ENG6.Domain.Interfaces;
using ENG6.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENG6.Infra.Data.Rerpositories
{
    public class ClienteRepository : IClienteRepository
    {
        private ApplicationDbContext _clienteContext;
        public ClienteRepository(ApplicationDbContext context)
        {
            _clienteContext = context;
        }


        public async Task<Cliente> Create(Cliente cliente)
        {
            _clienteContext.Add(cliente);
            await _clienteContext.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> GetById(int? id)
        {
            return await _clienteContext.Clientes.FindAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await _clienteContext.Clientes.ToListAsync();
        }

        public async Task<Cliente> Remove(Cliente cliente)
        {
            _clienteContext.Remove(cliente);
            await _clienteContext.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> Update(Cliente cliente)
        {
            _clienteContext.Update(cliente);
            await _clienteContext.SaveChangesAsync();
            return cliente;
        }
    }
}
