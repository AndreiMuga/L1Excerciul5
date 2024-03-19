using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lab1Ex5 
{ 
    public class Program
    /* Ex 5
Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele
doua valori in ordine crescatoare.
• Exemplu: citim 9,0 Afisam : 0 9 
     */
    {
        public static void Main(string[] args)
        { 
            int primulNumar;
            int alDoileaNumar;
            Console.WriteLine("Introduceti primul numar:");
            primulNumar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar:");
            alDoileaNumar = Convert.ToInt32(Console.ReadLine());
            if (primulNumar < alDoileaNumar)
            { 
                Console.WriteLine(primulNumar + ", " + alDoileaNumar);
            } 
            else 
            { 
                Console.WriteLine(alDoileaNumar + ", " + primulNumar);
            }
        }
    }
}