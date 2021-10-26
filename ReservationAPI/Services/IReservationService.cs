using System;
using ReservationAPI.Entites;

namespace ReservationAPI.Services
{
    public interface IReservationService
    {
        public Reservation GetResByBkgNumber(int BkgNumber);
    }
}

