using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;

namespace Frontend.Controllers {
    public class BancoController : Controller {
        public IActionResult Index() {
            return View();
        }

        // Fazer a leitura de todas as contas
        public async Task<IActionResult> GetContas() {
            HttpClient clienteHTTP = new HttpClient();

            // Guardar o resultado json em uma string
            string result = await clienteHTTP.GetStringAsync("http://localhost:8080/contas");

            // Converter o Json(string) para um objeto
            List<Conta> titular = JsonSerializer.Deserialize<List<Conta>>(result);
            
            return View(titular);
        }
        public IActionResult ClienteIndex()
        {
        return View();
        }

        // Get pelo Numero da Conta
        [HttpGet]
        public IActionResult GetContaPorNum() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetContaPorNum(long numConta) {
            
            HttpClient clienteHTTP = new HttpClient();

            // Guardar o resultado json em uma string
            string resultado = await clienteHTTP.GetStringAsync($"http://localhost:8080/contas/{numConta}");

            // Converter o Json(string) para um objeto
            Conta conta = JsonSerializer.Deserialize<Conta>(resultado);
            
            return View(conta);
        }

        //Procurar por CodInt Titular
        public async Task<IActionResult> GetTitular() {
            HttpClient clienteHTTP = new HttpClient();

            // Guardar o resultado json em uma string
            string resultado = await clienteHTTP.GetStringAsync("http://localhost:8080/clientes");

            // Converter o Json(string) para um objeto
            List<Titular> clientes = JsonSerializer.Deserialize<List<Titular>>(resultado);

            return View(clientes);
        }
        
        [HttpGet]
        public IActionResult GetTitularPorCod()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetTitularPorCod(long codInt)
        {
            HttpClient clienteHTTP = new HttpClient();

            //Guardar o resultado do JSON em uma string
            string resultado = await clienteHTTP.GetStringAsync($"http://localhost:8080/clientes/{codInt}");

            Titular titular = JsonSerializer.Deserialize<Titular>(resultado);

            return View(titular);
        }
    }
}