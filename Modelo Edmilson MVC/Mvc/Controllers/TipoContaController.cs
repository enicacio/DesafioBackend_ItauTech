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
    public class TipoContaController : Controller
    {
     public async Task<IActionResult> AllTipoConta() {

            //Definir meu cliente HTTP
            HttpClient clienteHTTP = new HttpClient();

            // Ler os dados da API e guardar em uma string de
            string result = await clienteHTTP.GetStringAsync("http://localhost:8080/contas/tipo");
            
            // Converter de Json para uma lisa do meu modelo/objeto
            IEnumerable<TipoConta> tpconta = JsonSerializer.Deserialize<IEnumerable<TipoConta>>(result);
            
            return View(tpconta);
        }
        public IActionResult TipoContaIndex()
        {
        return View();
        }
    }
}