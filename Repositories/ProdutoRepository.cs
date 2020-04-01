using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceLiteAlexandre.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceLiteAlexandre.Repositories
{
    public interface IProdutoRepository
    {
        Task SaveProdutos(List<Livro> livros);
        Task<IList<Produto>> GetProdutos();
    }

    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public async Task<IList<Produto>> GetProdutos()
        {
            return await dbSet.ToListAsync();
        }

        public async Task SaveProdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {
                if (!dbSet.Where(p => p.Codigo == livro.Codigo).Any())
                {
                    dbSet.Add(new Produto(livro.Codigo, livro.Nome, livro.PrecoCompra, livro.Descricao));
                }
            }
            await contexto.SaveChangesAsync();
        }
    }

    public class Livro
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal PrecoCompra { get; set; }
        public string Descricao { get; set; }
    }
}
