using System;
using System.Collections.Generic;
using System.Text;

namespace UD6_M2
{
    public class Milestone2
    {
        public void Principal()
        {
            int altura = 0;
            Console.WriteLine("Dame la altura");
            altura = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = altura ; i >= 1; i--)
            {
                for (int lado = altura - 1; lado >= i; lado--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                for (int j = i - 1; j >= 0; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
