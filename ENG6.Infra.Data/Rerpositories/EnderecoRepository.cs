using ENG6.Domain.Entites;
using ENG6.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENG6.Infra.Data.Rerpositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        public Task<Endereco> Create(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Endereco>> GetEnderecos()
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> Remove(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> Update(Endereco endereco)
        {
            throw new NotImplementedException();
        }
    }
}
