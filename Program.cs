using System;

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> data = new DataGeneric<string>("1302223076");
        data.PrintData();

        Console.WriteLine("Halo user Praktikan, Irvan Dzawin Nuha kelas SE4602, S-1 Rekayasa Perangkat Lunak, Angkatan 2022, Mata Kuliah Konstruksi Perangkat Lunak");
    }
}