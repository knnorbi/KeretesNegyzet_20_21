using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeretesNegyzet_20_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int darab = int.Parse(Console.ReadLine());
            string karakter = Console.ReadLine();
            #region Első
            //for (int i = 0; i < darab; i++)
            //{
            //    Console.Write(karakter);
            //}
            //Console.Write("\n");

            //for (int i = 0; i < darab-2; i++)
            //{
            //    Console.Write(karakter);
            //    for (int j = 0; j < darab-2; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.Write(karakter);
            //    Console.Write("\n");
            //}

            //for (int i = 0; i < darab; i++)
            //{
            //    Console.Write(karakter);
            //}
            //Console.Write("\n");
            #endregion

            #region Második
            //for (int i = 0; i < darab; i++)
            //{
            //    if (i == 0 || i == darab - 1)
            //    {
            //        for (int j = 0; j < darab; j++)
            //        {
            //            Console.Write(karakter);
            //        }
            //    }
            //    else
            //    {
            //        for (int j = 0; j < darab; j++)
            //        {
            //            if (j == 0 || j == darab - 1)
            //            {
            //                Console.Write(karakter);
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }
            //        }
            //    }
            //    Console.Write("\n");
            //}
            #endregion

            #region Harmadik
            //for (int i = 0; i < darab; i++)
            //{
            //    for (int j = 0; j < darab; j++)
            //    {
            //        if (i == 0 || i == darab - 1 || j == 0 || j == darab - 1)
            //        {
            //            Console.Write(karakter);
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.Write("\n");
            //}
            #endregion

            #region Negyedik
            for (int i = 0; i < darab; i++)
            {
                for (int j = 0; j < darab; j++)
                {
                    if ((i == 0 || i == darab - 1) && (j == 0 || j == darab - 1))
                    {
                        Console.Write("#");
                    }
                    else if (i == 0 || i == darab - 1 || j == 0 || j == darab - 1)
                    {
                        Console.Write(karakter);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("\n");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
