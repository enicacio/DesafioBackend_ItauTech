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
    public class ContaController : Controller
    {
        public async Task<IActionResult> AllConta() {

            //Definir meu cliente HTTP
            HttpClient clienteHTTP = new HttpClient();

            // Ler os dados da API e guardar em uma string de
            string result = await clienteHTTP.GetStringAsync("http://localhost:8080/contas");
            
            // Converter de Json para uma lisa do meu modelo/objeto
            List<Conta> titular = JsonSerializer.Deserialize<List<Conta>>(result);
          //  Titular teste = new Titular();
           // teste.contas.t
            return View(titular);
        }
        public IActionResult ClienteIndex()
        {
        return View();
        }

        [HttpGet]
        public IActionResult GetContaPorID()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetContaPorID(int id)
        {
            HttpClient clienteHTTP = new HttpClient();

            //Guardar o resultado do JSON em uma string
            string resultado = await clienteHTTP.GetStringAsync($"http://localhost:8080/contas/{id}");

            Conta conta = JsonSerializer.Deserialize<Conta>(resultado);

            return View(conta);
        }
    }
}