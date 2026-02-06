using System;
using System.Linq;
using Mercadito_UTM.Application;
using Mercadito_UTM.Core.UseCases;
using Mercadito_UTM.Core.Entities;
using System.Collections.Generic;

Console.WriteLine("Bienvenido al Mercadito UTM!");

// Instantiate the use case
IConsultarProductos consultarProductos = new ConsultarProductos();

// Get all articles
List<Articulo> allArticles = consultarProductos.Ejecutar();

// Select 25 random articles
Random random = new Random();
List<Articulo> randomArticles = allArticles.OrderBy(x => random.Next())
                                          .Take(25)
                                          .ToList();

Console.WriteLine("\n--- Mostrando 25 Artículos Aleatorios ---");
foreach (var articulo in randomArticles)
{
    Console.WriteLine($"Nombre: {articulo.Nombres}, Precio: {articulo.Precio:C}, SKU: {articulo.Sku}, Stock: {articulo.Stock}, Marca: {articulo.Marca}");
}

Console.WriteLine("\n--- Demostración de Creación de Productos ---");

// Instantiate the create product use case
ICrearProductos crearProductos = new CrearProductos();
Random createRandom = new Random();

for (int i = 1; i <= 5; i++)
{
    Articulo nuevoArticulo = new Articulo
    {
        Nombres = $"Producto Creado {i}",
        Precio = Math.Round((decimal)createRandom.NextDouble() * 100, 2),
        Sku = $"CREATED_SKU_{i:D3}",
        Stock = createRandom.Next(5, 50),
        Marca = $"Marca Creada {createRandom.Next(1, 3)}"
    };
    crearProductos.Ejecutar(nuevoArticulo);
}

Console.WriteLine("\n--- Artículos creados (desde el almacenamiento en memoria) ---");
foreach (var articulo in CrearProductos.GetArticulosCreados())
{
    Console.WriteLine($"Nombre: {articulo.Nombres}, Precio: {articulo.Precio:C}, SKU: {articulo.Sku}, Stock: {articulo.Stock}, Marca: {articulo.Marca}");
}

Console.WriteLine("\n--- Fin de la demostración ---");

