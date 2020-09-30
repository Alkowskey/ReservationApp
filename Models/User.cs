using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationsApp2.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
