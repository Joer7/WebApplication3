using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                #region Obtener Pago
                string cadena = "Server=(localdb)\\MSSQLLocalDB;Database=CRUDMyRestauranteFinal;Integrated Security=True;Trusted_Connection=false;MultipleActiveResultSets=true";
                SqlConnection con = new SqlConnection(cadena);
                string sentencia = "SELECT codPlato,codCliente,Apellido,NamePlato,cantidad,precio,precio * cantidad as totalPedido From pedidos as p inner join users as cliente on p.codCliente = cliente.Id Inner Join productos as pro on p.codPlato = pro.Cod_Plato";
                SqlDataAdapter da = new SqlDataAdapter(sentencia, con);

                DataTable dt = new DataTable();
                //llenado datatable
                da.Fill(dt);

                #endregion
                TempData["MSG"] = "Estos son los pagos";
                //return View("Index",dt);
                return View(dt);
            }
            catch (Exception ex)
            {
                TempData["ERROR"] = ex.Message;
                DataTable dt = new DataTable();
                //return View("Index");
                return View();
            }
          
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
