using AutoMapper;
using HotelListAPI.Data;
using HotelListAPI.Models.Country;
using HotelListAPI.Models.Hotel;

namespace HotelListAPI.Configrations
{
    public class MapperConfig :Profile 
    {
        public MapperConfig() 
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap(); 
            CreateMap<Country, GetCountryDto>().ReverseMap(); 
            CreateMap<Country, CountryDto>().ReverseMap(); 
            CreateMap<Country, UpdateCountryDto>().ReverseMap(); 
            CreateMap<Country, HotelDto>().ReverseMap(); 
        }   
    }
}
