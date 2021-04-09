using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace olympics
{
    class Placing
    {
        private string participantID;
        private string countryID;
        private string disciplineCode;
        private string placing;

        private BusinessLayer businessLayer = new BusinessLayer();

        public Placing()
        { }
        public Placing(string participantID, string countryID, string disciplineCode, string placing)
        {
            this.participantID = participantID;
            this.countryID = countryID;
            this.disciplineCode = disciplineCode;
            this.placing = placing;
        }

        public string ParticipantID
        {
            set { participantID = value; }
            get { return participantID; }
        }
        public string CountryID
        {
            set { countryID = value; }
            get { return countryID; }
        }
        public string DisciplineCode
        {
            set { disciplineCode = value; }
            get { return disciplineCode; }
        }
        public string Placings
        {
            set { placing = value; }
            get { return placing; }
        }

        public DataTable AllPlacing()
        {
            return businessLayer.SelectMedalWinners();
        }
        public DataTable EveryPlacing()
        {
            return businessLayer.SelectAllPlacings();
        }
        public int AddPlacing(string participantID, string countryID, string disciplineCode, string placing)
        {
            return businessLayer.InsertPlacing();            
        }
        public int EditPlacing(string participantID, string countryID, string disciplineCode, string placing)
        {
            return businessLayer.UpdatePlacing();
        }
        public int RemovePlacing(string eventNo, string participantID)
        {
            return businessLayer.DeletePlacing();
        }
    }
}
