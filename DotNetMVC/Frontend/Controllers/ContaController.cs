using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace Frontend.Controllers {

    public class ContaController : Controller {

        public async Task<IActionResult> AllContasAsync() {

            HttpClient clientHTTP = new HttpClient();
            
            string result = await clientHTTP.GetStringAsync("http://localhost:8080/contas");
            
            IEnumerable<Conta> contas = JsonSerializer.Deserialize<IEnumerable<Conta>>(result);
            
            return View(contas);
        }
    }
}