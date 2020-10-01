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
    public class UsersController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ResAppContext _dbContext;

        public UsersController(ILogger<WeatherForecastController> logger, ResAppContext dbContext)
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
    }
}
