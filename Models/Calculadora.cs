using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos.Models
{
    public class Calculadora
    {
        public void Somar (double x,double y){
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
        public void Subtrair (double x,double y){
            Console.WriteLine($"{x} - {y} = {x-y}");
        }
        public void Multiplicar(double x,double y){
            Console.WriteLine($"{x} x {y} = {x*y}");
        }
        public void Dividir(double x,double y){
            Console.WriteLine($"{x} / {y} = {x/y}");
        }
        public void Potencia(double x,double y){
            Console.WriteLine($"{x} ** {y} = Math.Pow(x, y)");
        }
        public void RaizQuadrada (double x){
            Console.WriteLine($"Raiz quadrada de {x} é {Math.Sqrt(x)}");
        }
    }
}