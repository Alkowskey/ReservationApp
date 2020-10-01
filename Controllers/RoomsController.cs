using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using ReservationsApp2.Context;
using ReservationsApp2.Models;

namespace ReservationsApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly ILogger<RoomsController> _logger;
        private readonly ResAppContext _dbContext;

        public RoomsController(ILogger<RoomsController> logger, ResAppContext dbContext) 
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return _dbContext.getAllRooms();
        }

        [HttpPost]
        public Room addUser(Room room)
        {
            return _dbContext.addRoom(room);
        }
    }
}
