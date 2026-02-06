using System.Collections.Generic;
using Mercadito_UTM.Core.Entities;
using Mercadito_UTM.Core.UseCases;

namespace Mercadito_UTM.Application
{
    public class CrearProductos : ICrearProductos
    {
        // For demonstration, we'll use a static list to simulate storage.
        // In a real application, this would interact with a repository or data access layer.
        private static List<Articulo> _articulosCreados = new List<Articulo>();

        public void Ejecutar(Articulo articulo)
        {
            // In a real scenario, you'd add validation, generate IDs, and persist the article.
            _articulosCreados.Add(articulo);
            System.Console.WriteLine($"Artículo '{articulo.Nombres}' creado y añadido a la lista en memoria.");
        }

        // Optional: A way to retrieve the created articles for testing/demonstration
        public static List<Articulo> GetArticulosCreados()
        {
            return _articulosCreados;
        }
    }
}