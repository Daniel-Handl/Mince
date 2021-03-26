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
            int[] pole = new int[] { 50, 20, 10, 5, 2, 1 };
            Change(cena, platba, pole);
            Change_recurrent (platba - cena, 0, pole);
            Console.ReadLine();
        }

        private static void Change_recurrent(int vratit,int index, int[] pole)
        {
            int zbytek = vratit % pole[index];
            int vypis = (vratit - zbytek) / pole[index];
            if (vypis >= 1)
            {
                Console.WriteLine(vypis + " x " + pole[index] + "Kč");
            }
            if (zbytek > 0)
            {
                Change_recurrent(zbytek, ++index, pole);
            }

        }

        private static void Change(int cena, int platba, int[] pole)
        {
            int vratit = platba - cena;
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
