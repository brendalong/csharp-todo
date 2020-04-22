using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimpleToDo.Models;

namespace SimpleToDo.Data
{
    //Tell Identity and Entity about my custom ApplicationUser class
    //Need to modify startup.cs and with ApplicationUser instead of IdentityUser
    //Need to modify _LoginPartial.cshtml also
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}