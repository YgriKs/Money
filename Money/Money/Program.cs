using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(100, 5, 85);
            m1.Show();
            Console.WriteLine(m1.Enough());
            Console.WriteLine(m1.Howmany());
        }
    }
}
