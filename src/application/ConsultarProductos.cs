using System.Collections.Generic;
using Mercadito_UTM.Core.Entities;
using Mercadito_UTM.Core.UseCases;

namespace Mercadito_UTM.Application
{
    public class ConsultarProductos : IConsultarProductos
    {
        public List<Articulo> Ejecutar()
        {
            // For now, return a dummy list as there's no data source.
            // In a real application, this would interact with a repository or data access layer.
            var articulos = new List<Articulo>();
            var random = new Random();

            for (int i = 1; i <= 30; i++)
            {
                articulos.Add(new Articulo
                {
                    Nombres = $"Articulo Generado {i}",
                    Precio = Math.Round((decimal)random.NextDouble() * 100, 2), // Price between 0.00 and 100.00
                    Sku = $"SKU{i:D3}",
                    Stock = random.Next(10, 200), // Stock between 10 and 199
                    Marca = $"Marca {random.Next(1, 5)}"
                });
            }
            return articulos;
        }
    }
}