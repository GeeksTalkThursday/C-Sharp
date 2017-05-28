using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Context
{
    public class SchoolContext:DbContext
    {
        public DbSet<Models.student> student { get; set; }
    }
}