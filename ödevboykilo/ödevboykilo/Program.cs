using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vücut Kitle İndeksi Hesaplama");

        // Kullanıcıdan boyu al
        Console.Write("Boyunuzu (metre cinsinden) girin: ");
        double boy = Convert.ToDouble(Console.ReadLine());

        // Kullanıcıdan kiloyu al
        Console.Write("Kilonuzu girin: ");
        double kilo = Convert.ToDouble(Console.ReadLine());

        // Vücut kitle indeksini hesapla
        double vucutKitleIndeksi = kilo / (boy * boy);

        // Sonucu ekrana yazdır
        Console.WriteLine("Vücut Kitle İndeksi: " + vucutKitleIndeksi);

        // Vücut kitle indeksi yorumunu yap
        if (vucutKitleIndeksi < 18.5)
        {
            Console.WriteLine("Zayıf");
        }
        else if (vucutKitleIndeksi >= 18.5 && vucutKitleIndeksi < 24.9)
        {
            Console.WriteLine("Normal");
        }
        else if (vucutKitleIndeksi >= 25 && vucutKitleIndeksi < 29.9)
        {
            Console.WriteLine("Fazla Kilolu");
        }
        else
        {
            Console.WriteLine("Obez");
        }
    }
}
