using System;

namespace AtvaltOOP
{
    public class Atvalt
    {
        private string szam;
        private string eredmeny;


        public Atvalt()
        {
            szam = string.Empty;
            eredmeny = string.Empty;
        }


        public void SetSzam(string szam)
        {
            this.szam = szam;
        }


        public void Atvaltas()
        {
            if (string.IsNullOrEmpty(szam))
                throw new InvalidOperationException("Nincs megadott szám.");

            try
            {

                if (IsBinary(szam))
                {
                    eredmeny = Convert.ToInt32(szam, 2).ToString();
                }
                else
                {

                    int dec = int.Parse(szam);
                    eredmeny = Convert.ToString(dec, 2);
                }
            }
            catch (FormatException)
            {
                throw new ArgumentException("Hibás adatmegadás.");
            }
        }


        public string GetEredmeny()
        {
            if (string.IsNullOrEmpty(eredmeny))
                throw new InvalidOperationException("Nincs átváltott eredmény.");
            return eredmeny;
        }


        private bool IsBinary(string input)
        {
            foreach (var c in input)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }
    }
}