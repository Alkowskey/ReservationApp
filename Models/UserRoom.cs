using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationsApp2.Models
{
    public class UserRoom
    {
        public UserRoom() { }
        public UserRoom(User user, Room room) {
            UserId = user.UserId;
            User = user;
            RoomId = room.RoomId;
            Room = room;

        }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
