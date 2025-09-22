using Livraria.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Domain.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }

        [Required(ErrorMessage = "O título é obrigatório.")]
        [MaxLength(150, ErrorMessage = "O título não pode exceder 150 caracteres.")]
        public string? Titulo { get; set; }

        [Required(ErrorMessage = "O autor é obrigatório.")]
        [MaxLength(200, ErrorMessage = "O nome do autor não pode exceder 200 caracteres.")]
        public string? Autor { get; set; }

        [Required(ErrorMessage = "A data de publicação é obrigatória.")]
        public DateTime DataPublicacao { get; set; }

        [Required(ErrorMessage = "Informe a imagem da capa")]
        [MaxLength(200, ErrorMessage = "A capa não pode exceder 200 caracteres.")]
        public string? Capa { get; set; }

        [Required(ErrorMessage = "A editora é obrigatória.")]
        [EnumDataType(typeof(Editora), ErrorMessage = "Selecione a Editora")]
        public Editora Editora { get; set; }

        [Required(ErrorMessage = "A categoria é obrigatória.")]
        [EnumDataType(typeof(Categoria), ErrorMessage = "Selecione a Categoria")]
        public Categoria Categoria { get; set; }

        public Livro(int livroId, string? titulo, string? autor, DateTime dataPublicacao, string? capa, Editora editora, Categoria categoria)
        {
            LivroId = livroId;
            Titulo = titulo;
            Autor = autor;
            DataPublicacao = dataPublicacao;
            Capa = capa;
            Editora = editora;
            Categoria = categoria;
        }
    }
}
