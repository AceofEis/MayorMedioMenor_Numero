using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorMedioMenor_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
                int num, a, b, c;
                Console.WriteLine("Ingrese primer numero: ");
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese segundo numero: ");
                b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese tercer numero: ");
                c = Int32.Parse(Console.ReadLine());

                if ((a > b) && (a > c))
                {
                    Console.WriteLine("{0} es el mayor ", a);
                if (b > c)
                {
                    Console.WriteLine("{0} es el medio ", b);
                    Console.WriteLine("{0} es el menor ", c);
                }
                else
                {
                    if (c > b)
                    {
                        Console.WriteLine("{0} es el medio ", c);
                        Console.WriteLine("{0} es el menor ", b);
                    }
                }
                }
                else
                {
                    if ((b > a) && (b > c))
                    {
                        Console.WriteLine("{0} es el mayor ", b);
                    if (a > c)
                    {
                        Console.WriteLine("{0} es el medio ", a);
                        Console.WriteLine("{0} es el menor ", c);
                    }
                    else
                    {
                        if (c > a)
                        {
                            Console.WriteLine("{0} es el medio ", c);
                            Console.WriteLine("{0} es el menor ", a);
                        }
                    }
                }

                    else
                    {
                        if ((c > a) && (b > a))
                        {
                            Console.WriteLine("{0} es el mayor ", c);
                        }
                    }
                }
                Console.ReadKey();

            }
        }
    }
