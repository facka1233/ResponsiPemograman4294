using System;

public class karyawan
{
    public static void Main(string[] args)
    {
       string nama, nik;
       int gajibulanan, gajinaik=0, gajiakhir=0;
       
            Console.Write("Masukan Nama         : ");
            nama = Console.ReadLine();
            Console.Write("Masukan NIk          : ");
            nik = Console.ReadLine();
            Console.Write("Masukan Gaji bulanan : Rp ");
            gajibulanan = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Nama         : "+nama);
            Console.WriteLine("NIK          : " + nik);
            Console.WriteLine("gaji bulanan : Rp " + gajibulanan);
            gajinaik=gajibulanan*10/100;
            gajiakhir=gajibulanan+gajinaik;
            Console.WriteLine("\nKenaikan gaji 10%");
            Console.WriteLine("Kenaikan gaji 10% = Rp "+gajiakhir);
            
    }
}