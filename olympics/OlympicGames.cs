using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace olympics
{
    class OlympicGames
    {
        private string olympicName;
        private string olympicType;
        private string olympicYear;

        private BusinessLayer businessLayer = new BusinessLayer();

        public OlympicGames(string olympicName, string olympicType, string olympicYear)
        {
            this.olympicName = olympicName;
            this.olympicType = olympicType;
            this.olympicYear = olympicYear;
        }
        public OlympicGames()
        { }

        public string OlympicName
        {
            set { olympicName = value; }
            get { return olympicName; }
        }
        public string OlympicType
        {
            set { olympicType = value; }
            get { return olympicType; }
        }
        public string OlympicYear
        {
            set { olympicYear = value; }
            get { return olympicYear; }
        }

        //public string Olympics()
        //{
        //    return businessLayer.SelectOlympics();
        //}
        public int AddOlympics()
        {
            return businessLayer.InsertOlympics();
        }
        public int EditOlympics()
        {
            return businessLayer.UpdateOlympics();
        }
        public int DeleteOlympis()
        {
            return businessLayer.DeleteOlympics();
        }

    }
}
