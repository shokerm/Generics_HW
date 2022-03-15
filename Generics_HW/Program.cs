using System;

namespace Generics_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Knight k1 = new Knight
            {
                Id = 123,
            };
            Knight k2 = new Knight
            {
                Id = 456,
            };
            Knight k3 = new Knight
            {
                Id = 789,
            };

            GenericHerosTable<Knight> Hk = new GenericHerosTable<Knight>();

            Hk.Set(0, k1);
            Hk.Set(1, k2);
            Hk.Set(2, k3);

            Console.WriteLine(Hk[6]);
        }
    }
}
