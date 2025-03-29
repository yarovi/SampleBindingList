using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppClientOrder.entity;
namespace WinFormsAppClientOrder
{
	internal class AppDbContext : DbContext
	{
		public AppDbContext() { }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Orden> Ordenes { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				var connectionString = "Server=127.0.0.1;Database=MiTienda;Uid=root;Port=3306;Pwd=2006702231;";
				var serverVersion = ServerVersion.AutoDetect(connectionString);
				optionsBuilder.UseMySql(connectionString, serverVersion);
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cliente>()
				.HasMany(c => c.Ordenes)   // Un Cliente tiene muchas Órdenes
				.WithOne(o => o.Cliente)   // Una Orden tiene un Cliente
				.HasForeignKey(o => o.ClienteId); // Clave foránea
		}
	}
}
