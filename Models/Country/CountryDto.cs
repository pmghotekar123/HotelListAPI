using HotelListAPI.Models.Hotel;

namespace HotelListAPI.Models.Country
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string ShortName { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }
}