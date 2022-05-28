using AutoMapper;
using AutoMapperQueryProjection.Entities;
using AutoMapperQueryProjection.Resources;

namespace AutoMapperQueryProjection.Mappers
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonResponse>()
                .ForMember(dest => dest.Job, opt => opt.MapFrom(src => src.Job.Name));
        }
    }
}
