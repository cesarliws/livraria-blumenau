using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivrariaBlumenau.Models
{
    public class Livro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int? Paginas { get; set; }
        public string Edicao { get; set; }
        public string Idioma { get; set; }
        public string Editora { get; set; }
        public DateTime DataPublicacao { get; set; }

        public string ISBN10 { get; set; }
        public string ISBN13 { get; set; }

        public string Descricao { get; set; }

        // TODO : implementar tabela para estoque
        public long? Estoque { get; set; }

        public bool? Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime EditedAt { get; set; }
    }
}