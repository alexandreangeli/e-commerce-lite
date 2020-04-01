using System.Collections.Generic;
using System.Linq;

namespace ECommerceLiteAlexandre.Models.ViewModels
{
    public class InicioViewModel
    {
        public InicioViewModel(Pedido pedido, IList<Produto> produtos)
        {
            Pedido = pedido;
            Produtos = produtos;
        }

        public Pedido Pedido { get; }
        public IList<Produto> Produtos { get; }
        public decimal Rateio => Pedido.DespesasTotais / Produtos.Count();

        public InicioViewModel()
        {
        }
    }
}
