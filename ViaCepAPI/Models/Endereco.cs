using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViaCepAPI.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Cep { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Logradouro { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Complemento { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Bairro { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Localidade { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Uf { get; set; }
    }
}
