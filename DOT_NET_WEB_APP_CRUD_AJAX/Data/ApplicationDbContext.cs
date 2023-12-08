using DOT_NET_WEB_APP_CRUD_AJAX.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DOT_NET_WEB_APP_CRUD_AJAX.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("WebApiCrudDBConn") { }
        public DbSet<Employee> Employees { get; set; }

    }
}