using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ECommerceLiteAlexandre.Models
{
    public class Pedido : BaseModel
    {
        public Pedido()
        {
        }

        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
                
        [DataMember]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DespesasTotais { get; set; } = 400;
        [DataMember]
        [Column(TypeName = "decimal(18,2)")]
        public decimal MargemLucro { get; set; }        

        internal void AtualizaMargemLucro(decimal margemLucro)
        {
            MargemLucro = margemLucro;
        }

        internal void AtualizaDespesasTotais(decimal despesasTotais)
        {
            DespesasTotais = despesasTotais;
        }
    }
}
