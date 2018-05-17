using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Book
    {
        //  id, titulo, ISBN e ano, além da sua lista de autores.

        public int BookId { get; set; }

        public string Isbn { get; set; }

        public string Titulo { get; set; }

        public int Ano { get; set; }


        public virtual ICollection<Autor> Autores { get; set; }


    }
}
