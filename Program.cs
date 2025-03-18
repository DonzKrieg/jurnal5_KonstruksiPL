using System;
using modul5_103022330150;

class Program
{
    static void Main()
    {
        PemrosesData proses = new PemrosesData();
        proses.dapatkanNilaiTerbesar<long>(10, 30, 22);

        SimpleDataBase<long> data = new SimpleDataBase<long>();
        data.addNewData(10);
        data.addNewData(30);
        data.addNewData(22);

        data.printAllData();
    }
}