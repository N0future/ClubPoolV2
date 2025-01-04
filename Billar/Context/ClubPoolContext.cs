using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billar.Models;
using Microsoft.EntityFrameworkCore;

namespace Billar.Context
{
    public class ClubPoolContext : DbContext
    {
        public DbSet<Mesa> Mesa { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Venta> Venta { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Detalle_Venta> Detalle_Venta { get; set; }
        public DbSet<Detalle_Caja> Detalle_Caja { get; set; }

        public DbSet<Caja> Caja { get; set; }  // Nueva tabla Caja
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Oscar\\SQLEXPRESS;Database=ClubPool;User Id=sa;Password=root;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relación entre Venta y Mesa (una mesa puede tener muchas ventas)
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Mesa)
                .WithMany()
                .HasForeignKey(v => v.Fk_Id_Mesa)
                .OnDelete(DeleteBehavior.Restrict); // Evitar eliminación en cascada
                                                    // Configurar la relación entre Venta y Usuario
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Usuario)
                .WithMany(u => u.Ventas)
                .HasForeignKey(v => v.Fk_Id_Usuario);

            // Relación entre Detalle_Venta y Venta (una venta puede tener muchos detalles)
            modelBuilder.Entity<Detalle_Venta>()
                .HasOne(dv => dv.Venta)
                .WithMany(v => v.Detalle_Ventas)
                .HasForeignKey(dv => dv.Fk_Id_Venta)
                .OnDelete(DeleteBehavior.Cascade); // Si se elimina la venta, también se eliminan los detalles

            // Relación entre Detalle_Venta y Producto (un producto puede estar en muchos detalles)
            modelBuilder.Entity<Detalle_Venta>()
                .HasOne(dv => dv.Producto)
                .WithMany()
                .HasForeignKey(dv => dv.Fk_Id_Producto)
                .OnDelete(DeleteBehavior.Restrict); // Evitar eliminación en cascada de productos

           
     
            // Relación entre Venta y Caja (una caja puede tener muchas ventas)
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Caja)
                .WithMany()
                .HasForeignKey(v => v.Fk_Id_Caja)
                .OnDelete(DeleteBehavior.Restrict); // Evitar eliminación en cascada de cajas


            // Relación Caja - Detalle_Caja (1 a muchos)
            modelBuilder.Entity<Caja>()
                .HasMany(c => c.Detalle_Caja)
                .WithOne(dc => dc.Caja)
                .HasForeignKey(dc => dc.Fk_Id_Caja);

            // Relación Usuario - Detalle_Caja (1 a muchos)
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Detalle_Caja)
                .WithOne(dc => dc.Usuario)
                .HasForeignKey(dc => dc.Fk_Id_Usuario);
        }
    }
}
