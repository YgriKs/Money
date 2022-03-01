using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Money
{
    class Money
    {
        private int denomination;
        private int count;
        private int N;

        public Money(int denomination, int count, int N) 
        {
            this.denomination = denomination;
            this.count = count;         
            this.N = N;
        }

        public void Show() 
        {
            Console.WriteLine("\nНоминал купюры = {0}\nКоличество Купюр = {1}", denomination, count);
        }

        public bool Enough() 
        {
            if ((denomination * count) > N)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Howmany() 
        {
            return (denomination * count) / N;      
        }

        public int Denomination
        {
            get { return denomination; }
            set { denomination = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
