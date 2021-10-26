using System;
using ReservationAPI.Entites;
using ReservationAPI.Services;

namespace ReservationAPI.Concrete
{
    public class ReservationService : IReservationService
    {
        public Reservation GetResByBkgNumber(int BkgNumber)
        {
            return new Reservation()
            {
                Id = new Random().Next(100),
                Amount = new Random().Next(10000),
                BkgDate = DateTime.Now,
                CheckInDate = DateTime.Now.Date.AddDays(30),
                CheckOutDate = DateTime.Now.Date.AddDays(37),
                BkgNumber = BkgNumber
            };
        }
    }
}

