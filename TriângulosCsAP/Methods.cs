using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TriângulosCsAP
{
    class Methods
    {
      public static void InputRegister()
        {
            Console.Clear();
            Console.WriteLine("Declare a Medida do Primeiro Lado:\n");
            double X = double.Parse(Console.ReadLine());
            Console.WriteLine("Declare a Medida do Segundo Lado:\n");
            double Y = double.Parse(Console.ReadLine());
            Console.WriteLine("Declare a Medida do Terceiro Lado:\n");
            double Z = double.Parse(Console.ReadLine());

            ValidateTriangle(X, Y, Z);
            CalcPerimeter(X, Y, Z);
            ClassTriangle(X, Y, Z);
            Program.Enquire();
        }

        public static void ValidateTriangle(double x, double y, double z)
        {
            
            if (x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Medidas Inválidas, todos os valores devem ser diferentes ou maiores do que zero\n");
                InputRegister();
            } else if (x + y < z || x +z < y || y +z < x){
                Console.WriteLine("Medidas Inválidas, a soma de quaisquer dois lados deve ser maior que o terceiro lado\n");
                InputRegister();
            } else
            {
                Console.WriteLine("\nO Triângulo é Valido");
            }
        }

        public static void CalcPerimeter(double x, double y, double z)
        {
            double result = (x + y + z);
            double roundedResult = Math.Round(result, 2);
            Console.WriteLine($"Perímetro : {roundedResult}");
        }

        public static void ClassTriangle(double x, double y, double z)
        {
            if (x == y && x == z && y == z)
            {
                Console.WriteLine("Tipo de Triângulo : Equilátero\n");
            } else if (x != y && x != z && y != z)
            {
                Console.WriteLine("Tipo de Triângulo : Escaleno\n");
            } else
            {
                Console.WriteLine("Tipo de Triângulo : Isósceles\n");
            }
        }
        
     
            

            
        

    
    
    
    
    }
}
