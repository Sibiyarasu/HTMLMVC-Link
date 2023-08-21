using ClassLibrary.Model;
using Dapper;
using System;
using System.Data.SqlClient;

namespace ClassLibrary.Repository
{
    class DesignRepository
    {
        public readonly string conectionstring;

        public DesignRepository()
        {

            conectionstring = @"Data source=DESKTOP-TKPKUBE\SQLEXPRESS;Initial catalog=SQL QUERIES;User Id=sa;Password=Anaiyaan@123";
        }

        public void Insert(DesignModel A)
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                con.Open();
                con.Execute($"exec InsertDesign' '{A.FirstName}',{A.Lastname},'{A.Email}','{A.PhoneNumber}','{A.message}'");

                con.Close();

            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
