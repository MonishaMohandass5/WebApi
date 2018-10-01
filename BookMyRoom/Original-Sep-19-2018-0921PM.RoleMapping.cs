using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("HotelCityMapping")]
    public class RoleMapping
    {
            [Key]
            public int mapId { get; set; }
            [ForeignKey("hotelDetails")]
            public int hotelId { get; set; }
            public HotelDetails hotelDetails { get; set; }
            [ForeignKey("cityDetails")]
            public int cityId { get; set; }
            public CityDetails cityDetails { get; set; }
        }
    }
}
