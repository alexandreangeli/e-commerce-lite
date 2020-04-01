using ECommerceLiteAlexandre.Models;
using ECommerceLiteAlexandre.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceLiteAlexandre.Repositories
{
    public interface IPedidoRepository
    {
        Task<Pedido> GetPedido();
        Task AddItem(string codigo);
        Task<UpdateQuantidadeResponse> UpdateQuantidade(ItemPedido itemPedido);
        Task<UpdatePedidoResponse> UpdateDespesasTotais(Pedido pedido);
        Task<UpdatePedidoResponse> UpdateMargemLucro(Pedido pedido);
        Task<decimal> GetRateio(decimal despesasTotais);
        Task UpdatePrecosVenda();
        Task ZerarCarrinho();
    }

    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAccessor;
        private readonly IItemPedidoRepository itemPedidoRepository;
        private readonly IProdutoRepository produtoRepository;


        public PedidoRepository(ApplicationContext contexto,
            IHttpContextAccessor contextAccessor,
            IItemPedidoRepository itemPedidoRepository,
            IProdutoRepository produtoRepository) : base(contexto)
        {
            this.contextAccessor = contextAccessor;
            this.itemPedidoRepository = itemPedidoRepository;
            this.produtoRepository = produtoRepository;
        }


        public async Task AddItem(string codigo)
        {
            var produto = contexto.Set<Produto>().
                Where(p => p.Codigo == codigo).
                SingleOrDefault();
            if (produto == null)
            {
                throw new ArgumentException("Produto não encontrado");
            }
            var pedido = await GetPedido();
            var itemPedido = contexto.Set<ItemPedido>()
                .Where(i => i.Produto.Codigo == codigo
                && i.Pedido.Id == pedido.Id)
                .SingleOrDefault();

            if (itemPedido == null)
            {
                itemPedido = new ItemPedido(pedido, produto, 1, produto.PrecoCompra, produto.PrecoVenda);
                contexto.Set<ItemPedido>()
                    .Add(itemPedido);
                await contexto.SaveChangesAsync();
            }
        }

        private int? GetPedidoId()
        {
            return contextAccessor.HttpContext.Session.GetInt32("pedidoId");
        }

        private void SetPedidoId(int pedidoId)
        {
            contextAccessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }

        public async Task<Pedido> GetPedido()
        {
            var pedidoId = GetPedidoId();
            var pedido = dbSet
                .Include(p => p.Itens)
                .ThenInclude(i => i.Produto)
                .Where(p => p.Id == pedidoId)
                .SingleOrDefault();
            if (pedido == null)
            {
                pedido = new Pedido();
                dbSet.Add(pedido);
                await contexto.SaveChangesAsync();
                SetPedidoId(pedido.Id);
            }
            return pedido;
        }

        public async Task<UpdateQuantidadeResponse> UpdateQuantidade(ItemPedido itemPedido)
        {
            var itemPedidoDB = itemPedidoRepository.GetItemPedido(itemPedido.Id);

            if (itemPedidoDB != null)
            {
                itemPedidoDB.AtualizaQuantidade(itemPedido.Quantidade);

                if (itemPedido.Quantidade == 0)
                {
                    itemPedidoRepository.RemoveItemPedido(itemPedido.Id);
                }

                await contexto.SaveChangesAsync();

                var carrinhoViewModel = new CarrinhoViewModel(await GetPedido());

                return new UpdateQuantidadeResponse(itemPedidoDB, carrinhoViewModel);
            }

            throw new ArgumentException("ItemPedido não encontrado");
        }

        public async Task<UpdatePedidoResponse> UpdateDespesasTotais(Pedido pedido)
        {
            var pedidoDB = await GetPedido();
            if (pedidoDB != null)
            {
                pedidoDB.AtualizaDespesasTotais(pedido.DespesasTotais);
            }
            await contexto.SaveChangesAsync();
            var inicioViewModel = new InicioViewModel(pedidoDB, await produtoRepository.GetProdutos());
            return new UpdatePedidoResponse(pedidoDB, inicioViewModel);
        }

        public async Task<UpdatePedidoResponse> UpdateMargemLucro(Pedido pedido)
        {
            var pedidoDB = await GetPedido();
            if (pedidoDB != null)
            {
                pedidoDB.AtualizaMargemLucro(pedido.MargemLucro);
            }
            await contexto.SaveChangesAsync();
            var inicioViewModel = new InicioViewModel(pedidoDB, await produtoRepository.GetProdutos());
            return new UpdatePedidoResponse(pedidoDB, inicioViewModel);
        }

        public async Task UpdatePrecosVenda()
        {
            var pedido = await GetPedido();
            var rateio = await GetRateio(pedido.DespesasTotais);
            var produtos = await produtoRepository.GetProdutos();

            foreach (var produto in produtos)
            {
                var produtoDB = contexto.Set<Produto>().Where(p => p.Id == produto.Id).FirstOrDefault();
                produtoDB.AtualizaPrecoVenda(pedido, rateio);
            }

            foreach (var item in pedido.Itens)
            {
                var itemPedidoDB = contexto.Set<ItemPedido>().Where(ip => ip.Id == item.Id).FirstOrDefault();
                itemPedidoDB.AtualizaPrecoUnitarioVenda();
            }

            await contexto.SaveChangesAsync();
        }

        public async Task<decimal> GetRateio(decimal despesasTotais)
        {
            var produtos = await produtoRepository.GetProdutos();
            return despesasTotais / produtos.Count();
        }

        public async Task ZerarCarrinho()
        {
            var pedido = await GetPedido();
            foreach (var item in pedido.Itens)
            {
                itemPedidoRepository.RemoveItemPedido(item.Id);
            }
            await contexto.SaveChangesAsync();
        }
    }
}
