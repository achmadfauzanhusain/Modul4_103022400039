using Modul4_103022400039;
using System;

class Program
{
    static void Main(string[] args)
    {
        KodePaket kp = new KodePaket();

        Console.Write("Masukkan nama paket: ");
        string nama = Console.ReadLine();

        string kode = kp.getKodePaket(nama);

        Console.WriteLine("Kode Paket: " + kode);
    }
}