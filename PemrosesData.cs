using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_103022330150
{
    internal class PemrosesData
    {
        public void dapatkanNilaiTerbesar<T>(T input1, T input2, T input3)
        {
            dynamic data1 = input1;
            dynamic data2 = input2;
            dynamic data3 = input3;

            if ((data1 > data2) && (data1 > data3)) {
                Console.WriteLine("Nilai terbesar: " + data1);
            } 
            else if ((data2 > data1) && (data2 > data3))
            {
                Console.WriteLine("Nilai terbesar: " + data2);
            }
            else if ((data3 > data1) && (data2 > data2))
            {
                Console.WriteLine("Nilai terbesar: " + data2);
            }
        }
    }
}
