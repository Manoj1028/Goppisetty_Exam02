using System;
using System.Collections.Generic;

namespace My_Mvc.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}