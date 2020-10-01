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

        public ResAppContext(DbContextOptions<ResAppContext> options) : base(options)
        { }
        /*protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql(Confi);*/


        public IEnumerable<User> getAllUsers(){
            return Users;
        }

        public User addUser(User user)
        {
            Users.Add(user);

            this.SaveChanges();

            return user;
        }


    }
}
