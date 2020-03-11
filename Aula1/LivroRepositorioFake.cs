using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    class LivroRepositorioFake : ILivroRepositorio
    {
        private ListaDeLeitura _paraLer;
        private ListaDeLeitura _lendo;
        private ListaDeLeitura _lidos;

        public LivroRepositorioFake()
        {
            var l1 = new Livro { Titulo = "O Iluminado", Autor = "Stephen King" };
            var l2 = new Livro { Titulo = "It, a Coisa", Autor = "Stephen King" };
            var l3 = new Livro { Titulo = "Carrie, a Estranha", Autor = "Stephen King" };
            var l4 = new Livro { Titulo = "Sob a Redoma", Autor = "Stephen King" };
            var l5 = new Livro { Titulo = "Cemiterio Maldito", Autor = "Stephen King" };
            var l6 = new Livro { Titulo = "O Iluminado", Autor = "Stephen King" };
            var l7 = new Livro { Titulo = "O Iluminado", Autor = "Stephen King" };
            var l8 = new Livro { Titulo = "O Iluminado", Autor = "Stephen King" };
            var l9 = new Livro { Titulo = "O Iluminado", Autor = "Stephen King" };
            var l10 = new Livro { Titulo = "O Iluminado", Autor = "Stephen King" };
            var l11 = new Livro { Titulo = "O Iluminado", Autor = "Stephen King" };
            var l12 = new Livro { Titulo = "O Iluminado", Autor = "Stephen King" };

            _paraLer = new ListaDeLeitura("Para Ler", l1, l4, l5, l12 );
            _lendo = new ListaDeLeitura("Lendo", l3, l11);
            _lidos = new ListaDeLeitura("Lidos", l2, l6, l7, l9, l8, l10);
        }

        public ListaDeLeitura ParaLer => _paraLer;
        public ListaDeLeitura Lendo => _lendo;
        public ListaDeLeitura Lidos => _lidos;
        public IEnumerable<Livro> Todos => throw new System.NotImplementedException();

        public void Incluir(Livro livro)
        {
            throw new System.NotImplementedException();
        }
    }
}
