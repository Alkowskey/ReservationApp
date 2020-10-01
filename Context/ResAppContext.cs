using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using ReservationsApp2.Models;

namespace ReservationsApp2.Context
{
    public class ResAppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public ResAppContext(DbContextOptions<ResAppContext> options) : base(options)
        { }

        /*
         * User part
         */
        public IEnumerable<User> getAllUsers()
        {
            return Users;
        }
        public User addUser(User user)
        {
            Users.Add(user);

            this.SaveChanges();

            return user;
        }

        public User addUserToRoom(User user, Room room)
        {
            user.Rooms.Add(room);
            this.SaveChanges();
            return user;
        }

        /*
         * Room part
         */
        public IEnumerable<Room> getAllRooms()
        {
            return Rooms;
        }
        public Room addRoom(Room room)
        {
            Rooms.Add(room);

            this.SaveChanges();

            return room;
        }
        /*
         * Reservation part
         */
        public IEnumerable<Reservation> getAllReservations()
        {
            return Reservations;
        }
        public Reservation addReservation(Reservation reservation)
        {
            Reservations.Add(reservation);

            this.SaveChanges();

            return reservation;
        }

        public IEnumerable<Reservation> addReservations(IEnumerable<Reservation> reservations)
        {
            Reservations.AddRange(reservations);

            this.SaveChanges();

            return reservations;
        }



    }
        
}
