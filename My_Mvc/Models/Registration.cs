using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_Mvc.Models
{
    public class Registration
    {
        public int RegistrationID { get; set; }
        public int ParticipantID { get; set; }
        public int EventID { get; set; }

        public virtual Participant Participant { get; set; }
        public virtual Event Event { get; set; }
    }
}