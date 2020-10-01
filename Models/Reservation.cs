using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationsApp2.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public Room Room { get; set; }
        public User User { get; set; }
        public string Color { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
