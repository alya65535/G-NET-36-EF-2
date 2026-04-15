using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    public class Registration
    {
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public string? Note { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
