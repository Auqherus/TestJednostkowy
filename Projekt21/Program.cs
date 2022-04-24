using System;

namespace Xyz
{
    public class TestujePesel
    {

        static void Main(string[] args)
        {
            PESELWalidator t1 = new PESELWalidator("2331");
            t1.Plec("kobieta");
        }
    }
    public class PESELWalidator
    {
        protected int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
        protected int[] pesel;

        public PESELWalidator(String pesel)
        {
            WczytajPesel(pesel);

        }

        public void WczytajPesel(String pesel)
        {
            Console.WriteLine(pesel);
        }

        public int SumaKontrolna()
        {
            
            return 0;
        }

        public String DataUrodzenia(String pesel)
        {
            return null;
        }

        public String Plec(String plec)
        {
            return plec;
        }

        public Boolean SprawdzPesel()
        {
            return false;
        }

    }
}

