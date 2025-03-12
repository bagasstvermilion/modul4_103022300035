using modul4_103022300035;
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Daftar kode produk: ");
        Console.WriteLine("------------------------------------");

        string[] daftarProduk =
        {
            "Laptop", "Smartphone", "Tablet", "Headset", "Keyboard",
            "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera"
        };

        foreach (string produk in daftarProduk)
        {
            Console.WriteLine($"{produk}: {KodeProduk.getKodeProduk(produk)}");
        }
    }
}