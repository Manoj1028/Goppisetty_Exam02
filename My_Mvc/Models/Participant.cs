using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Mvc.Models
{
    public class Participant
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParticipantID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}