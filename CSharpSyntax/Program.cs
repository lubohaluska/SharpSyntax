using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Program
    {
        public int globalPromenna = 7;

        void TestGlobalniPremenna()
        {
            globalPromenna++;

        }



        /// metody
        void bezNavratu()
        {

        }

        int sNavratem()
        {
            return 8;
        }


        int secti(int a, int b)
        {
            int vysledek = a + b;
            return vysledek;
        }

        int sectiRychleji(int a, int b)
        {
            return a + b;
        }

        int sectiRychleji(int a, int b, int c)
        {
            return a + b +c;
        }


        static void Main(string[] args)
        {

            const int mojeKonstanta = 4;
            int polomer = 6;

            // rovnake navysenie
            //polomer = polomer + 1;
            //polomer += 1;
            //polomer += 8; zvysuje o 8
            //polomer++;
            //++polomer;

            
            Console.WriteLine("Puvodni polomer {0}", polomer);
            int novyPolomer = polomer++;
            //tu ho najprv vypise a az potom zvysi 6 o 1 - postfix
            Console.WriteLine("Novy polomer {0}", novyPolomer);
            int zaseNovyPolomer = ++polomer;
            //tu ho najprv zvysi a potom ho az vypise 8 prefix
            Console.WriteLine("Zase Novy polomer {0}", zaseNovyPolomer);

            // definovanie variabilnej premennej
            var vari = 6;
            var varia = (long) 12;


            //pouzi kalkulacku
            Kalkulator.secti(b: 4, a: 5);
            Kalkulator.vynasob(4, 6, 8, 20, 15);


            //podmienky             if (bool) prikaz1 else prikaz2

            int vysledek = 5;

            if (vysledek == 4) vysledek++;
            else
                --vysledek;


            switch (vysledek)
            {
                case 2:
                    Console.WriteLine("vysledek  byl 2");
                    break;
                case 3:
                    Console.WriteLine("vysledek  byl 3");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("vysledek  byl 4 nebo 5");
                    break;
                default:
                    Console.WriteLine("vysledek  nebyl 2,3,4,5");
                    break;

            }


            // priority v zatvorkach
            if (((vysledek >= 10 && vysledek <= 20) || (vysledek > 40 && vysledek < 60 )) && vysledek != 16)
            {
                Console.WriteLine("Vysledek v pozadovanem rozsahu {vysledek}");
            }

            Console.ReadLine();
        }
    }
}
