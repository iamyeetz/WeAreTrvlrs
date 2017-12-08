using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreTrvlrs.Model;

namespace WeAreTrvlrs.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public DbSet<OnlineUsers> OnlineUsers { get; set; }
    }
}
