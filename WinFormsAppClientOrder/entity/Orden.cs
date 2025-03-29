using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppClientOrder.entity
{
	internal class Orden
	{
		public int Id { get; set; }  // Primary Key
		public string Producto { get; set; }
		public decimal Precio { get; set; }

		// Clave foránea
		public int ClienteId { get; set; }

		// Relación con Cliente
		public Cliente Cliente { get; set; }

		public override string ToString()
		{
			return $"Orden: {Producto} (${Precio})";
		}
	}
}
