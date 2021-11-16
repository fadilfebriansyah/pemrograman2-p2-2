using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1204029
{
     class Sumur_1204029 : Produk_1204029
        {

            private int jumlah;
            private int cost;
            private int jumlahharga;
        
            // enscaptulation
            public int Jumlah
            {
                get { return jumlah; }
                set { jumlah = value; }
            }

            

        public int Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        public void HitungJumlahHarga()
            {
                this.jumlahharga = jumlah * cost;
            }

       
            public override void Sumur()
            {
                Console.WriteLine("Total Harga = " + jumlahharga);
            }        
        }
    }
