using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System;
using System.Data.SqlClient;
using ClassLibrary.Model;

namespace ClassLibrary.Repository
{
    public class ProductRepository
    {

        public readonly string conectionstring;

        public ProductRepository()
        {

            conectionstring = @"Data source=DESKTOP-TKPKUBE\SQLEXPRESS;Initial catalog=Product;User Id=sa;Password=Anaiyaan@123";
        }

        public List<ProductModel> SelectSP()

        {
            try
            {
                List<ProductModel> constrain = new List<ProductModel>();

                var connection = new SqlConnection(conectionstring);
                connection.Open();
                constrain = connection.Query<ProductModel>("  exec dbo.Getproduct ", conectionstring).ToList();
                connection.Close();

                return constrain;

            }
            catch (SqlException e)
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

    

