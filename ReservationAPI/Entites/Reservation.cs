using System;
namespace ReservationAPI.Entites
{
    public class Reservation
    {
        public int Id { get; set; }
        public int BkgNumber { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? BkgDate { get; set; }
        public double Amount { get; set; }
    }
}

