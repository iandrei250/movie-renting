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
           CreateMap<CustomerDto, Customer>();
        }
    }
}
