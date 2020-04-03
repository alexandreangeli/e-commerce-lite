using System.Linq;

namespace ECommerceLite.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public CarrinhoViewModel(Pedido pedido)
        {
            Pedido = pedido;
        }

        public Pedido Pedido { get; }

        public decimal TotalCompra => Pedido.Itens.Sum(i => i.Quantidade * i.PrecoUnitarioCompra);
        public decimal TotalVenda => Pedido.Itens.Sum(i => i.Quantidade * i.PrecoUnitarioVenda);

    }
}
