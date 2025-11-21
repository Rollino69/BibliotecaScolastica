using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Libro
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int AnnoPubblicazione { get; set; }
        public string Editore { get; set; } 
        public int NumeroPagine { get; set; }

        public int redingTime(int paginePerOra)
        {
            if (paginePerOra <= 0)
            {
                throw new ArgumentException("Il numero di pagine per ora deve essere maggiore di zero.");
            }
            return NumeroPagine / paginePerOra;
        }



    }
}
