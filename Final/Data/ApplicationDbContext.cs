using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Final.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Servicio> servicios { get; set; }

        public DbSet<ClienteFinal> ClienteFinal { get; set; }

        public DbSet<Factura> Factura { get; set; }

        public DbSet<Producto_Facturado> Producto_Facturado { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>(entityTypeBuilder => {
                entityTypeBuilder.ToTable("Clientes");
                entityTypeBuilder.Property(u => u.Uid).HasMaxLength(100).IsRequired();
                entityTypeBuilder.Property(u => u.Nombre).HasMaxLength(100);               
                entityTypeBuilder.Property(u => u.Telefono).HasMaxLength(100);
                entityTypeBuilder.Property(u => u.Cedula).HasMaxLength(100);
                entityTypeBuilder.Property(u => u.NombreComercial).HasMaxLength(100);
                entityTypeBuilder.Property(u => u.Direccion).HasMaxLength(100);
                entityTypeBuilder.Property(u => u.PagWeb).HasMaxLength(100);
               
            });
        }
    }
    public class AppUser : IdentityUser
    {
        public Guid Uid { get; set; }
        public string Nombre { get; set; }      
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string NombreComercial { get; set; }
        public string Direccion { get; set; }
        public string PagWeb { get; set; }


    }
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

    }

    public class Servicio
    {
        [Key]
        public int IdServicio { get; set; }
        public string Nombre_Servicio { get; set; }
        public string Precio_servicio { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }

    }

    public class ClienteFinal
    {
        [Key]
        public int Cliente_Id { get; set; }
        public string RNC { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha { get; set; }

    }

    public class Factura
    {
        [Key]
        public int Id_Factura { get; set; }
        public string Nombre_Producto { get; set; }
        public string Nombre_Servicio { get; set; }
        public int Cantidad_Prod { get; set; }
        public int Cantidad_Serv { get; set; }
        public double Monto_Total { get; set; }
        public double Itbis { get; set; }
        public string Hora { get; set; }
        public DateTime Fecha { get; set; }
        public int Cliente_Id { get; set; }
        public ClienteFinal ClienteFinal { get; set; }

    }

    public class Producto_Facturado
    {
        [Key]
        public int IdProducto_Facturados { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public int Id_Factura { get; set; }
        public Factura Factura { get; set; }
    }


}
