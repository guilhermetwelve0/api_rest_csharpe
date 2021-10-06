using System;
using System.Collections.Generic;
using System.Text;
using APIREST.Models;
using Microsoft.EntityFrameworkCore;


namespace APIREST.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}