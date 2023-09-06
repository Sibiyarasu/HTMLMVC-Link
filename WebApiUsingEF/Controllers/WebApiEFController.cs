using ClassLibrary.Model;
using ClassLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiUsingEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebApiEFController : ControllerBase
    {

        public  IWebApiRepoEF _EFObj;

        public WebApiEFController(IWebApiRepoEF obj)
        {
            _EFObj = obj;
        }
        // GET: api/<WebApiEFController>
        [HttpGet("getalldata")]
        public IEnumerable<EFModel> Get()
        {
            try
            {
                return _EFObj.SP_EFList();

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // GET api/<WebApiEFController>/5
        [HttpGet("{Empid}")]
        public EFModel Get(int Empid)
        {
            try
            {
                return _EFObj.SP_EFListId(Empid);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        // POST api/<WebApiEFController>
        [HttpPost]
        public void Post([FromBody] EFModel value)
        {

            try
            {
                _EFObj.SP_EFInsert(value);

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<WebApiEFController>/5
        [HttpPut("{empid}")]
        public void Put(int empid, [FromBody] EFModel value)
        {
            try
            {
                value.Empid = empid;
                _EFObj.SP_EFUpdate(value);
            }
            catch(Exception ex)
            {
                throw ex;
            }
          
        }

        // DELETE api/<WebApiEFController>/5
        [HttpDelete("{Empid}")]
        public void Delete(int Empid)
        {
            try
            {
                _EFObj.SP_EFDelete(Empid);

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
