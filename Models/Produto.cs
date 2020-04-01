using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceLiteAlexandre.Models
{
    public class Produto : BaseModel
    {
        public Produto()
        {
        }

        public Produto(string codigo, string nome, decimal precoCompra, string descricao)
        {
            Codigo = codigo;
            Nome = nome;
            PrecoCompra = precoCompra;
            Descricao = descricao;
        }

        [Required]
        public string Codigo { get; private set; }
        [MaxLength(50)]
        [Required]
        public string Nome { get; private set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal PrecoCompra { get; private set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal PrecoVenda { get; private set; }
        [MaxLength(200)]
        [Required]
        public string Descricao { get; private set; }

        public void AtualizaPrecoVenda(Pedido pedidoDB, decimal rateio)
        {
            PrecoVenda = (PrecoCompra + rateio) * (1 + pedidoDB.MargemLucro/100);
        }
    }
}
