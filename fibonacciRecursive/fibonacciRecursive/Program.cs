using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace fibonacciRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();// programın sonucu ne kadar sürede bulacağını bilmek için stopwatch nesnesi oluşturuldu.

            Console.WriteLine("Kaçıncı fibonacci sayisini bulalim:");

            int x = Int32.Parse(Console.ReadLine()); // bulunacak olan fibonaççi sayısının girilmesi istendi.

            stopwatch.Start(); // süre başlatıldı

            Console.WriteLine("değer:" + fibonacciRecursive(x)); //fibonaççi sayısının değeri ekrana yazıldı.

            stopwatch.Stop(); // süre durduruldu. 

            TimeSpan timespan = stopwatch.Elapsed; // Timespan nesnesi oluşturuldu. Bu nesne süreyi ekrana yazdırabilmek için stopwatch fonksiyonunun elapsed özelliğini kullanarak süre hesaplandı.
           
            string süre = String.Format("{0}:{1}:{2}.{3}", timespan.Hours, timespan.Minutes, timespan.Seconds, timespan.TotalMilliseconds * 1000000);

            Console.WriteLine("Calisma Suresi:" + süre);// çalısma süresini ekrana yazdırıldı.

            Console.ReadLine();// sürenin ekranda görünmesini  sağlandı.
        }

        public static double fibonacciRecursive(int x)
        {
            if (x==1 || x==0)
            {
                return 1;
            }
            else
            {
                return fibonacciRecursive(x - 2) + fibonacciRecursive(x - 1);
            }
        }
    }
}
