using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.Models
{
    public class BookViewModel
    {
        public int BookId { get; set; }

        public string Isbn { get; set; }

        public string Titulo { get; set; }

        public int Ano { get; set; }


        public virtual ICollection<Autor> Autores { get; set; }

    }
}