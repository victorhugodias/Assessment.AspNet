using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Autor
    {

        // id, nome, sobrenome, email e data de nascimento

        public int AutorId { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public DateTime DtNascimento { get; set; }

        public virtual ICollection<Book> Livros { get; set; }


    }
}
