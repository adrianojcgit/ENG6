using AutoMapper;
using ENG6.Application.DTOs;
using ENG6.Application.ModelView;
using ENG6.Application.Interfaces;
using ENG6.Domain.Entites;
using ENG6.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ENG6.Application.Services
{
    public class ClienteService : ICLienteService
    {
        private IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClienteView>> GetClientes()
        {
            var clientesEntity = await _clienteRepository.GetClientes();

			IEnumerable<ClienteView> cli = _mapper.Map<IEnumerable<ClienteView>>(clientesEntity);
            return cli;
        }

        public async Task<ClienteDTO> GetById(int? id)
        {
            var clientesEntity = await _clienteRepository.GetById(id);
            return _mapper.Map<ClienteDTO>(clientesEntity);
        }

        public async Task Add(ClienteDTO clienteDto)
        {
            var clientesEntity = _mapper.Map<Cliente>(clienteDto);
            await _clienteRepository.Create(clientesEntity);
        }

        public async Task Update(ClienteDTO clienteDto)
        {
            var clientesEntity = _mapper.Map<Cliente>(clienteDto);
            await _clienteRepository.Update(clientesEntity);
        }

        public async Task Remove(int? id)
        {
            var clientesEntity = _clienteRepository.GetById(id).Result;
            await _clienteRepository.Remove(clientesEntity);
        }
    }
}
