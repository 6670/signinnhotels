using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignInnHotel.Controllers
{
    public class RoomBookingFormModel
    {
        public int Id { get; set; }
        public DateTime InqueryTime { get; set; } = DateTime.Now;
        public string CustomerEmail { get; set; }
        public DateTime CustomerArivalTime { get; set; }
        public DateTime CustomerDepartureTime { get; set; }
        public int? TotalGuests { get; set; } = 0;
        public string CustomerPhone { get; set; }
    }
}