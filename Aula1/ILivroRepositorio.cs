using System;
using System.Collections.Generic;
using System.Text;

namespace Aula1
{
    interface ILivroRepositorio
    {
        ListaDeLeitura Paraler { get; }
        ListaDeLeitura Lendo { get; }
        ListaDeLeitura Lidos { get; }
        IEnumerable<Livro> Todos { get; }
        void Incluir(Livro livro);

    }
}
