using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Entites;
using ReservationAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReservationAPI.Controllers
{
    [Route("api/[controller]")]
    public class ResController : Controller
    {
        private readonly IReservationService _reservationService;

        public ResController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        [HttpGet("{Id}")]
        public Reservation Get(int Id)
        {
            return _reservationService.GetResByBkgNumber(Id);
        }
    }
}

