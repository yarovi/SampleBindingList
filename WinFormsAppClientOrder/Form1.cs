using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using WinFormsAppClientOrder.entity;

namespace WinFormsAppClientOrder
{
	public partial class Form1 : Form
	{
		BindingList<Cliente> clientesList = new BindingList<Cliente>();
		public Form1()
		{
			InitializeComponent();
			using(var context = new AppDbContext())
			{
				clientesList = new BindingList<Cliente>(context.Clientes
					.Include(c => c.Ordenes)
					.ToList());
			}
			dgv.DataSource = clientesList;

		}

		private void btnInsert_Click(object sender, EventArgs e)
		{

			using (var context = new AppDbContext())
			{
				int count = context.Clientes.Count();
				// Crear un cliente con órdenes
				var cliente = new Cliente
				{
					Nombre = "Juan Pérez - " + count,
					Ordenes = new List<Orden>
				{
					new Orden { Producto = "Laptop", Precio = 1200m },
					new Orden { Producto = "Mouse", Precio = 25m }
				}
				};
				context.Clientes.Add(cliente);
				context.SaveChanges();

				Console.WriteLine("Cliente y órdenes guardadas.");
				clientesList.Add(cliente);
				Debug.WriteLine("Cliente y órdenes guardadas. -> " + cliente);
			}
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{

			using (var context = new AppDbContext())
			{
				var clientesConOrdenes = context.Clientes
					.Include(c => c.Ordenes) // Cargar también sus órdenes
					.ToList();

				foreach (var cliente in clientesConOrdenes)
				{
					Console.WriteLine($"Cliente: {cliente.Nombre}");
					foreach (var orden in cliente.Ordenes)
					{
						Console.WriteLine($"  - {orden.Producto} (${orden.Precio})");
					}
				}
			}
		}

		private void btnGridView_Click(object sender, EventArgs e)
		{

			try
			{
				foreach (var cliente in clientesList)
				{
					Debug.Print($"Cliente: {cliente.Nombre}");
					foreach (var orden in cliente.Ordenes)
					{
						Debug.Print($"  - {orden.Producto} (${orden.Precio})");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0)
				{
					var cliente = (Cliente)dgv.Rows[e.RowIndex].DataBoundItem;
					if (cliente != null)
					{
						using (var context = new AppDbContext())
						{
							context.Clientes.Update(cliente);
							context.SaveChanges();
						}
						Debug.WriteLine($"Cliente actualizado: {cliente.Nombre}");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al actualizar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
