using ClassLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repository
{
    public  class WebApiRepoEF : IWebApiRepoEF
    {

        private readonly ContextClass _Context;

      public WebApiRepoEF (ContextClass con)
        {
            _Context = con;
             
        }


        public List<EFModel> SP_EFList()
        {
            try
            {
                var List = _Context.EFWebApitable.FromSqlRaw<EFModel>("exec dbo.GetAllRegistrationEFWebApi").ToList();
                return List;

                    
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw;
            }
           

        }

        public EFModel SP_EFListId(int Empid)
        {
            try
            {
                var IdList = _Context.EFWebApitable.FromSqlRaw<EFModel>($"exec GetRegistrationByIdEFWebApi {Empid}").ToList();
                return IdList.FirstOrDefault();
            }
            catch(SqlException Ex)
            {
                throw Ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void SP_EFUpdate(EFModel model)
        {
            try
            {
                _Context.Database.ExecuteSqlRawAsync($"exec UpdateRegistrationEFWebApi '{model.Empid}','{model.FirstName}','{model.Age}','{model.Email}','{model.Gender}','{model.Location}'");
            }
            catch (SqlException EX)
            {
                throw EX;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        public void SP_EFDelete(int Empid)
        {
            try
            {
                _Context.Database.ExecuteSqlRaw($"exec DeleteRegistrationByIdEFWebApi {Empid}");
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SP_EFInsert(EFModel model)
        {
            try
            {
                _Context.Database.ExecuteSqlRaw($"exec InsertRegistrationEFWebApi '{model.FirstName}','{model.Age}','{model.Email}','{model.Gender}','{model.Location}'");
            }
            catch (SqlException EX)
            {
                throw EX;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
