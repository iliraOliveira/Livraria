using Livraria.Domain.Abstractions;
using Livraria.Domain.Entities;
using Livraria.Domain.Enums;
using Livraria.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Infrastructure.Respositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ApplicationDbContext _context;
        public LivroRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Livro> AdicionarLivro(Livro livro)
        {
            if (_context.Livros == null)
            {
                throw new InvalidOperationException("O DbSet de Livros não está inicializado.");
            }
            else
            {
                _context.Livros.Add(livro);
                await _context.SaveChangesAsync();
                return livro;
            }
        }

        public async Task AtualizarLivro(Livro livro)
        {
            if (livro is null)
            {
                throw new ArgumentNullException("Dados inválidos!!!");
            }
            else
            {
                _context.Entry(livro).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> LivroExiste(int livroId)
        {
            var livro = await _context.Livros!.FirstOrDefaultAsync(l => l.LivroId == livroId);

            return livro != null;
        }

        public async Task<bool> LivroExiste(string titulo, string autor)
        {
            var livro = await _context.Livros!
                .FirstOrDefaultAsync(l => l.Titulo == titulo && l.Autor == autor);

            return livro != null;
        }

        public async Task<Livro?> ObterLivroPorId(int livroId)
        {
            var livro = await _context.Livros!.FindAsync(livroId);

            return livro ?? throw new KeyNotFoundException($"Livro com ID {livroId} não encontrado.");
        }

        public async Task<IEnumerable<Livro>> ObterLivros()
        {
            if (_context.Livros == null)
            {
                return new List<Livro>();
            }
            else
            {
                var livros = await _context.Livros.ToListAsync();
                return livros;
            }
        }

        public Task<IEnumerable<Livro>> ObterLivrosPorCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Livro>> ObterLivrosPorEditora(Editora editora)
        {
            throw new NotImplementedException();
        }

        public async Task RemoverLivro(int livroId)
        {
            var livro = _context.Livros!.Find(livroId);

            if (livro is null)
            {
                throw new KeyNotFoundException($"Livro com ID {livroId} não encontrado.");
            }
            else
            {
                _context.Livros.Remove(livro);
                await _context.SaveChangesAsync();
            }
        }
    }
}
