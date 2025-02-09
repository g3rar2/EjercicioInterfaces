using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class Operaciones : IOperaciones

    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double altura { get; set; }

        public double lempiras { get; set; }

        public double celsius { get; set; }


        public double Area()
        {
            return lado1*lado2/2;
        }

        public double Dolares()
        {
            return lempiras * 25.25;
        }

        public double Farenheith()
        {
            return celsius + 273;
        }

        public double Hipotenusa()
        {
            return (lado1*lado1)+(lado2*lado2);
        }

        public double Volumen()
        {
            return Area()*altura;
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"El area del triangulo es: {Area()}");
            Console.WriteLine($"La Hipotenusa del tirandulo es: {Hipotenusa()}");
            Console.WriteLine($"El volumen del Prisma es: {Volumen()}");
            Console.WriteLine($"Los grados Frenheit son: {Farenheith()}");
            Console.WriteLine($"La cantidad de dolares es: {Dolares()}");

        }




    }
}






