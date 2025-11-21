using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuti nella Biblioteca Scolastica!");
           
            Console.ReadLine();

            Biblioteca miaBiblioteca = new Biblioteca("Biblioteca Centrale", "Via Roma 1", "9:00 - 18:00", "18:00");
            Libro libro1 = new Libro("Il Postino Pat", "Gian Piero", "1234567890");
            miaBiblioteca.Libri.Add(libro1);
            Console.WriteLine($"Biblioteca: {miaBiblioteca.Nome}, Indirizzo: {miaBiblioteca.Indirizzo}");
            Console.WriteLine($"Libro Aggiunto: {libro1.Titolo} di {libro1.Autore}, ISBN: {libro1.ISBN}");
            Libro libro2 = new Libro("1984", "George Orwell", "0987654321");
            miaBiblioteca.Libri.Add(libro2);
            Console.WriteLine($"Libro Aggiunto: {libro2.Titolo} di {libro2.Autore}, ISBN: {libro2.ISBN}");
            Console.ReadLine();
            Libro libro3 = new Libro(
                    
            Libro libro3 = new Libro(
                "To Kill a Mockingbird",
                "Harper Lee",
                "1122334455"
            );



        }
    }
}
/*using System;
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
*/
