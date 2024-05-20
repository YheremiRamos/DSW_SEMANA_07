using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Proyecto.Presentacion.Models;
using System.Security.Policy;
using System.Text;

namespace Proyecto.Presentacion.Controllers
{
    public class VendedorController : Controller
    {

       

        private IVendedor procesosVendedor;

        //Cadena de conexion hacia el servicio
        Uri baseAddress = new Uri("https://localhost:7142/api");
        private readonly HttpClient _httpClient;


        public VendedorController()
        {
            procesosVendedor = new RepositorioVendedor();

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = baseAddress;
        }



        [HttpGet]
        //LISTADO DE VENDEDORES 
        public IActionResult listadoVendedores()
        {
            List<Vendedor> aVendedores = new List<Vendedor>();
            HttpResponseMessage response =
                _httpClient.GetAsync(_httpClient.BaseAddress + "/Vendedor/listadoVendedores").Result;

            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                aVendedores = JsonConvert.DeserializeObject<List<Vendedor>>(data);
            }


            return View(aVendedores);
        }

        /*public IActionResult listadoVendedores() {
            return View(procesosVendedor.listadoVendedor());
        }
*/


        [HttpGet]
        public IActionResult nuevoVendedor()
        {
            ViewBag.distrito = new SelectList(procesosVendedor.listadoDistrito(), "ide_dis", "nom_dis");
            return View(new VendedorO());
        }
        [HttpPost]
        public async Task<IActionResult> nuevoVendedor(VendedorO objC)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.distrito = new SelectList(procesosVendedor.listadoDistrito(), "ide_dis", "nom_dis");
                return View(objC);
            }
            var json = JsonConvert.SerializeObject(objC);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var responseC = await
            _httpClient.PostAsync("/api/Vendedor/nuevoVendedor", content);
            if (responseC.IsSuccessStatusCode)
            {
                ViewBag.mensaje = "Vendedor registrado correctamente..!!!";
            }
            ViewBag.distrito = new SelectList(procesosVendedor.listadoDistrito(), "ide_dis", "nom_dis");
            return View(objC);
        }



        /*
         
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



        }*/

        public IActionResult Index()
        {
            return View();
        }

    }
}
