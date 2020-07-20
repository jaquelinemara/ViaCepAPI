using System.Collections.Generic;
using System.Linq;
using ViaCepAPI.Models;

namespace ViaCepAPI.DAL
{
    public class EnderecoDAO
    {
        public readonly Context _context;

        public EnderecoDAO(Context context)
        {
            _context = context;
        } 

        public void Cadastrar(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
        }

        public List<Endereco> Listar()
        { 
            var lista = _context.Enderecos.ToList();
            return lista;
        }

        public Endereco Listar(string endereco)
        {
            string str1 = endereco.Substring(0, 5);
            string str2 = endereco.Substring(5, 3);
            string str = $"{str1}-{str2}";
            return _context.Enderecos.First(c => c.Cep == str);
        }

        public Endereco Atualizar(Endereco endereco)
        {
            _context.Enderecos.Update(endereco);
            _context.SaveChanges();
            return _context.Enderecos.First(c => c == endereco);
        }

        public Endereco Deletar(string enderecoid)
        {
            Endereco endereco = _context.Enderecos.Find(int.Parse(enderecoid));
            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();
            return endereco;
        }
    }
}
