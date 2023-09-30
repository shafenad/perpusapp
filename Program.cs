using System;
using perpus;

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek buku
        Buku book1 = new Buku("Kata", "Rintik sedu");


        // Membuat objek anggota perpustakaan
        Member member1 = new Member("Farhan");


        // Membuat objek peminjaman
        //peminjaman pinjam = new peminjaman(book1, member1);

        // Membuat objek peminjaman dengan tanggal kembali
        DateTime tanggalKembali = DateTime.Now.AddDays(20); // Contoh tanggal pengembalian, misalnya 14 hari dari sekarang
        peminjaman pinjam = new peminjaman(book1, member1, tanggalKembali);

        // Menampilkan informasi peminjaman dengan tanggal kembali
        pinjam.tampilinfo();


        // Menampilkan informasi buku
        book1.tampilinfo();

        // Menampilkan informasi peminjaman
        //pinjam.tampilinfo();


        // Menampilkan judul buku dan nama anggota yang meminjam dari informasi peminjaman
        Console.WriteLine("_________________________________________________");
        Console.WriteLine("INFORMASI PEMINJAMAN BUKU PERPUSTAKAAN");
        Console.WriteLine("_________________________________________________");
        Console.WriteLine($"\nBuku yang dipinjam: {pinjam.GetJudulBuku()}");
        Console.WriteLine($"Anggota yang meminjam: {pinjam.GetNamaAnggota()}");
        Console.WriteLine($"Tanggal pinjam: {pinjam.Gettanggalpinjam():yyyy-MM-dd}");
        Console.WriteLine($"Tanggal kembali: {pinjam.Gettanggalkembali():yyyy-MM-dd}");



    }
}
