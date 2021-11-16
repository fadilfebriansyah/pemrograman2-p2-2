using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204029
{
    class Youghurt_1204029 : Produk_1204029
    {
        private int jumlahy;
        private int harga;
        private int jumlahhargay;


        public int Jumlahy
        {
            get { return jumlahy; }
            set { jumlahy = value; }
        }
        public int Harga
        {
            get
            {
                return harga;
            }

            set
            {
                harga = value;
            }
        }

        public void HitungJumlahHarga()
        {
            this.jumlahhargay = jumlahy * harga;
        }


        public override void Youghurt()
        {
            Console.WriteLine("Total Harga = " + jumlahhargay);
        }
    }
}
