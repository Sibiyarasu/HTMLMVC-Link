using ClassLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Repository
{
    public  class ContextClass : DbContext
    {
        public  ContextClass(DbContextOptions options) : base(options)
        {

        }

        public DbSet<EFModel> EFWebApitable { get; set; }
    }
}
