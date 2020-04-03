using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ECommerceLiteAlexandre.Models
{
    [DataContract]
    public class ItemPedido : BaseModel
    {
        public ItemPedido()
        {
        }

        public ItemPedido(Pedido pedido, Produto produto, int quantidade, decimal precoUnitarioCompra, decimal precoUnitarioVenda)
        {
            Pedido = pedido;
            Produto = produto;
            Quantidade = quantidade;
            PrecoUnitarioCompra = precoUnitarioCompra;
            PrecoUnitarioVenda = precoUnitarioVenda;
        }        

        [Required]
        [DataMember]
        [JsonIgnore]
        public Pedido Pedido { get; set; }
        [Required]
        [DataMember]
        public Produto Produto { get; set; }      
        [Required]
        [DataMember]
        public int Quantidade { get; set; }
        [Required]
        [DataMember]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecoUnitarioCompra { get; set; }
        [Required]
        [DataMember]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecoUnitarioVenda { get; set; }
        [DataMember]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubtotalCompra => Quantidade * PrecoUnitarioCompra;
        [DataMember]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubtotalVenda => Quantidade * PrecoUnitarioVenda;

        internal void AtualizaQuantidade(int quantidade)
        {
            Quantidade = quantidade;
        }

        internal void AtualizaPrecoUnitarioVenda()
        {
            PrecoUnitarioVenda = Produto.PrecoVenda;
        }
    }
}
