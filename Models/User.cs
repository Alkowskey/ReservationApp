﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationsApp2.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public List<UserRoom> UserRooms { get; set; }
    }
}
