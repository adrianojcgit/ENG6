using ENG6.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ENG6.Application.Interfaces
{
    public interface IEnderecoService
    {
        Task<IEnumerable<EnderecoDTO>> GetEnderecos();
        Task<EnderecoDTO> GetById(int? id);
        Task<EnderecoDTO> Create(EnderecoDTO endereco);
        Task<EnderecoDTO> Update(EnderecoDTO endereco);
        Task<EnderecoDTO> Remove(EnderecoDTO endereco);
    }
}
