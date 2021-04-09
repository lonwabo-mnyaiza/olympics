using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace olympics
{
    class Country
    {
        // attributes.
        private string countryID;
        private string countryName;
        private BusinessLayer businessLayer = new BusinessLayer();

        // contructors.
        public Country(string countryID, string countryName)
        {
            this.countryID = countryID;
            this.countryName = countryName;
        }
        public Country()
        { }

        // properties.
        public string CountryID
        {
            set { countryID = value; }
            get { return countryID; }
        }
        public string CountryName
        {
            set { countryName = value; }
            get { return countryName; }
        }

        // businessLayer communications.
        public DataTable AllCountries()
        {
            return businessLayer.SelectCountries();
        }
        public DataTable SearchCountry(string searchKey)
        {
            return businessLayer.SelectLikeCountries(searchKey); 
        }
        public string PlacingCountry(string countryID)
        {
            return businessLayer.SelectPlacingCountry(countryID);
        }      
        public int AddCountry(string countryID, string countryName)
        {
            return businessLayer.InsertCountry(countryID, countryName);
        }
        public int EditCountry(string countryID, string countryName)
        {
            return businessLayer.UpdateCountry(countryID, countryName); 
        }
        public int RemoveCountry(string countryID)
        {
            return businessLayer.DeleteCountry(countryID); 
        }
    }
}
