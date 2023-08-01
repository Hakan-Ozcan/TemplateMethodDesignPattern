using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    class Espresso : Kahve
    {
        protected override void KahveHazirla()
        {
            Console.WriteLine("Espresso yapılıyor...");
        }

        protected override void GerekliMalzemeleriEkle()
        {
            Console.WriteLine("Espresso için süt eklenmiyor.");
        }
    }
}
