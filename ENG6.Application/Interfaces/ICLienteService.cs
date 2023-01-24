using ENG6.Application.DTOs;
using ENG6.Application.ModelView;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ENG6.Application.Interfaces
{
    public interface ICLienteService
    {
        Task<IEnumerable<ClienteView>> GetClientes();
        Task<ClienteDTO> GetById(int? id);
        Task Add(ClienteDTO categoryDto);
        Task Update(ClienteDTO categoryDto);
        Task Remove(int? id);
    }
}
