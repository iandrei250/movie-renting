using AutoMapper;
using Renter.Dtos;
using Renter.Models;

namespace Renter
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           CreateMap<Customer, CustomerDto>();
           CreateMap<Movie, MovieDto>();


            CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<MovieDto, Movie>().ForMember(c => c.Id, opt => opt.Ignore());

        }
    }
}
