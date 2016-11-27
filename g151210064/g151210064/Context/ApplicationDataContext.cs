using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using g151210051.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace g151210051.Context
{
    public class ApplicationDataContext : IdentityDbContext<AppUser>
    {
        public ApplicationDataContext()
            : base("DefaultConnection")
        { }

        public System.Data.Entity.DbSet<AppUser> AppUsers { get; set; }
    }
}