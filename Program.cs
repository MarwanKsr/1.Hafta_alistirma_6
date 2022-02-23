using System;

namespace alistirma_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kilonuz giriniz: ");
            float kilo = int.Parse(Console.ReadLine());
            Console.Write("Boyunuz giriniz: ");
            float Boy = int.Parse(Console.ReadLine());
            Boy /= 100;
            float vucut_kutle = kilo / (Boy*Boy);
            Console.WriteLine("Vucut kutle indeksiniz {0} kg/metrekare",vucut_kutle);
        }
    }
}
