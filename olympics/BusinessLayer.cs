using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace olympics
{
    class BusinessLayer
    {
        // Data access.
        SqlConnection dbConn;
        SqlCommand dbCmd;
        SqlDataAdapter dbAdapter;
        SqlDataReader dbReader;
        DataTable dt;

        // attributes.
        private string connectionString;

        // contructor.
        public BusinessLayer()
        {
            Connection = "Data Source= localhost ; Initial Catalog = Olympics; Integrated Security=SSPI";
            dbConn = new SqlConnection(Connection);
        }

        // properties.
        public string Connection
        {
            set { connectionString = value; }
            get { return connectionString; }
        }

        // startPage
        public int InsertCountryFlags()
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("", dbConn);
            int success = dbCmd.ExecuteNonQuery();

            return success; 
        }
        // password check
        public int VerifyPassword(string adminName, string password)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_VerifyPassword'"+adminName+"','"+password+"'", dbConn);
            dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                if (adminName == dbReader[0].ToString() && password == dbReader[1].ToString())
                {
                    return 1;
                }                
            }
            dbReader.Close();
            return 0;
        }

        // country tables
        public DataTable SelectCountries()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectCountries", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable SelectLikeCountries(string searchKey)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectLikeCountries'"+searchKey+"'",dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }       
        public int InsertCountry(string countryID, string countryName)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_InsertCountry'" +countryID+ "','"+countryName+"'", dbConn);
            int success = dbCmd.ExecuteNonQuery();

            return success;
        }
        public int UpdateCountry(string countryID, string countryName)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_UpdateCountry'" + countryID + "','" + countryName + "'", dbConn);
            int success = dbCmd.ExecuteNonQuery();

            return success;
        }
        public int DeleteCountry(string countryID)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_DeleteCountry'"+countryID+"'", dbConn);
            int success = dbCmd.ExecuteNonQuery();

            return success;
        }
        public string SelectPlacingCountry(string countryID)
        {
            // not sure if this works...
            string countryName = "";

            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            DataColumn dc = new DataColumn();
            dbCmd = new SqlCommand("sp_SelectPlacingCountry'"+countryID+"'", dbConn);
            dbReader = dbCmd.ExecuteReader();

            while (dbReader.Read())
            {
                countryName = dbReader[0].ToString();
            }
            dbReader.Close();
            return countryName;
        }

        // event tables.
        public DataTable SelectEvents()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectEvent", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        
        public DataTable SelectDisciplinedEvents(string discipline)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectDisciplinedEvents'"+discipline+"'", dbConn); //SELECT * FROM Event, Discipline WHERE Event.DisciplineCode = Discipline.DisciplineCode
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable SelectDisciplinedEventsText(string discipline)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectDisciplinedEventsText'"+discipline+"'", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable SelectDatedEvents(string startDate, string endDate)
        {
            // send in the value of the dtp not the text...
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectDatedEvents'"+startDate+"','"+endDate+"'", dbConn); //SELECT * FROM Event WHERE EventDate >= @StartDate AND EventDate <= @StopDate
            // parameters
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable SelectLikeEvents(string searchKey)
        {            
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectLikeEvents'"+searchKey+"'",dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable SelectDayEvents(string day)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectDayEvents'"+day+"'", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt; 
        }
        // datetime passed as string N.B.
        public int InsertEvent(string eventDescription, string disciplineCode, string gender, string eventType, string eventDate, string venue)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_InsertEvent'"+eventDescription+"','"+disciplineCode+"','"+gender+"','"+eventType+"','"+eventDate+"','"+venue+"'", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success;
        }
        // datetime stored as string. N.B.
        public int UpdateEvent(string eventDescription, string disciplineCode, string gender, string eventType, string eventDate, string venue)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_UpdateEvent", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success;
        }        
        public int DeleteEvent(string diciplineCode)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_DeleteEvent'"+diciplineCode+"'", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success;
        }

        //
        // Team Participant tables.
        //
        public DataTable SelectTeamParticipants()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectTeamParticipants", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        //
        // Team Event tables.
        //
        public DataTable SelectTeamEvents()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectTeamEvents", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        //
        // Individual Event tables.
        //
        public DataTable SelectIndividualEvents()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectIndividualEvents", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public string SelectPlacingEventDesc(string eventNo)
        {
            // not sure if this works...

            string eventDesc = "";
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            DataColumn dc = new DataColumn();
            dbCmd = new SqlCommand("sp_SelectPlacingEventDesc'"+eventNo+"'", dbConn);
            dbReader = dbCmd.ExecuteReader();

            while (dbReader.Read())
            {
                eventDesc = dbReader[0].ToString();
            }
            dbReader.Close();
            return eventDesc;
        }
      

        // discipline tables.
        public DataTable SelectDiscipline()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectDiscipline", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public int InsertDiscipline(string disciplineCode, string disciplineDescription)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_InsertDiscipline'"+disciplineCode+"','"+disciplineDescription+"'", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success;
        }
        public int UpdateDiscipline(string disciplineCode, string disciplineDescription)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_UpdateDiscipline'"+disciplineCode+"','"+disciplineDescription+"'", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success;
        }
        public int DeleteDiscipline(string disciplineCode)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_DeleteDiscipline'"+disciplineCode+"'", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success;
        }
        public string SelectPlacingDisciplineDesc(string disciplineCode)
        {
            // not sure if this works...
            string disciplineDesc = "";

            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            DataColumn dc = new DataColumn();
            dbCmd = new SqlCommand("sp_SelectPlacingDisciplineDesc'"+disciplineCode+"'", dbConn);
            dbReader = dbCmd.ExecuteReader();            

            while (dbReader.Read())
            {
                disciplineDesc = dbReader[0].ToString();
            }
            dbReader.Close();
            return disciplineDesc;
        }

        // participant tables.
        public DataTable SelectParticipant()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectParticipant", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable SelectCountryParticipants(string country)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectCountryParticipants'"+country+"'", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt; 
        }
        public DataTable SelectCountryEventParticipants(string country, string events)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectCountryEventParticipants'"+country+"','"+events+"'", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt; 
        }
        public DataTable SelectEventParticipants(string events)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectEventParticipants'"+events+"'", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public int InsertParticipant(string participantID, string participantName, string gender, string countryID)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_InsertParticipant'"+participantID+"','"+participantName+"','"+gender+"','"+countryID+"'", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success;
        }
        public int UpdateParticipant(string participantID, string participantName, string gender, string countryID)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_UpdateParticipant'" + participantID + "','" + participantName + "','" + gender + "','" + countryID + "'", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success;
        }
        public int DeleteParticipant(string participantID)
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_DeleteParticipant'"+participantID+"'", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success;
        }
        public string SelectPlacingParticipantName(string participantID)
        {
            // not sure if this works...

            string participantName = "";

            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            DataColumn dc = new DataColumn();
            dbCmd = new SqlCommand("sp_SelectPlacingParticipantName'"+participantID+"'", dbConn);
            dbReader = dbCmd.ExecuteReader();

            while (dbReader.Read())
            {
                participantName = dbReader[0].ToString();
            }
            dbReader.Close();
            return participantName;
        }
        public string SelectEventDisciplineDesc(string disciplineCode)
        {
            string disciplineDesc = "";
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("sp_SelectEventDisciplineDesc'"+disciplineCode+"'", dbConn);
            dbReader = dbCmd.ExecuteReader();

            while (dbReader.Read())
            {
                disciplineDesc = dbReader[0].ToString();
            }
            dbReader.Close();
            return disciplineDesc;
        }

        // placing tables
        public DataTable SelectMedalWinners()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectMedalWinners", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public DataTable SelectAllPlacings()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectAllPlacings", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public int InsertPlacing()
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            dbCmd = new SqlCommand();
            int success = dbCmd.ExecuteNonQuery();
            return success;
 
        }
        public int UpdatePlacing()
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            dbCmd = new SqlCommand();
            int success = dbCmd.ExecuteNonQuery();
            return success; 
        }
        public int DeletePlacing()
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();
            dbCmd = new SqlCommand();
            int success = dbCmd.ExecuteNonQuery();
            return success; 
        }

        // olympics games
        public DataTable SelectOlympics()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand("sp_SelectOlympicGames", dbConn);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }
        public int InsertOlympics()
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success; 
        }
        public int UpdateOlympics()
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success;
        }
        public int DeleteOlympics()
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand("", dbConn);
            int success = dbCmd.ExecuteNonQuery();
            return success;
        }
        // start page info.

        //public DataTable SelectCountryFlag()
        //{
        //    dt = new DataTable();
        //    dbCmd = new SqlCommand();
        //    dbAdapter = new SqlDataAdapter(dbCmd);
        //    dbAdapter.Fill(dt);
        //    return dt;
        //}

        //public int InsertFlags()
        //{
        //    if (dbConn.State == ConnectionState.Closed)
        //        dbConn.Open();
        //    dbCmd = new SqlCommand("INSERT INTO CountryFlag (Flag) VALUES (countryFlag) WHERE countryflag.text = countryName ",dbConn);
        //    int success = dbCmd.ExecuteNonQuery();
        //    return success; 
        //}
    }
}
