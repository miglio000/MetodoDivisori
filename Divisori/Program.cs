using System;
using LibreriaDivisori;
namespace Divisori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Esegui.Divisori(n);
            

        }
    }
}
