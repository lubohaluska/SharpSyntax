using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Kalkulator
    {
           public static int secti(int a, int b)
        {
            int vysledek = a + b;
            return vysledek;
        }

        public static int secti(int a, int b, int c)
        {
            int vysledek = a + b + c;
            return vysledek;
        }

        public static int secti(string a, string b, string c)
        {
            // Parse je konvertovanie textu na cislo
            int vysledek = int.Parse(a) + int.Parse(b) + int.Parse(c);
            return vysledek;
        }

        internal static int vynasob(int v1, int v2, int v3, int v4, int v5)
        {
            return v1 * v2 * v3 * v4 * v5;
        }
    }
}
