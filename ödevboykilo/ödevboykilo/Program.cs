using System;

namespace IdealKiloHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan boy, kilo ve cinsiyet bilgilerini alın
            Console.Write("Lütfen boyunuzu (cm cinsinden) girin: ");
            double boyCm = double.Parse(Console.ReadLine());

            Console.Write("Lütfen kilonuzu (kg cinsinden) girin: ");
            double kilo = double.Parse(Console.ReadLine());

            Console.Write("Lütfen cinsiyetinizi girin (Kadın için 'K', Erkek için 'E'): ");
            char cinsiyet = char.ToUpper(Console.ReadKey().KeyChar);

            // İnç cinsinden boyu hesaplayın (1 inç = 2.54 cm)
            double boyInch = boyCm / 2.54;

            // Cinsiyete göre ideal kiloyu hesaplayın
            double idealKilo ;

            if (cinsiyet == 'K')
            {
                idealKilo = 45.5 + 2.3 * (boyInch - 60);
            }
            else if (cinsiyet == 'E')
            {
                idealKilo = 50 + 2.3 * (boyInch - 60);
            }
            else
            {
                Console.WriteLine("\nGeçersiz cinsiyet girişi. Lütfen 'K' veya 'E' girin.");
                return;
            }

            // Ideal kiloyu ve kullanıcının kilosunu karşılaştırın
            Console.WriteLine($"\nIdeal kilonuz: {idealKilo:F2} kg");

            if (kilo == idealKilo)
            {
                Console.WriteLine("Kilonuz ideal.");
            }
            else if (kilo < idealKilo)
            {
                Console.WriteLine("Kilonuz ideal kilonun altında.");
            }
            else
            {
                Console.WriteLine("Kilonuz ideal kilonun üstünde.");
            }

            Console.ReadLine();
        }
    }
}
