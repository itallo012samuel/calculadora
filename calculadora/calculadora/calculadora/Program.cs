using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;


namespace calculo
{
    internal class program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" qual calculo você deseja fazer?");
            Console.WriteLine("1 - ADIÇÃO");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO/N");


            int operação = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operação)
            {
                case 1:
                    {
                        resultado = adição(num1, num2);
                        break;
                    }

                case 2:
                    {
                        resultado = subtração(num1, num2);
                        break;
                    }

                case 3:
                    {
                        resultado = multiplicação(num1, num2);
                        break;
                    }

                case 4:
                    {
                        resultado = divisão(num1, num2);
                        break;
                    }
                default:
                    Console.WriteLine("numero invalido");
                    break;

            
                    Console.WriteLine("o resultado da operação é: {0}", resultado );

            }
        }








            public static  int adição (int numero1,int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado; 
        }
        public static int subtração (int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }
        public static int multiplicação (int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }
        public static int divisão (int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }



    }
    
}