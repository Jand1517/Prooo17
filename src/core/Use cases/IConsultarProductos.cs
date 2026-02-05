using MercaditoUTM.src.core.Entities;
using System.Collections.Generic;

namespace core.Use_cases
{
    public interface IConsultarProductos
    {
        List<Articulo> GetAll();
    }
}
