
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204029
{
    class Program
    {
        static string ulang = "";

        public static string UlangMenu()
        {
            Console.Write("Ulang lagi? Y/N    ");
            ulang = Console.ReadLine();
            Console.WriteLine();
            return ulang;
        }

        public static void MenuSusuMurni()
        {
            Sumur_1204029 sumur = new Sumur_1204029();

            Console.Write("Masukan Jumlah Susu Murni = ");
            int jumlahss = Convert.ToInt32(Console.ReadLine());
            sumur.Jumlah = jumlahss;

            Console.Write("Masukan Harga Susu Murni = ");
            int hargass = Convert.ToInt32(Console.ReadLine());
            sumur.Cost = hargass;

            sumur.HitungJumlahHarga();

            Console.WriteLine();
            
            sumur.Sumur();
            Console.WriteLine();

            UlangMenu();
        }
        public static void MenuYoughurt()
        {
            Youghurt_1204029 youg = new Youghurt_1204029();

            Console.Write("Masukan Jumlah Youghurt = ");
            int jumlahss = Convert.ToInt32(Console.ReadLine());
            youg.Jumlahy = jumlahss;

            Console.Write("Masukan Harga Youghurt = ");
            int hargass = Convert.ToInt32(Console.ReadLine());
            youg.Harga = hargass;

            youg.HitungJumlahHarga();

            Console.WriteLine();

            youg.Youghurt();
            Console.WriteLine();

            UlangMenu();
        }
        static void Main(string[] args)
        {
              try
                {
                    do
                    {
                        Console.WriteLine("Aplikasi Toko Susu Murni");
                        Console.WriteLine("Menu: \n" +
                            "1. Susu Murni \n" +
                            "2. Youghurt \n" +
                            "Masukan pilihan anda (1 atau 2)");
                        int menu = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        switch (menu)
                        {
                            case 1:
                                MenuSusuMurni();
                                break;
                            case 2:
                                MenuYoughurt();
                                break;
                            default:
                                Console.WriteLine("Menu yang anda pilih tidak tersedia");
                                break;
                        }

                    } while (ulang == "Y" || ulang == "y");

                    Console.WriteLine("Keluar dari aplikasi... \n");
                }
                catch (Exception )
                {
                    Console.WriteLine("\nTerjadi Kesalahan");
                    Console.WriteLine("Keluar dari aplikasi... \n");
                }
            }
        }
    }

