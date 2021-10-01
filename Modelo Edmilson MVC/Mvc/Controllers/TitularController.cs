using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections;
using Mvc.Models;
using System.Text.Json;
using System.Collections.Generic;
namespace Mvc.Controllers
{
    public class TitularController : Controller
    {

        public async Task<IActionResult> AllTitular() {

            //Definir meu cliente HTTP
            HttpClient clienteHTTP = new HttpClient();

            // Ler os dados da API e guardar em uma string de
            string result = await clienteHTTP.GetStringAsync("http://localhost:8080/clientes");
            
            // Converter de Json para uma lisa do meu modelo/objeto
            IEnumerable<Titular> cliente1 = JsonSerializer.Deserialize<IEnumerable<Titular>>(result);
            
            return View(cliente1);
        }
        public IActionResult ClienteIndex()
        {
        return View();
        }
    }
}