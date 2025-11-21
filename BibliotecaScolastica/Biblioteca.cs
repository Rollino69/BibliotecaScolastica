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

        public Biblioteca(string nome, string indirizzo, string orariDiApertura, string chiusuraGiornaliera)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrariDiApertura = orariDiApertura;
            ChiusuraGiornaliera = chiusuraGiornaliera;
            Libri = new List<Libro>();
        }
        public List<Libro> Libri;
        

        

    }
}
