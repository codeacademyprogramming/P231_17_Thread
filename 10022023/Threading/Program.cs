using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{

    
    struct Car
    {
        public void Drive()
        {
             
        }
    }

    internal class Program
    {
        static async Task Main(string[] args)
        {

            var day = 7;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Bazar ertesi");
                    break;
                case 2:
                    Console.WriteLine("Cersenbe axsami");
                    break;
                case 3:
                    Console.WriteLine("Prosta Cersenbe");
                    break;
                case 4:
                    Console.WriteLine("Cume Axsami");
                    break;
                case 5:
                    Console.WriteLine("Cumeniz muabrek");
                    break;
                case 6:
                    Console.WriteLine("Heftesonu");
                    break;
                case 7:
                    goto case 6;
            }


            nameInput:
            Console.WriteLine("Adi daxil edin:");
            string name1 = Console.ReadLine();

            if (name1.Length < 2) goto nameInput;

            #region Nullable
            //Product pr = new Product{Price=55};


            //double price = 56;

            //string result = pr?.Price > 10 ? "Bahadir" : "Baha deyil";

            //double? newPrice = pr?.Price;

            //Product newPr = pr ?? new Product() {Price =100 };
            ////Product newPr = pr != null ? pr:new Product() { Price = 100 };

            //Console.WriteLine(newPr.Price);

            //Console.WriteLine(pr?.Name?.Length);

            //int[] numbers = { 45, 5, 65 };

            //string[] names = { "Hikmet" };

            //Console.WriteLine(names[0][0]);

            //Predicate<double> func = null;

            //Console.WriteLine(func?.Invoke(10));
            #endregion
            //Thread thread1 = new Thread(ShowA);

            //Thread thread2 = new Thread(ShowB);

            //thread1.Start();

            //thread2.Start();


            //Task task = Task.Run(() =>
            //{
            //    ShowA();
            //}).ContinueWith((x) => Console.WriteLine("Bitdi"));

            //Console.Write("Loading");

            //while (!task.IsCompleted)
            //{
            //    Thread.Sleep(250);
            //    Console.Write(".");
            //}


            //var task = GetGoogleSrc().ContinueWith(x => Console.WriteLine(x.Result));

             GetGoogleSrc();

            Console.WriteLine("Adi daxil et");
            string name = Console.ReadLine();

            Console.WriteLine(name);

            Console.ReadLine();
        }

        static async Task GetGoogleSrc()
        {
            HttpClient httpClient = new HttpClient();

            var result = await httpClient.GetStringAsync("https://google.com");

            Console.WriteLine(result);

        }


        static void ShowA()
        {
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(10);
            }
        }
        static void ShowB()
        {
            for (int i = 0; i < 10000; i++)
            {
                Thread.Sleep(20);

                Console.Write("B ");
            }
        }
    }
}
