using System.Collections.Generic;
using core.Use_cases;
using MercaditoUTM.src.core.Entities;

namespace MercaditoUTM.application
{
    public class ConsultarProductos : IConsultarProductos
    {
        public List<Articulo> GetAll()
        {
            var articulos = new List<Articulo>();
            var random = new Random();
            var nombres = new[] { "Laptop", "Mouse", "Teclado", "Monitor", "Impresora", "Webcam", "Hub USB", "Auriculares" };
            var marcas = new[] { "Dell", "Logitech", "Corsair", "HP", "Samsung", "Sony", "Microsoft" };

            for (int i = 0; i < 25; i++)
            {
                var nombre = nombres[random.Next(nombres.Length)];
                var marca = marcas[random.Next(marcas.Length)];
                articulos.Add(new Articulo
                {
                    Nombre = nombre,
                    Precio = (decimal)(random.NextDouble() * 1500),
                    SKU = $"{nombre.Substring(0, 2).ToUpper()}-{i:000}",
                    Stock = random.Next(1, 100),
                    Marca = marca
                });
            }
            return articulos;
        }
    }
}
