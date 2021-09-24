using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webApiEIT.Models;

namespace webApiEIT.Data
{
    public class webApiEITContext : DbContext
    {
        public webApiEITContext (DbContextOptions<webApiEITContext> options)
            : base(options)
        {
        }

        public DbSet<webApiEIT.Models.Book> Book { get; set; }
    }
}
