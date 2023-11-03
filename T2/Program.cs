using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("==================================================");
            Console.Write("Por favor, ingrese el número de pesos a analizar: ");
            int numPersonas;
            
            

            if (int.TryParse(Console.ReadLine(), out numPersonas) && numPersonas > 0 && numPersonas <= 300)
            {
                double sumadePesos = 0;
                int menosDe60Kg = 0;
                int masDe100Kg = 0;

                for (int i = 0; i < numPersonas; i++)
                {
                    Console.WriteLine("==================================================");
                    Console.Write($"Ingrese el peso de la persona {i + 1} en kg: ");
                    if (double.TryParse(Console.ReadLine(), out double peso))
                    {
                        sumadePesos += peso;

                        if (peso < 60)
                        {
                            menosDe60Kg++;
                        }
                        else if (peso > 100)
                        {
                            masDe100Kg++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("El valor ingresado no es válido. Por favor, ingrese un valor numérico.");
                        i--;
                    }
                }

                Console.WriteLine("==================================================");
                Console.WriteLine($"La suma de todos los pesos es: {sumadePesos} kg");
                Console.WriteLine($"Personas con menos de 60 kg: {menosDe60Kg}");
                Console.WriteLine($"Personas con más de 100 kg: {masDe100Kg}");
            }
            else
            {
                Console.WriteLine("Número de personas invalido. Debe estar entre 1 y 300.");
            }
            Console.ReadKey();
        }
    }

}
