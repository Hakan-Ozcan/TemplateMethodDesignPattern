using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    abstract class Kahve
    {
        public void SiparisHazirlama()
        {
            KaynatSu();
            KahveHazirla();
            FincanaDok();
            GerekliMalzemeleriEkle();
        }

        protected void KaynatSu()
        {
            Console.WriteLine("Su kaynatılıyor...");
        }

        protected void FincanaDok()
        {
            Console.WriteLine("Fincana kahve dökülüyor...");
        }

        protected abstract void KahveHazirla();
        protected abstract void GerekliMalzemeleriEkle();
    }
}
