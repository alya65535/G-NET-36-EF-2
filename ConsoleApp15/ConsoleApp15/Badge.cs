using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    public class Badge
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public DateTime IssueDate { get; set; }

        public string Tier { get; set; }

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    
}
}
