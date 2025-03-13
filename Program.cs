using System;
using System.Collections.Generic;

public class KodeProduk
{
    public string Kode { get; set; }
    public string Produk { get; set; }
}

class main
{
    public static void Main()
    {
        List<KodeProduk> isiKodeProduk = new List<KodeProduk>()
        {
            new KodeProduk { Produk = "Laptop", Kode = "E100" },
            new KodeProduk { Produk = "SmartPhone", Kode = "E101" },
            new KodeProduk { Produk = "Tablet", Kode = "E102" },
            new KodeProduk { Produk = "Headset", Kode = "E103" },
            new KodeProduk { Produk = "Keyboard", Kode = "E104" },
            new KodeProduk { Produk = "Mouse", Kode = "E105" },
            new KodeProduk { Produk = "Printer", Kode = "E106" },
            new KodeProduk { Produk = "Monitor", Kode = "E107" },
            new KodeProduk { Produk = "Smartwatch", Kode = "E108" },
            new KodeProduk { Produk = "Kamera", Kode = "E109" }
        };
    }
}