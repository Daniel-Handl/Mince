using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej cenu nákupu:");
            int cena = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadej kolik zákatník zaplatil:");
            int platba = Convert.ToInt32(Console.ReadLine());

            Change(cena, platba);
            Console.ReadLine();
        }

        private static void Change(int cena, int platba)
        {
            int vratit = platba - cena;
            int[] pole = new int[] { 50, 20, 10, 5, 2, 1 };
            int index = 0;
            int zbytek = vratit;
            while (zbytek > 0)
            {
                zbytek = vratit % pole[index];
                int vypis = (vratit - zbytek) / pole[index];
                if (vypis>=1)
                {
                    Console.WriteLine(vypis + " x " + pole[index] + "Kč");
                }
                vratit = zbytek;
                index++;
            }
        }
    }
}
