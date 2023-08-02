using AspNetCoreIdentity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Context
{
    public class UContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public UContext(DbContextOptions<UContext> options) : base(options)
        {

        }



    }
}
