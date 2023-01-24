using ENG6.Application.DTOs;
using ENG6.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ENG6.Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        public Task<EnderecoDTO> Create(EnderecoDTO endereco)
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoDTO> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EnderecoDTO>> GetEnderecos()
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoDTO> Remove(EnderecoDTO endereco)
        {
            throw new NotImplementedException();
        }

        public Task<EnderecoDTO> Update(EnderecoDTO endereco)
        {
            throw new NotImplementedException();
        }
    }
}
