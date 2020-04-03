using Microsoft.AspNetCore.Mvc;
using ECommerceLite.Models;
using ECommerceLite.Repositories;
using ECommerceLite.Models.ViewModels;
using System.Threading.Tasks;

namespace ECommerceLite.Controllers
{
    public class LojaController : Controller
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IPedidoRepository pedidoRepository;
        private readonly IItemPedidoRepository itemPedidoRepository;

        public LojaController(IProdutoRepository produtoRepository, IPedidoRepository pedidoRepository, IItemPedidoRepository itemPedidoRepository)
        {
            this.produtoRepository = produtoRepository;
            this.pedidoRepository = pedidoRepository;
            this.itemPedidoRepository = itemPedidoRepository;
        }
        
        public async Task<IActionResult> Inicio()
        {
            await pedidoRepository.UpdatePrecosVenda();
            return View(new InicioViewModel(await pedidoRepository.GetPedido(), await produtoRepository.GetProdutos()));
        }        

        public async Task<IActionResult> Carrinho(string codigo)
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                await pedidoRepository.AddItem(codigo);
            }            
            await pedidoRepository.UpdatePrecosVenda();
            return View(new CarrinhoViewModel(await pedidoRepository.GetPedido()));
        }

        public async Task<IActionResult> Admin()
        {
            return View(await pedidoRepository.GetPedido());
        }

        [ValidateAntiForgeryToken]
        public async Task ZerarCarrinho()
        {
            await pedidoRepository.ZerarCarrinho();            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<UpdateQuantidadeResponse> UpdateQuantidade([FromBody]ItemPedido itemPedido)
        {
            return await pedidoRepository.UpdateQuantidade(itemPedido);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<UpdatePedidoResponse> UpdateDespesasTotais([FromBody]Pedido pedido)
        {
            return await pedidoRepository.UpdateDespesasTotais(pedido);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<UpdatePedidoResponse> UpdateMargemLucro([FromBody]Pedido pedido)
        {
            return await pedidoRepository.UpdateMargemLucro(pedido);
        }
    }
}
