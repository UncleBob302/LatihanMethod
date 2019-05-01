using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)

        {
            // deklarasi variabel
            int hasil;

            // membuat objek dari class Calculator
            Calculator calculator = new Calculator();

            // panggil method Penjumlah
            hasil = calculator.Penjumlah(10, 2);
            CetakHasil("Hasil Penjumlah: " + hasil);

            // panggil method Penjumlah dg 3 parameter (overload method)
            hasil = calculator.Penjumlah(10, 2, 3);
            CetakHasil(" hasil Penjumlah overload: " + hasil);

            // panggil method pengurangan
            hasil = calculator.Pengurangan(7, 2);
            CetakHasil(" hasil Pengurangan: " + hasil);

            // panggil method Perkalian
            hasil = Calculator.Perkalian(5, 2);
            CetakHasil(" hasil Perkalian: " + hasil);

            Console.ReadKey();
        }

        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}