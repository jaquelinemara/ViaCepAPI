using Microsoft.AspNetCore.Mvc;
using ViaCepAPI.DAL;
using ViaCepAPI.Models;

namespace ViaCepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoAPIController : ControllerBase
    {
        private readonly EnderecoDAO _enderecoDAO;
        public EnderecoAPIController(EnderecoDAO enderecoDAO)
        {
            _enderecoDAO = enderecoDAO;
        }

        //GET: /api/Endereco/ListarEnderecos
        [HttpGet]
        [Route("ListarEnderecos")]
        public IActionResult Listar()
        {
            return Ok(_enderecoDAO.Listar());
        }

        //GET: /api/Endereco/ListarEnderecos/{cep}
        [HttpGet]
        [Route("ListarEnderecos/{cep}")]
        public IActionResult Listar(string endereco)
        {
            return Ok(_enderecoDAO.Listar(endereco));
        }

        //POST: /api/Endereco/CadastrarEndereco
        [HttpPost]
        [Route("CadastrarEndereco")]
        public IActionResult Criar(Endereco endereco)
        {
            _enderecoDAO.Cadastrar(endereco);
            return Created("", endereco);
        }

        //PUT: /api/Endereco/AlterarEndereco
        [HttpPut]
        [Route("AlterarEndereco")]
        public IActionResult Alterar(Endereco endereco)
        {
            return Ok(_enderecoDAO.Atualizar(endereco));
        }

        //DELETE: /api/Endereco/DeletarEndereco/{cepID}
        [HttpDelete]
        [Route("DeletarEndereco/{id}")]
        public IActionResult Deletar(string enderecoid)
        {
            return Ok(_enderecoDAO.Deletar(enderecoid));
        }
    }
}
