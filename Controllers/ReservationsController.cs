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
    public class ReservationsController : ControllerBase
    {
        private readonly ILogger<ReservationsController> _logger;
        private readonly ResAppContext _dbContext;

        public ReservationsController(ILogger<ReservationsController> logger, ResAppContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<Reservation> Get()
        {
            return _dbContext.getAllReservations();
        }

        [HttpPost]
        public Reservation addUser(Reservation reservation)
        {
            return _dbContext.addReservation(reservation);
        }
    }
}
