using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KőPapírOllóOOP
{
    using System;

    namespace KőPapírOllóOOP
    {
        public class Kpo
        {
            private string asd;
            private string asd2;
            private string eredmeny;

            public Kpo() { }

            public Kpo(string asd, string asd2)
            {
                this.asd = asd;
                this.asd2 = asd2;
            }

            public void SetTip1(string tip) => asd = tip;
            public void SetTip2(string tip) => asd2 = tip;

            public void SetEredmény()
            {
                if (asd == asd2) eredmeny = "Döntetlen lett!";
                else if ((asd == "Kő" && asd2 == "Olló") || (asd == "Papír" && asd2 == "Kő") || (asd == "Olló" && asd2 == "Papír"))
                    eredmeny = "Első játékos a nyertes!";
                else
                    eredmeny = "Második játékos a nyertes!";
            }

            public string GetEredmény() => eredmeny;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Kpo kpo = new Kpo("Papír", "Kő");
                kpo.SetEredmény();
                Console.WriteLine("Játéknak az eredménye: " + kpo.GetEredmény());
                Console.ReadKey();
            }
        }
    }
}

