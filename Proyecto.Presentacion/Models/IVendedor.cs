namespace Proyecto.Presentacion.Models
{
    public interface IVendedor
    {
        //Definir los metodos de mantenimiento de vendededor 
        //no se esta haciendo implementacion 

        IEnumerable<Vendedor> listadoVendedor();
        IEnumerable<VendedorO> listadoVendedorO();
        IEnumerable<Distrito> listadoDistrito();
        string nuevoVendedor(VendedorO objV);
        string modificaVendedor(VendedorO objV);
 
    }
}
