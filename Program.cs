using MercaditoUTM.application;
using MercaditoUTM.src.core.Entities;
using core.Use_cases;
using System;
using System.Collections.Generic;

IConsultarProductos consultarProductos = new ConsultarProductos();
List<Articulo> articulos = consultarProductos.GetAll();

Console.WriteLine("Lista de 25 productos generados aleatoriamente:");
foreach (var articulo in articulos)
{
    Console.WriteLine($"  - Nombre: {articulo.Nombre}, Precio: {articulo.Precio:C}, SKU: {articulo.SKU}, Stock: {articulo.Stock}, Marca: {articulo.Marca}");
}