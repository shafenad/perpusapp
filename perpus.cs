using System;
using System.Collections.Generic;

namespace perpus
{
    // Interface untuk item perpustakaan
    public interface Iitem_perpus
    {
        void tampilinfo();
    }

    // Kelas abstrak untuk item perpustakaan
    public abstract class item_perpus : Iitem_perpus
    {
        private string judul;

        public item_perpus(string _judul)
        {
            this.judul = _judul;
        }

        public string Getjudul()
        {
            return judul;
        }

        public abstract void tampilinfo();
    }

    // Kelas untuk buku
    public class Buku : item_perpus
    {
        private string pengarang;


        public Buku(string _judul, string _pengarang) : base(_judul)
        {
            this.pengarang = _pengarang;
        }

        public string Getnamapengarang()
        {
            return pengarang;
        }

        public override void tampilinfo()
        {
            Console.WriteLine($"Judul Buku: {Getjudul()}");
            Console.WriteLine($"Pengarang: {Getnamapengarang()}");
        }
    }

    // Kelas untuk anggota perpustakaan
    public class Member
    {
        private string nama_member;

        public Member(string _nama_member)
        {
            this.nama_member = _nama_member;
        }

        public string Getnamamember()
        {
            return nama_member;
        }

        public void pinjambarang(item_perpus item)
        {
            Console.WriteLine($"{Getnamamember()} meminjam '{item.Getjudul()}'");
        }
    }


    // Kelas untuk peminjaman buku
    public class peminjaman
    {
        private item_perpus item;
        private Member member;
        private DateTime tgl_pinjam;
        private DateTime tgl_kembali; 

        public peminjaman(item_perpus _item, Member _member)
        {
            this.item = _item;
            this.member = _member;
            this.tgl_pinjam = DateTime.Now;
        }

        //  overload tanggal kembali
        public peminjaman(item_perpus _item, Member _member, DateTime _tgl_kembali)
        {
            this.item = _item;
            this.member = _member;
            this.tgl_pinjam = DateTime.Now;
            this.tgl_kembali = _tgl_kembali; 
        }

        public DateTime Gettanggalpinjam()
        {
            return tgl_pinjam;
        }

        public DateTime Gettanggalkembali()
        {
            return tgl_kembali;
        }

        public string GetJudulBuku()
        {
            return item.Getjudul();
        }

        public string GetNamaAnggota()
        {
            return member.Getnamamember();
        }

        public void tampilinfo()
        {
            Console.WriteLine($"Tanggal pinjam: {Gettanggalpinjam():yyyy-MM-dd}");
            Console.WriteLine($"Peminjam: {member.Getnamamember()}");
            //Console.WriteLine($"Judul buku: {item.Getjudul()}");
            Console.WriteLine($"Tanggal kembali: {Gettanggalkembali():yyyy-MM-dd}");

        }
    }


}
