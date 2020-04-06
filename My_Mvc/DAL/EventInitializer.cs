using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using My_Mvc.Models;

namespace My_Mvc.DAL
{
    public class EventInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EventContext>
    {
        protected override void Seed(EventContext context)
        {
            var events = new List<Event>
            {
            new Event{ID=1111,EventName="Clash of Brains",EventDate=DateTime.Parse("2005-09-01")},
            new Event{ID=2222,EventName="Tech Scintilla",EventDate=DateTime.Parse("2002-09-01")},
            new Event{ID=3333,EventName="Circuitrix",EventDate=DateTime.Parse("2003-09-01")},
            new Event{ID=4444,EventName="CADwiz",EventDate=DateTime.Parse("2002-09-01")},
            new Event{ID=5555,EventName="Techwiz",EventDate=DateTime.Parse("2002-09-01")},
            new Event{ID=7777,EventName="Codemania",EventDate=DateTime.Parse("2001-09-01")},
            };

            events.ForEach(e => context.Events.Add(e));
            context.SaveChanges();
            var participants = new List<Participant>
            {
            new Participant{ParticipantID=1050,FirstName="Manoj",LastName="Naga Sai",Major="CSE"},
            new Participant{ParticipantID=4022,FirstName="Manvitha",LastName="Kondru",Major="ECE"},
            new Participant{ParticipantID=4041,FirstName="Pallavi",LastName="Damaraju",Major="Mechanical"},
            new Participant{ParticipantID=1045,FirstName="Rahul",LastName="Thakur",Major="CSE"},
            new Participant{ParticipantID=3141,FirstName="James",LastName="Throster",Major="CSE"},
            new Participant{ParticipantID=2021,FirstName="Zach",LastName="Durbin",Major="IS"},
            new Participant{ParticipantID=2042,FirstName="Cleber",LastName="saji",Major="Chemistry"},
            new Participant{ParticipantID=2045,FirstName="Charlet",LastName="kelvin",Major="Physics"}
            };
            participants.ForEach(p => context.Participants.Add(p));
            context.SaveChanges();
            var registrations = new List<Registration>
            {
            new Registration{EventID=1111,ParticipantID=1050},
            new Registration{EventID=3333,ParticipantID=4022},
            new Registration{EventID=2222,ParticipantID=1050},
            new Registration{EventID=7777,ParticipantID=1045},
            new Registration{EventID=3333,ParticipantID=3141},
            new Registration{EventID=5555,ParticipantID=2021},
            new Registration{EventID=1111,ParticipantID=1050},
            new Registration{EventID=2222,ParticipantID=1050},
            new Registration{EventID=3333,ParticipantID=4022},
            new Registration{EventID=7777,ParticipantID=4041},
            new Registration{EventID=4444,ParticipantID=1045},
            new Registration{EventID=2222,ParticipantID=3141},
            };
            registrations.ForEach(r => context.Registrations.Add(r));
            context.SaveChanges();
        }
    }
}