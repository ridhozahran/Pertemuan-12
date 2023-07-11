using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praklab12
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            //membuat array sekaligus menginisialisasi nilai
            string[] arrNama = { "erick", "wely", "sony"};

            //menampilkan elemen array indexx ke 2
            Console.WriteLine(arrNama[2].ToString() + "\n");

            //menampilkan semua elemen array
            for (int i = 0; i < arrNama.Length; i++) 
            {
                Console.WriteLine(arrNama[i]);
            }
            Console.WriteLine(); // cetak baris kosong

            //menampilkan semua elemen array menggunakan foreach
            foreach(string nama in arrNama)
            {
                Console.WriteLine(nama);
            }
            Console.WriteLine();

            //membuat array
            int[] arrBil = new int[3];

            //inisialisasi nilai array
            arrBil[0] = 75;
            arrBil[1] = 80;
            arrBil[2] = 95;

            //menampilkan semua elemen array menggunakan forach
            foreach (int bil in arrBil)
            {
                Console.WriteLine(bil.ToString());
            }
           int[] arrNim = {1989, 1990, 1991 };

            int[] arrNilai = new int[3];

            arrNilai[0] = 95;
            arrNilai[1] = 90;
            arrNilai[2] = 90;

            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("  NO        NIm          Nama       Nilai");
            Console.WriteLine("=========================================");
            Console.WriteLine("  1.        {0}          {1}        {2}", arrNim[0], arrNama[0], arrNilai[0]);
            Console.WriteLine("  2.        {0}          {1}         {2}", arrNim[1], arrNama[1], arrNilai[1]);
            Console.WriteLine("  3.        {0}          {1}         {2}", arrNim[2], arrNama[2], arrNilai[2]);


            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("  NO        NIm          Nama       Nilai");
            Console.WriteLine("=========================================");
            for (int i = 0; i < arrNama.Length; i++)
            {
                Console.WriteLine("  {0}.        {1}          {2}       {3}", (i + 1), arrNim[i], arrNama[i], arrNilai[i]);
           
                Console.WriteLine();
            }

                Console.ReadKey();

        }
    }
}
