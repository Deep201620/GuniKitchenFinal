using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GuniKitchen_Final.Models;

namespace GuniKitchen_Final.Data
{
    public class ApplicationDbContext : IdentityDbContext<RegisterUser, UserRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
