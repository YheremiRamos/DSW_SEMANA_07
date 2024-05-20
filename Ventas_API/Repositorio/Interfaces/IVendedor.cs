using Proyecto.Presentacion.Models;

namespace Ventas_API.Repositorio.Interfaces
{
    public interface IVendedor
    {
        IEnumerable<Vendedor> listadoVendedor();

        IEnumerable<VendedorO> listadoVendedorO();

        VendedorO buscarVendedor(int id);

        string nuevoVendedor(VendedorO objV);

        string modificaVendedor(VendedorO objV);


    }
}
