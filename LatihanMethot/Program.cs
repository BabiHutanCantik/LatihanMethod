using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class program
    {
        static void Main(string[] args)
        {
            // dekalrasi variabel
            int hasil;

            // membuat objek dari class Calculator
            Calculator calculator = new Calculator();

            //panggil method penjumalh
            hasil = calculator.penjumlah(10, 2);
            CetakHasil("Hasil penjumlah: " + hasil);

            hasil = calculator.penjumlah(10, 2, 3);
            CetakHasil("Hasil penjumlah overload: " + hasil);

            hasil = calculator.pengurangan(7, 2);
            CetakHasil("Hasil pengurangan: " + hasil);

            hasil = Calculator.perkalian(5, 2);
            CetakHasil("Hasil perkalian: " + hasil);

            Console.ReadKey();

        }

        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }

    }
}
