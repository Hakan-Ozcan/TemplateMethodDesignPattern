using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPattern
{
    class Latte : Kahve
    {
        protected override void KahveHazirla()
        {
            Console.WriteLine("Latte yapılıyor...");
        }

        protected override void GerekliMalzemeleriEkle()
        {
            Console.WriteLine("Latte için süt ekleniyor.");
        }
    }
}
