using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ClassLibrary.Model;
using System.Data.SqlClient;

namespace ClassLibrary.Repository
{
    //class ProductTypeRepository
    //{
        public class ProductTypeRepository
        {
            public readonly string connectionString;



            public ProductTypeRepository()
            {
                connectionString = @"Data source=DESKTOP-TKPKUBE\SQLEXPRESS;Initial catalog=Product;User Id=sa;Password=Anaiyaan@123";
            }

            public void InsertProductType(DropDownModel Type)
            {

                try
                {
                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();
                    con.Execute($" exec dbo.InsertProductType '{Type.ProductType}'");

                    con.Close();

                }
                catch (SqlException ex)
                {
                    throw;
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
            public DropDownModel GetProductTypeById(int id)
            {
                try
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    var connection = new SqlConnection(connectionString);
                    con.Open();
                    var student = connection.QueryFirst<DropDownModel>($" exec dbo.GetproductById { id} ");
                    con.Close();



                    return student;


                }

                catch (SqlException er)
                {
                    throw;
                }
                catch (Exception r)
                {
                    throw r;
                }
            }

            public List<DropDownModel> GetProductType()
            {
                try
                {
                    List<DropDownModel> constrain = new List<DropDownModel>();

                    var connection = new SqlConnection(connectionString);
                    connection.Open();
                    constrain = connection.Query<DropDownModel>($"exec dbo.GetProductType ").ToList();
                    connection.Close();

                    return constrain;


                }

                catch (SqlException er)
                {
                    throw;
                }
                catch (Exception r)
                {
                    throw r;
                }
            }

            public void UpdateProductType(DropDownModel Type)
            {
                try
                {

                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();
                    con.Execute($" 	exec dbo.UpdateProductType  '{Type.ProductTypeId}','{Type.ProductType}'");
                    con.Close();
                }
                catch (SqlException eu)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            public void DeleteProductType(int id)
            {
                try
                {


                    SqlConnection con = new SqlConnection(connectionString);

                    con.Open();
                    con.Execute($" exec dbo.DeleteProductType { id}");

                    con.Close();

                }
                catch (SqlException ed)
                {
                    throw;
                }
                catch (Exception ex)
                {
                    throw ex;
                }



            }
        }  }
        
