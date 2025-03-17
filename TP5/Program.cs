using System;

class Program
{
    static void Main()
    {
        // Menggunakan DataGeneric dengan tipe data String
        DataGeneric<string> dataNIM = new DataGeneric<string>("2311104074");
        dataNIM.PrintData();
    }
}
