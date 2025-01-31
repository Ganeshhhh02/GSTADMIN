using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EFCodeFirst.Models;

namespace EFCodeFirst.Context
{
    public class AdminContext:DbContext
    {
        public DbSet<User> tblUser { get; set; }
    }
}