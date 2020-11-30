using System;

namespace LibreriaDivisori
{
    public class Esegui
    {
        public static void Divisori(int n)
        {
            int divisori;
            for (int i = 1;i<=n; i++)
            {
                divisori = n / i;
                if (n % i == 0)
                {
                    Console.WriteLine(divisori);
                   
                }
            }
            
            
        }
    }
}
