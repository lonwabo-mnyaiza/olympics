using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace olympics
{
    class Event
    {
        // attributes.
        //private int eventNo;
        private string eventDescription;
        private string disciplineCode;
        private string gender;
        private string eventType;
        private string eventDate;
        private string venue;

        private BusinessLayer businessLayer = new BusinessLayer();

        // constructor.
        public Event()
        { }

        public Event(int eventNo, string eventDescription, string disciplineCode, string gender, string eventType, string eventDate, string venue)
        {
            //this.eventNo = eventNo;
            this.eventDescription = eventDescription;
            this.disciplineCode = disciplineCode;
            this.gender = gender;
            this.eventType = eventType;
            this.eventDate = eventDate;
            this.venue = venue;
        }

        //public int EventNo
        //{
        //    set { eventNo = value; }
        //    get { return eventNo; }
        //}

        // properties.
        public string EventDescription
        {
            set { eventDescription = value; }
            get { return eventDescription; }
        }

        public string DisciplineCode
        {
            set { disciplineCode = value; }
            get { return disciplineCode; }
        }

        public string Gender
        {
            set { gender = value; }
            get { return gender; }
        }

        public string EventType
        {
            set { eventType = value; }
            get { return eventType; }
        }

        public string EventDate
        {
            set { eventDate = value; }
            get { return eventDate; }
        }

        public string Venue
        {
            set { venue = value; }
            get { return venue; }
        }

        // business layer communications.4
        public DataTable AllEvents()
        {
            return businessLayer.SelectEvents();
        }
        public DataTable DisciplinedEvents(string discipline)
        {
            return businessLayer.SelectDisciplinedEvents(discipline);
        }
        public DataTable DisciplinedEventsText(string discipline)
        {
            return businessLayer.SelectDisciplinedEventsText(discipline); 
        }
        public DataTable DateEvents(string startDate, string endDate)
        {
            return businessLayer.SelectDatedEvents(startDate, endDate);
        }
        public DataTable SearchEvent(string searchKey)
        {
            return businessLayer.SelectLikeEvents(searchKey); 
        }
        public DataTable TeamParticipants()
        {
            return businessLayer.SelectTeamParticipants(); 
        }
        public DataTable TeamEvent()
        {
            return businessLayer.SelectTeamEvents();
        }
        public DataTable IndividualEvent()
        {
            return businessLayer.SelectIndividualEvents(); 
        }
        public DataTable DayEvent(string day)
        {
            return businessLayer.SelectDayEvents(day);
        }
        public string PlacingEventDesc(string eventNo)
        {
            return businessLayer.SelectPlacingEventDesc(eventNo);
        }           
        public int AddEvent(string eventDescription, string disciplineCode, string gender, string eventType, string eventDate, string venue)
        {
            return businessLayer.InsertEvent(eventDescription, disciplineCode, gender, eventType, eventDate, venue);
        }
        public int EditEvent(string eventDescription, string disciplineCode, string gender, string eventType, string eventDate, string venue)
        {
            return businessLayer.UpdateEvent(eventDescription, disciplineCode, gender, eventType, eventDate, venue);
        }
        public int RemoveEvent(string disciplineCode)
        {
            return businessLayer.DeleteEvent(disciplineCode);
        }     
    }
}
