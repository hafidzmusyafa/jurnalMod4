using System;
using System.Collections.Generic;

public class KodeProduk
{
    public string Kode { get; set; }
    public string Produk { get; set; }
}

public class FanLaptop
{
    public enum State { Quiet, Balanced, Performance, Turbo }
    private State stateAwal = State.Quiet;

    public void ModeDown()
    {
        if (stateAwal == State.Balanced)
        {
            stateAwal = State.Quiet;
            Console.WriteLine("Fan Balanced berubah menjadi Quiet");
        }
        else if (stateAwal == State.Performance)
        {
            stateAwal = State.Balanced;
            Console.WriteLine("Fan Performance berubah menjadi Balanced");
        }
        else if (stateAwal == State.Turbo)
        {
            stateAwal = State.Performance;
            Console.WriteLine("Fan Turbo berubah menjadi Performance");
        }
    }

    public void ModeUp()
    {
        if (stateAwal == State.Quiet)
        {
            stateAwal = State.Balanced;
            Console.WriteLine("Fan Quiet berubah menjadi Balanced");
        }
        else if (stateAwal == State.Balanced)
        {
            stateAwal = State.Performance;
            Console.WriteLine("Fan Balanced berubah menjadi Performance");
        }
        else if (stateAwal == State.Performance)
        {
            stateAwal = State.Turbo;
            Console.WriteLine("Fan Performance berubah menjadi Turbo");
        }
    }


    public void TurboShorcut()
    {
        if (stateAwal == State.Quiet)
        {
            stateAwal = State.Turbo;
            Console.WriteLine("Fan Quiet berubah menjadi Turbo");
        }
        else if (stateAwal == State.Turbo)
        {
            stateAwal = State.Quiet;
            Console.WriteLine("Fan Turbo berubah menjadi Quiet");
        }
    }
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
        foreach (var isi in isiKodeProduk)
        {
            Console.WriteLine($"Produk\t: {isi.Produk}\t Kode: {isi.Kode}");
        }
        Console.WriteLine();

        FanLaptop fan = new FanLaptop();
        fan.TurboShorcut();
        fan.TurboShorcut();
        fan.ModeUp();
        fan.ModeUp();
        fan.ModeUp();
        fan.ModeDown();
        fan.ModeDown();
        fan.ModeDown();
    }
}