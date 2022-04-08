using System;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasi variable
            int hasil;
            // membuat objek dari class Calculator
            Calculator calculator = new Calculator();

            // memanggil method penjumlahan
            hasil = calculator.Penjumlahan(10, 2);
            CetakHasil("Hasil Penjumlahan: " + hasil);
            //penjumlahan 3 parameter
            hasil = calculator.Penjumlahan(10, 5, 3);
            CetakHasil("Hasil Penjumlahan Overload: " + hasil);
            //pengurangan
            hasil = calculator.Pengurangan(7,2);
            CetakHasil("Hasil Pengurangan: " + hasil);
            //static method langsung dari nama class nya
            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian: " + hasil);

            Console.ReadKey();
        }

        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}


