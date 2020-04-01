using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

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
        public Pedido Pedido { get; private set; }
        [Required]
        [DataMember]
        public Produto Produto { get; private set; }      
        [Required]
        [DataMember]
        public int Quantidade { get; private set; }
        [Required]
        [DataMember]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecoUnitarioCompra { get; private set; }
        [Required]
        [DataMember]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecoUnitarioVenda { get; private set; }
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
