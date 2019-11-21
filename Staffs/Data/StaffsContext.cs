using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Staffs.Models
{
    public class StaffsContext : DbContext
    {
        public StaffsContext (DbContextOptions<StaffsContext> options)
            : base(options)
        {
        }

        public DbSet<Staffs.Models.TodoItem> TodoItem { get; set; }
    }
}
