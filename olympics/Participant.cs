using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace olympics
{
    class Participant
    {
        // attributes.
        private string participantID;
        private string participantName;
        private string gender;
        private string countryID;

        private BusinessLayer businessLayer = new BusinessLayer();

        // constructor.
        public Participant()
        { }
        public Participant(string participantID, string participantName, string gender, string countryID)
        {
            this.participantID = participantID;
            this.participantName = participantName;
            this.gender = gender;
            this.countryID = countryID;
        }

        // properties.
        public string ParticipantID
        {
            set { participantID = value; }
            get { return participantID; }

        }

        public string ParticipantName
        {
            set { participantName = value; }
            get { return participantName; }

        }

        public string Gender
        {
            set { gender = value; }
            get { return gender; }

        }

        public string CountryID
        {
            set { countryID = value; }
            get { return countryID; }

        }

        // business layer communications.
        public DataTable AllParticipant()
        {
            return businessLayer.SelectParticipant();
        }
        public DataTable CountryParticipants(string country)
        {
            return businessLayer.SelectCountryParticipants(country);
        }
        public DataTable CountryEventParticipants(string country, string events)
        {
            return businessLayer.SelectCountryEventParticipants(country, events);
        }
        public DataTable EventParticipants(string events)
        {
            return businessLayer.SelectEventParticipants(events); 
        }
        public string PlacingParticipantName(string participantID)
        {
            return businessLayer.SelectPlacingParticipantName(participantID);
        }
        public int AddParticipant(string participantID, string participantName, string gender, string countryID)
        {
            return businessLayer.InsertParticipant(participantID, participantName, gender, countryID); 
        }
        public int EditParticipant(string participantID, string participantName, string gender, string countryID)
        {
            return businessLayer.UpdateParticipant(participantID, participantName, gender, countryID);
        }
        public int RemoveParticipant(string participantID)
        {
            return businessLayer.DeleteParticipant(participantID);
        }
    }
}
