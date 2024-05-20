using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Presentacion.Models;
using Ventas_API.Repositorio.DAO;
using Ventas_API.Repositorio.Interfaces;

namespace Ventas_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        [HttpGet("listadoVendedores")]
        public async Task<ActionResult<List<Vendedor>>> listadoVendedor()
        {
            var lista = await Task.Run(() => new VendedorDAO().listadoVendedor());
            return Ok(lista);
        }

        [HttpPost("nuevoVendedor")]
        public async Task<ActionResult<string>> nuevocliente(VendedorO objC)
        {
            var mensaje = await Task.Run(() =>
            new VendedorDAO().nuevoVendedor(objC));
            return Ok(mensaje);
        }


    }
}

