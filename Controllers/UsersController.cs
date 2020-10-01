using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using ReservationsApp2.Context;
using ReservationsApp2.Models;
using ReservationsApp2.Serializers;

namespace ReservationsApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly ResAppContext _dbContext;

        public UsersController(ILogger<UsersController> logger, ResAppContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _dbContext.getAllUsers();
        }

        [HttpPost]
        public User addUser(User user)
        {
            return _dbContext.addUser(user);
        }

        [HttpPost("toRoom")]
        public User addUserToRoom([FromBody] UserToRoom userToRoom)
        {
            User user = userToRoom.User;
            Room room = userToRoom.Room;
            return _dbContext.addUserToRoom(user, room);
        }
    }
}
