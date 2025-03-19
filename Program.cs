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

class Program
{
    static void Main(string[] args)
    {
        
        PemrosesData.DapatkanNilaiTerbesar<dynamic>(12, 34, 56);
    }
}
