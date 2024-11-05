using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzorzotablaOOP
{
    namespace SzorzotablaOOP
    {
        public class Szorzotabla
        {
            private int szam;
            private int[] vegeredmeny;

            public Szorzotabla() { }

            public Szorzotabla(int szam) => SetSzam(szam);

            public void SetSzam(int szam)
            {
                if (szam >= 1 && szam <= 9)
                {
                    this.szam = szam;
                    SetEredmény();
                }
            }

            public void SetEredmény()
            {
                vegeredmeny = new int[10];
                for (int i = 1; i <= 10; i++)
                {
                    vegeredmeny[i - 1] = szam * i;
                }
            }

            public int[] GetEredmény() => vegeredmeny;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Szorzotabla szorzotabla = new Szorzotabla(8);
                int[] eredmeny = szorzotabla.GetEredmény();
                Console.WriteLine("Szorzótábla:");
                foreach (var elem in eredmeny) Console.WriteLine(elem);
                Console.ReadKey();
            }
        }
    }
}
