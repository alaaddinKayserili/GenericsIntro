using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> isimler = new MyList<int>();
            isimler.Add(10);
            isimler.Add(20);
            Console.WriteLine("Eleman sayısı:"+isimler.Length);
            Console.WriteLine("---------------------");
            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
            Console.ReadKey();
        }
    }
}
