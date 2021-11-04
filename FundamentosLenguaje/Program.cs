using System;

namespace FundamentosLenguaje
{
    class Program
    {
        static void Main(string[] args)
        {
            //desde aqui ejecutamos los metodos
            //NumeroPositivoNegativo();
            ComparacionNumeros();
        }

        static void NumeroPositivoNegativo()
        {
            //aqui todo el código
            Console.WriteLine("Introduzca un número");
            String dato = Console.ReadLine();
            int num = int.Parse(dato);
            if (num > 0)
            {
                Console.WriteLine("POSITIVO");
            }else if (num == 0)
            {
                Console.WriteLine("CERO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
        }

        static void ComparacionNumeros()
        {
            Console.WriteLine("Introduzca número 1");
            String dato = Console.ReadLine();
            int num1 = int.Parse(dato);
            Console.WriteLine("Introduzca número 2");
            dato = Console.ReadLine();
            int num2 = int.Parse(dato);
            Console.WriteLine("Introduzca número 3");
            dato = Console.ReadLine();
            int num3 = int.Parse(dato);
            int mayor = 0, menor = 0, intermedio = 0;
            //para usar variable debemos darle un valor
            if (num1>=num2 && num1>=num3)
            {
                mayor = num1;
            }else if (num2>=num1 && num2>=num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = num3;
            }
            if (num1 <= num2 && num1 <= num3)
            {
                menor = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }
            int suma = (num1 + num2 + num3);
            intermedio = suma - mayor - menor;

            Console.WriteLine("Número mayor: " + mayor);
            Console.WriteLine("Número intermedio: " + intermedio);
            Console.WriteLine("Número menor: " + menor);
        }
    }
}
