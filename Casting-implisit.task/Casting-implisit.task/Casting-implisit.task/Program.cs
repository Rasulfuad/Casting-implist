using System;
using Casting_implisit.task.Models;
namespace Casting_implisit.task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Exchange(Currecy obj, double azn)
            {
                double result = 0;
                if (obj is Currecy)
                {
                    switch (obj)
                    {
                        case Currecy.Usd:
                            result = azn * 0.59;
                            break;
                        case Currecy.Euro:
                            result = azn * 0.59;
                            break;
                        case Currecy.Try:
                            result = azn * 8.62;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please select a currency...");
                }
                return result 
            }
        }
    }
}
