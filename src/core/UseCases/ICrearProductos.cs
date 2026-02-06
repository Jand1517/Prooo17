using Mercadito_UTM.Core.Entities;

namespace Mercadito_UTM.Core.UseCases
{
    public interface ICrearProductos
    {
        void Ejecutar(Articulo articulo);
    }
}