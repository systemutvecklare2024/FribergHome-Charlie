using AutoMapper;
using FribergHome_API.Models;
using FribergHome_Shared.DTOs;

namespace FribergHome_API.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Property, PropertyDTO>()
				.ReverseMap();
		}
	} 
}
