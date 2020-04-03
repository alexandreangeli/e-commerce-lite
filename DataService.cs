using ECommerceLite.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace ECommerceLite
{
    class DataService : IDataService
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly ApplicationContext contexto;

        public DataService(IProdutoRepository produtoRepository, ApplicationContext contexto)
        {
            this.produtoRepository = produtoRepository;
            this.contexto = contexto;
        }

        public void InicializaDB()
        {
            contexto.Database.Migrate();

            List<Livro> livros = GetLivros();

            produtoRepository.SaveProdutos(livros);
        }

        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }
}
