using ECommerceLite.Models.ViewModels;

namespace ECommerceLite.Models
{
    public class UpdatePedidoResponse
    {
        public UpdatePedidoResponse(Pedido pedido, InicioViewModel inicioViewModel)
        {
            Pedido = pedido;
            InicioViewModel = inicioViewModel;
        }

        public Pedido Pedido { get; }
        public InicioViewModel InicioViewModel { get; }
    }
}
