﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("RoleMapping")]
    public class RoleMapping
    {
            [Key]
            public int mapId { get; set; }
            [ForeignKey("hotelDetails")]
            public int roleId { get; set; }
            public HotelDetails hotelDetails { get; set; }
            [ForeignKey("cityDetails")]
            public int cityId { get; set; }
            public CityDetails cityDetails { get; set; }
        }
    }
}
