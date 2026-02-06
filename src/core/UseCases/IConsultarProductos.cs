using System.Collections.Generic;
using Mercadito_UTM.Core.Entities;

namespace Mercadito_UTM.Core.UseCases
{
    public interface IConsultarProductos
    {
        List<Articulo> Ejecutar();
    }
}