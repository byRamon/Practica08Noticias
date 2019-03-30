using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Practica08Noticias.Models;

namespace Practica08Noticias.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Practica08Noticias.Models.Categorias> Categorias { get; set; }
        public DbSet<Practica08Noticias.Models.Noticias> Noticias { get; set; }
    }
}
