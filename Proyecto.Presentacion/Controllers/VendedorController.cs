using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyecto.Presentacion.Models;

namespace Proyecto.Presentacion.Controllers
{
    public class VendedorController : Controller
    {

        private IVendedor procesosVendedor;


        public VendedorController()
        {
            procesosVendedor = new RepositorioVendedor();
        }

        public IActionResult Index()
        {
            return View();
        }

        //LISTADO DE VENDEDORES 
        public IActionResult listadoVendedores() {
            return View(procesosVendedor.listadoVendedor());
        }


        //REGISTRAR NUEVO VENDEDOR
        [HttpGet]
        public IActionResult nuevoVendedor() {

            ViewBag.distrito = new SelectList(procesosVendedor.listadoDistrito(),"ide_dis","nom_dis");
            return View(new VendedorO());  
        }   

        [HttpPost]
        public IActionResult nuevoVendedor(VendedorO objV)
        {
            if (!ModelState.IsValid)
            { 
                ViewBag.distrito = new SelectList(procesosVendedor.listadoDistrito(),"ide_dis","nom_dis");
                return View(objV);
            }
            ViewBag.distrito = new SelectList(procesosVendedor.listadoDistrito(), "ide_dis", "nom_dis");
            ViewBag.mensaje = procesosVendedor.nuevoVendedor(objV);
            return View(objV);



        }

    }
}
