using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    delegate string mydel(string c);
    class main
    {
        public string getrgb(string c)
        {
            return c;
        }
    }


    delegate void Mydel1(int[] arr);
    delegate void MyDel2(int[] mass);
    delegate void mydel3(string ar);
    class Program
    {
        static void Main(string[] args)
        {
            //1
            mydel gett = delegate (string c)
            {
                return c;
            };
            gett("255, 0, 0");
            gett("255, 102, 0");
            gett("255, 255, 0");
            gett("0,255,0");
            gett("0,255,255");
            gett("0,0,255");
            gett("128,00,255");


            //3
        Console.ForegroundColor = ConsoleColor.DarkRed;
            int[] arr = new int[8];
            Random rand = new Random();
            Mydel1 obj = (int[] arr) =>
            {
                int Count = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1, 20);
                    Console.Write(arr[i] + "\t");
                    if (arr[i] % 7 == 0)
                    {
                        Count++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Количество чисел которые кратные 7: " + Count);
            };
            obj(arr);
            Console.WriteLine();


            //4
            int[] mass = new int[6] ;
            MyDel2 obj1 = (int[] mass) =>
            {
                int Counter = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    arr[i] = rand.Next(-10, 5);
                    Console.Write(mass[i] + "\t");
                    if (mass[i] > 0)
                    {
                        Counter++;
                    }

                }
                Console.WriteLine("Количесвто положительных чисел : " + Counter);
                Console.WriteLine();
            };
            obj1(mass);
            Console.WriteLine();

            //5
            MyDel2 obj2 = (int[] mass) =>
            {
                int Count = 0;
                for (int i = 0; i < mass.Length; i++)
                {

                    Console.Write(mass[i] + "\t");
                    if (mass[i] < 0)
                    {
                        Count++;
                    }
                }
                Console.WriteLine("Количесвто отрицательных чисел: " + Count);
                Console.WriteLine();
            };
            obj2(mass);
            Console.WriteLine();

            //6
            mydel3 obj3 = (string ar) =>
            {
                ar ="hello world";
                Console.WriteLine("Введите слово, которое хоитет найти");
                string w = (Console.ReadLine());
                if(ar==w)
                {
                    Console.WriteLine(w);
                }
                Console.WriteLine();

            };

        }
    }
}
