using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Andy Ramiro Garzón Toaza

namespace Ejercicio_3
{
    class Persona
    {

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string DNI { get; set; }

    //clase persona
        public Persona(string nombre, int edad, string dni)
        {
            Nombre = nombre;
            Edad = edad;
            DNI = dni;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}\n" +
                $" Edad: {Edad}\n" +
                $" DNI: {DNI}";
        }
    }

    // Clase Punto
    class Punto  
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"Punto (X: {X}, Y: {Y})";
        }
    }

    // Clase Círculo
    class Circulo
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radio { get; set; }

        public Circulo(double x, double y, double radio)
        {
            X = x;
            Y = y;
            Radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }

        public override string ToString()
        {
            return $"Círculo (X: {X}, Y: {Y}, Radio: {Radio})";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do 
            {
                Console.WriteLine("Elige una de las siguientes Opciones:");
                Console.WriteLine("1. Datos de una persona");
                Console.WriteLine("2. Punto en el plano cartesiano");
                Console.WriteLine("3. Círculo, y calcular su área");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("¡ERROR INGRESAR UN NUMERO VALIDO!.\n");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre de la persona: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese la edad de la persona: ");
                        int edad = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el DNI o cédula de la persona: ");
                        string dni = Console.ReadLine();

                        Persona persona = new Persona(nombre, edad, dni);
                        Console.WriteLine("Datos de la persona ingresada: " + persona);
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Write("Ingrese la coordenada X: ");
                        double x = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la coordenada Y: ");
                        double y = double.Parse(Console.ReadLine());

                        Punto punto = new Punto(x, y);
                        Console.WriteLine("Punto creado: " + punto);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Ingrese la coordenada X del círculo: ");
                        double cx = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la coordenada Y del círculo: ");
                        double cy = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el radio del círculo: ");
                        double radio = double.Parse(Console.ReadLine());

                        Circulo circulo = new Circulo(cx, cy, radio);
                        Console.WriteLine("Círculo creado: " + circulo);
                        Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intenta nuevamente.\n");
                        break;
                }

            } while (opcion != 4);

            Console.WriteLine("¡Gracias por utilizar este programa!");
        }
    }
}