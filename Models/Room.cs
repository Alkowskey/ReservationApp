﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationsApp2.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomKey { get; set; }
        public List<UserRoom> UserRooms { get; set; }

    }
}
