using Livraria.Domain.Entities;
using Livraria.Domain.Enums;

namespace Livraria.Domain.Abstractions
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> ObterLivros();
        Task<Livro?> ObterLivroPorId(int livroId);
        Task<Livro> AdicionarLivro(Livro livro);
        Task RemoverLivro(int livroId);
        Task AtualizarLivro(Livro livro);
        Task<IEnumerable<Livro>> ObterLivrosPorCategoria(Categoria categoria);
        Task<IEnumerable<Livro>> ObterLivrosPorEditora(Editora editora);
        Task<bool> LivroExiste(int livroId);
        Task<bool> LivroExiste(string titulo, string autor);
    }
}
