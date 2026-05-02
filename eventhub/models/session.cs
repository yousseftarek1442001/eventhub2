using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventhub.models
{
    public class Session
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
