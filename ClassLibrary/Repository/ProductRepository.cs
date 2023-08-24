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
                constrain = connection.Query<ProductModel>($"  exec dbo.Getproduct ", conectionstring).ToList();
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


        public void InsertProduct(ProductModel model)
        {
            try
            {

                SqlConnection con = new SqlConnection(conectionstring);

                con.Open();
                con.Execute($"EXEC DBO.InsertProduct '{model.ProductName}','{model.Type}','{model.Quantity}','{model.Price}','{model.ProductCode}'");

                con.Close();

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

        public ProductModel SelectProductById(int Productid)

        {
            try
            {



                SqlConnection connection = new SqlConnection(conectionstring);
                connection.Open();
                var res = connection.QueryFirst<ProductModel>($"exec dbo.GetproductById {Productid}");
                connection.Close();

                return res;
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


        public void UpdateProduct(ProductModel s)
        {
            try
            {
                SqlConnection con = new SqlConnection(conectionstring);


                con.Open();
                con.Execute($"  exec dbo.UpdateProduct '{s.Productid}','{s.ProductName}','{s.Type}','{s.Quantity}','{s.Price}','{s.ProductCode}' ");



                con.Close();

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


        public ProductModel Deleteproduct(int productid)

        {
            try
            {



                SqlConnection connection = new SqlConnection(conectionstring);
                connection.Open();
                var res = connection.QueryFirst<ProductModel>($"exec dbo.DeleteProduct {productid}");

                connection.Close();

                return res;

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



