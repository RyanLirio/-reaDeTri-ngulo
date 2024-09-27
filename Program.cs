using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace  OrientacaoAobjetos
{
    class Program
    {
        static public void Main()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Esse software calcula a área de dois triângulos e lhe retorna, além das medidas, qual triangulo é maior.\nPara calcular insira a medida dos lados do primeiro triângulo em cm:");
           Console.ForegroundColor = ConsoleColor.Black;
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora insira a medida dos lados do segundo triangulo:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            //Fórmula
            //A = RAIZ de p(p-a)*(pc)*(p-c)
            //p = (a+b+c)/2
            double pX = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(pX*(pX-x.A)*(pX-x.B)*(pX-x.C));
            Console.WriteLine($"Area do triângulo A: {areaX.ToString("F4")}");

            double pY = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(pY*(pY-y.A)*(pY-y.B)*(pY-y.C));
            Console.WriteLine($"Area do triângulo B: {areaY.ToString("F4")}");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if(areaX > areaY)
            {
                Console.WriteLine("\nO primeiro triângulo é maior que o segundo");
            }
            else
            {
                Console.WriteLine("\nO segundo triângulo é maior que o primeiro\n");
            }
            
        }
    }
}