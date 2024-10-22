using System;

class Bebek
{
    // properties
    public DateTime DogumTarihi { get; private set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }

    // default constructor
    public Bebek()
    {
        DogumTarihi = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }

    // ad ve soyad parametreli constructor
    public Bebek(string ad, string soyad)
    {
        Ad = ad;
        Soyad = soyad;
        DogumTarihi = DateTime.Now;
        Console.WriteLine("Ingaaaa");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // default constructor ile bebek nesnesi 
        Bebek bebek1 = new Bebek();
        bebek1.Ad = "Gizem";
        bebek1.Soyad = "Akarsu";
        Console.WriteLine($"Bebek 1: {bebek1.Ad} {bebek1.Soyad}, Doğum Tarihi: {bebek1.DogumTarihi}");

        // parametreli constructor ile bebek nesnesi 
        Bebek bebek2 = new Bebek("Cansın", "Filiz");
        Console.WriteLine($"Bebek 2: {bebek2.Ad} {bebek2.Soyad}, Doğum Tarihi: {bebek2.DogumTarihi}");
    }
}
