// Jaqueline Mara Silva

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using ViaCepAPI.DAL;
using ViaCepAPI.Models;

namespace ViaCepAPI.Controllers
{
    public class EnderecoController : Controller //era private
    {
        private readonly EnderecoDAO _enderecoDAO;

        public EnderecoController(EnderecoDAO enderecoDAO) // Construtor do Controller
        {
            _enderecoDAO = enderecoDAO;
        }

        public IActionResult Index()
        {
            if (TempData["Cep"] != null)
            {
                // Biblioteca NewtonSoft.Json
                string resultado = TempData["Cep"].ToString();
                Endereco endereco = JsonConvert.DeserializeObject<Endereco>(resultado);

                _enderecoDAO.Cadastrar(endereco);
                                
                return View(_enderecoDAO.Listar());

            }
            return View(_enderecoDAO.Listar());
        }


        [HttpPost]
        public IActionResult PesquisarCep(string txtCep) // executar consulta do Cep no ViaCEP
        {
            string url = $@"https://viacep.com.br/ws/{txtCep}/json/";
            WebClient adress = new WebClient(); // objeto para consumir os dados
            TempData["Cep"] = adress.DownloadString(url); // trazer os dados em JSON e armazenar em uma string
            return RedirectToAction("Index");
        }
    }
}
