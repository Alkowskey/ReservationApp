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


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql("Server=localhost;database=ResAppDB;user id=postgres;pwd=mc4l3k1999;");
    }
}
