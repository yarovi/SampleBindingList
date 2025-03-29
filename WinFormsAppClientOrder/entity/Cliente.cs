using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppClientOrder.entity
{
	internal class Cliente
	{
		public int Id { get; set; }  // Primary Key
		public string Nombre { get; set; }

		// Relación uno a muchos (Cliente tiene muchas Ordenes)
		public ICollection<Orden> Ordenes { get; set; } = new List<Orden>();

		public override string ToString()
		{
			string ordenesStr = Ordenes.Any()
			? string.Join(", ", Ordenes.Select(o => $"{o.Producto} - ${o.Precio}"))
			: "Sin órdenes";
			return $"Cliente: {Nombre} id:{Id} Odenes: {ordenesStr}" ;
		}
	}
}
