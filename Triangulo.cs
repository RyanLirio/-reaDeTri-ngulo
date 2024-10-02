using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientacaoAobjetos
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            //Fórmula
            //A = RAIZ de p(p-a)*(pc)*(p-c)
            //p = (a+b+c)/2
            double p = (A+B+C)/2;
            double raiz = Math.Sqrt (p*(p-A)*(p-B)*(p-C));
            return raiz;
        }
    }
}