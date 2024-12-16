using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;


                int maior = 0;

                int[] idade;
                idade = new int[4];

                idade[0] = 14;
                idade[1] = 15;
                idade[2] = 60;
                idade[3] = 99;

                for (int i = 0; i < 4; i++)
                {
                    if (idade[i] > maior)
                    {
                        maior = idade[i];

                    }
                }
                Console.WriteLine(maior);


            }

        }
    }
}