using AutoMapper;
using ENG6.Application.DTOs;
using ENG6.Application.ModelView;
using ENG6.Domain.Entites;

namespace ENG6.Application.Mappings
{
    public class DomaintToDTOMappingProfile : Profile
    {
        public DomaintToDTOMappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
			CreateMap<Cliente, ClienteView>().ReverseMap();
			CreateMap<Endereco, EnderecoDTO>().ReverseMap();
        }
    }
}
