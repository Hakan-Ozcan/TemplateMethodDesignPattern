using TemplateMethodDesignPattern;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Kahve espresso = new Espresso();
        Console.WriteLine("Espresso hazırlanıyor...");
        espresso.SiparisHazirlama();

        Console.WriteLine();

        Kahve latte = new Latte();
        Console.WriteLine("Latte hazırlanıyor...");
        latte.SiparisHazirlama();

        Console.ReadLine();
    }
}