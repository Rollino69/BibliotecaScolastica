using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Biblioteca
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string OrariDiApertura { get; set; }
        public string ChiusuraGiornaliera { get; set; }

        public List<Libro> Libri { get; set; }
    }
}
