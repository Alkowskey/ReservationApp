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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRoom>()
                .HasKey(ur => new { ur.RoomId, ur.UserId });

            modelBuilder.Entity<UserRoom>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRooms)
                .HasForeignKey(ur => ur.UserId);

            modelBuilder.Entity<UserRoom>()
                .HasOne(ur => ur.Room)
                .WithMany(r => r.UserRooms)
                .HasForeignKey(ur => ur.RoomId);
        }

        /*
         * User part
         */
        public IEnumerable<User> getAllUsers()
        {
            return Users.Include(u=>u.UserRooms).ThenInclude(ur=>ur.Room);
        }
        public User addUser(User user)
        {
            Users.Add(user);

            this.SaveChanges();

            return user;
        }

        public User addUserToRoom(User user, Room room)
        {
            User _user = Users.Where(u => u.Name == user.Name).FirstOrDefault();
            Room _room = Rooms.Where(r => r.RoomKey == room.RoomKey).FirstOrDefault();

            if (_user.UserRooms == null)
                _user.UserRooms = new List<UserRoom>();

            _user.UserRooms.Add(new UserRoom(_user, _room));
            this.SaveChanges();
            return _user;
        }

        /*
         * Room part
         */
        public IEnumerable<Room> getAllRooms()
        {
            return Rooms.Include(room => room.UserRooms).ThenInclude(ur=>ur.User);
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
