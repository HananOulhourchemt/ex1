using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 0, i, nbr;

            Console.WriteLine(" Entrez un nombre: ");
            nbr=int.Parse(Console.ReadLine());

            for (i=1; i<=nbr; i++)
            {
                if (nbr%i==0)
                {
                    p++;
                }
            }
            if (p==2)
            {
                Console.WriteLine(" ce nombre est un nombre premier.");
            }
            else
            {
                Console.WriteLine(" ce nombre n'est pas un nombre premier.");
            }
            Console.ReadKey();
        }
    }
}
