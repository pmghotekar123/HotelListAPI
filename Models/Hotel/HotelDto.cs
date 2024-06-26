using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListAPI.Models.Hotel
{
    public class HotelDto
    {
        public string Id { get; set; }
        public string Name { set; get; }
        public string Address { get; set; }
        public double Rating { get; set; }
        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
    }
}