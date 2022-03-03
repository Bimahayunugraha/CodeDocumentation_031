using System;
 
namespace Persegi
{
    /// <summary>
    /// Main Class
    /// <c>Persegi</c>
    /// memodelkan operasi penghitungan persegi panjang
    /// </summary>
    /// <remarks>
    /// class "Persegi" dapat membuat operasi input data (value), operasi penghitungan persegi panjang, dan hasil dari penghitungan (output)
    /// </remarks>
    class Persegi
    {
        /// <summary>
        /// Variabel instan
        /// <c>Panjang</c>
        /// mewakili nilai dari panjang persegi panjang
        /// </summary>
        public double Panjang;

        /// <summary>
        /// Variabel instand
        /// <c>Lebar</c>
        /// mewakili nilai dari lebar persegi panjang
        /// </summary>
        public double Lebar;

        /// <summary>
        /// Operasi untuk input nilai atau value
        /// </summary>
        /// <remarks>
        /// Pada operasi InputData dapat memasukkan nilai atau value untuk panjang dan lebar persegi panjang
        /// </remarks>
        public void InputData()
        {
            Console.Write("Masukkan Panjang Persegi : ");
            Panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Lebar Persegi : ");
            Lebar = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Operasi penghitungan panjang dan lebar persegi panjang
        /// </summary>
        /// <param name="P">nilai pertama yang di inputkan dalam operasi penghitungan panjang dan lebar</param>
        /// <param name="L">nilai kedua yang di inputkan dan akan di kalikan dengan inputan angka yang pertama</param>
        /// <returns>hasil dari perkalian nilai pertama dan nilai kedua</returns>
        public double Proses(Double P, Double L)
        {
            return P * L;
        }

        /// <summary>
        /// Operasi menampilkan hasil atau ouput dari penghitungan panjang dan lebar
        /// <example>
        /// Contoh :
        /// <value>
        /// Panjang : 5
        /// Lebar : 5
        /// </value>
        /// Hasil <c>Persegi</c> memiliki nilai 25.
        /// </example>
        /// </summary>
        /// <remarks>
        /// Pada operasi ouput untuk menampilkan hasil dari hitung perkalian panjang dan lebar persegi panjang
        /// </remarks>
        public void Output()
        {
            Console.Write("Hasil Persegi = " + Proses(Panjang, Lebar));
            Console.ReadKey();                
        }

        /// <summary>
        /// Parameter Main
        /// </summary>
        /// <param name="args">
        /// Sebuah array berbentuk String yang menyimpan argumen yang dipassing melalui command line atau terminal ketika program di eksekusi
        /// </param>
        /// <remarks>
        /// Pada parameter Main dapat membuat variabel baru, mengeksekusi untuk input nilai, dan mengeksekusi untuk hasil atau output dari hitung
        /// perkalian panjang dan lebar
        /// </remarks>
        static void Main(string[] args)
        {
            Persegi hitung = new Persegi();
            hitung.InputData();
            hitung.Output();
        }
    }
}
