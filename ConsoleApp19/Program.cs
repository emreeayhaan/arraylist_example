using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {//bir list oluşturunliste kaç eleman attığımızı kulanıcı belirleyecek list random dolsun farklı bir liste tersten atılıcak
            ArrayList a = new ArrayList();
            int b = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < b; i++)
            {
                a.Add(r.Next(100));
                Console.WriteLine(a[i]);
            }
            ArrayList c = new ArrayList();
            for (int i = 0; i < b; i++)
            {
                c.Add(a[a.Count - 1 - i]);
            }
            Console.WriteLine("-----------------------------------");
            foreach (object x in c)
            {

                Console.WriteLine(x);
            }
        }
    }
}
