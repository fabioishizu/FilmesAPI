using ApiFilme.Data.Dtos;
using ApiFilme.Models;

namespace ApiFilme.Profile;

public class FilmeProfile : AutoMapper.Profile
{
	public FilmeProfile() {
		CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
    }
}
