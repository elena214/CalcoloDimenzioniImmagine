using System;

namespace CalcoloDimenzioniImmagine
{
    class Program
    {
        static void Main(string[] args)
        {
            int calcolo;
            Console.WriteLine("Inserire l'altezza dell'immagine");
            int altezzaImmagine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire la larghezza dell'immagine");
            int larghezzaImmagine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire da quanti bit è composta l'immagine");
            string bit = Console.ReadLine();
            switch(bit)
            {
                case "24":
                    calcolo = ((altezzaImmagine * larghezzaImmagine) * 3) / 1024;
                    Console.WriteLine($"L'immagine occupa {calcolo} KB");
                    break;
                case "16":
                    calcolo = ((altezzaImmagine * larghezzaImmagine) * 2) / 1024;
                    Console.WriteLine($"L'immagine occupa {calcolo} KB");
                    break;
                case "8":
                    calcolo = ((altezzaImmagine * larghezzaImmagine) * 1) / 1024;
                    Console.WriteLine($"L'immagine occupa {calcolo} KB");
                    break;
            }
        }
    }
}
