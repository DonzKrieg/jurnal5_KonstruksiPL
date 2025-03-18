using System;
using modul5_103022330150;

class Program
{
    static void Main()
    {
        PemrosesData proses = new PemrosesData();
        proses.dapatkanNilaiTerbesar<long>(10, 30, 22);
    }
}