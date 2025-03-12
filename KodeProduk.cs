using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300035
{
    public class KodeProduk
    {
        private static string[] produkElektronik =
        {
            "Laptop", "Smartphone", "Tablet", "Headset", "Keyboard",
            "Mouse", "Printer", "Monitor", "Smartwatch", "Kamera"
        };

        private static string[] kode =
        {
            "E100", "E101", "E102", "E103", "E104", "E105", "E106",
            "E107", "E108", "E109"
        };

        public static string getKodeProduk(string namaProduk)
        {
            for (int i = 0; i < produkElektronik.Length; i++)
            {
                if (produkElektronik[i] == namaProduk)
                {
                    return kode[i];
                }
            }
            return "kode produk tidak ditemukan";
        }
    }
}
