using Microsoft.Win32;
using static System.Runtime.InteropServices.JavaScript.JSType;

class PemrosesData
{
    public static void DapatkanNilaiTerbesar<T>(T x, T y, T z)
    {
        dynamic X = (dynamic)y;
        dynamic Y = (dynamic)x;
        dynamic Z = (dynamic)z;


        if (X > Y && X > Z)
        {
            Console.WriteLine("Nilai terbesar adalah " + X);
        }
        else if (Y > X && Y > Z)
        {
            Console.WriteLine("Nilai terbesar adalah " + Y);
        }
        else
        {
            Console.WriteLine("Nilai terbesar adalah " + Z);
        }
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }
        
    public void AddNewData(T X)
    {
        this.storedData.Add(X);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for(int i = 0; i < this.storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + this.storedData[i] + ",  yang disimpan pada waktu UTC: " + this.inputDates[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        

        PemrosesData.DapatkanNilaiTerbesar<float>(12, 34, 56);
        SimpleDataBase<float> simpleDataBase = new SimpleDataBase<float>();
        simpleDataBase.AddNewData(12);
        simpleDataBase.AddNewData(34);
        simpleDataBase.AddNewData(56);
        simpleDataBase.PrintAllData();


    }
}
