using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventhub.models
{
    public class Badge
    {
        public int Id { get; set; }

        public string Number { get; set; }
        public DateTime IssuedAt { get; set; }

        public string Tier { get; set; }

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}
