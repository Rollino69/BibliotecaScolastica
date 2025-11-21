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

        public string readingTime;
        public string RedingTime()
        {
            if (NumeroPagine <= 0)
            {
                throw new ArgumentException("Il numero di pagine deve essere maggiore di zero.");
            }
            else if(NumeroPagine < 100 && NumeroPagine > 0)
            {

                return readingTime = "Il libro richiede 1h di lettura";
            }
            else if(NumeroPagine >= 100 && NumeroPagine <= 200)
            {
                return readingTime = "Il libro richiede 2 ore di lettura";
            }
            else
            {
                return readingTime = "Il libro richiede oltre 2 ore di lettura";
                

            }

        }



    }
}
