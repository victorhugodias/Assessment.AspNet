using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class AutorViewModel
    {
        public int AutorId { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public DateTime DtNascimento { get; set; }

        public virtual ICollection<Book> Livros { get; set; }
    }
}