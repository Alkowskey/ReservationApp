using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ReservationsApp2.Models;

namespace ReservationsApp2.Serializers
{
    public class UserToRoom
    {
        public User User { get; set; }
        public Room Room { get; set; }
    }
}
