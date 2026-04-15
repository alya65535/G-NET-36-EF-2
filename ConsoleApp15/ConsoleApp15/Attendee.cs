using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text;

namespace ConsoleApp15
{
    public class Attendee
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Address Address { get; set; }

        public Badge Badge { get; set; }

        public List<Registration> Registrations { get; set; } = new();
    }
}
