using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<string> daftarMahasiswa = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nPilih Menu Aplikasi");
                Console.Write("\n");
                Console.Write("\n1. Tambah Mahasiswa");
                Console.Write("\n2. Hapus Mahasiswa");
                Console.Write("\n3. Tampilkan Mahasiswa");
                Console.Write("\n4. Keluar");

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            {
                Console.Clear();
                Mahasiswa Mahasiswa = new Mahasiswa();

                Console.Write("NIM: ");
                Mahasiswa.nim = Console.ReadLine();
                Console.Write("Nama: ");
                Mahasiswa.nama = Console.ReadLine();
                Console.Write("Jenis Kelamin [L/P] : ");
                Mahasiswa.Kelamin = Console.ReadLine();
                if (Mahasiswa.Kelamin == "L")
                {
                    Mahasiswa.Kelamin = "Laki-Laki";
                }
                else if (Mahasiswa.Kelamin == "P")
                {
                    Mahasiswa.Kelamin = "Perempuan";
                }

                Console.Write("IPK : ");
                Mahasiswa.total = Console.ReadLine();



                daftarMahasiswa.Add(Mahasiswa);

                // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

                Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();
            Mahasiswa delete = daftarMahasiswa.SingleOrDefault(x => x.NIM == nim);
            if (daftarMahasiswa.Contains(delete) == true)
            {
                daftarMahasiswa.Remove(delete);
                Console.WriteLine("Data Mahasiswa Berhasil Dihapus");
            }
            else
            {
                Console.WriteLine("NIM Tidak Ditemukan");
            }

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.Write("IPK : ");
            mahasiswa.IPK = double.Parse(Console.ReadLine());
            Console.Write("Jenis Kelamin [L/P] : ");
            mahasiswa.JK = Console.ReadLine();
            if (mahasiswa.JK == "L")
            {
                mahasiswa.JK = "Laki-Laki";
            }
            else if (mahasiswa.JK == "P")
            {
                mahasiswa.JK = "Perempuan";
            }

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
