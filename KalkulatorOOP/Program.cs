using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulátorOOP
{
    public class Calc
    {
        private double elso;
        private double masodik;
        private char muvelet;
        private double eredmeny;

        public Calc() { }

        public Calc(double elso, double masodik, char muvelet)
        {
            this.elso = elso;
            this.masodik = masodik;
            this.muvelet = muvelet;
        }

        public void SetSzám1(double szam) => elso = szam;
        public void SetSzám2(double szam) => masodik = szam;
        public void SetMűveletJel(char jel) => muvelet = jel;

        public void SetEredmény()
        {
            switch (muvelet)
            {
                case '+': eredmeny = elso + masodik; break;
                case '-': eredmeny = elso - masodik; break;
                case '*': eredmeny = elso * masodik; break;
                case '/': eredmeny = masodik != 0 ? elso / masodik : 0; break;
                default: throw new InvalidOperationException("Ismeretlen művelet");
            }
        }

        public double GetEredmény() => eredmeny;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc(16, 2, '/');
            calc.SetEredmény();
            Console.WriteLine("Az eredmény: " + calc.GetEredmény());
            Console.ReadKey();
        }

    }
}

