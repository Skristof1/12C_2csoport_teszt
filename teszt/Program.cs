using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhenger
{
    class kor
    {
        private double sugar, kerulet, terulet;

        public kor() { }

        public kor(double r)
        {
            this.sugar = r;
            this.kerulet = kalkerulet(r);
            this.terulet = kalterulet(r);
        }

        private double kalkerulet(double r)
        {
            return 2 * r * Math.PI
        }

        private double kalterulet(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public double GetSugar() { return this.sugar; }
        public double GetKerulet() { return this.kerulet; }
        public double GetTerulet() { return this.terulet; }

        public void SetSugar(double r)

        private void setDatas(double r)
        {
            this.sugar = r;
            this.kerulet = kalkerulet(r);
            this.terulet = kalterulet(r);
        }




        static void Main(string[] args)
        {






            Console.ReadKey();
        }
    }
}
