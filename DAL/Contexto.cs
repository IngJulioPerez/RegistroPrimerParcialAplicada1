using System;
using System.Collections.Generic;
using System.Text;
using RegistroPrimerParcial.Entidades;
using Microsoft.EntityFrameworkCore;


namespace RegistroPrimerParcial.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Articulo> Articulo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-UA67R4G\SQLEXPRESS;Initial Catalog=Productos;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
