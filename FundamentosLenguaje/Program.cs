using System;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using FundamentosLenguaje.Models;

namespace FundamentosLenguaje
{
    enum TipoChar {Letras, Numeros, Simbolos}
    class Program
    {
        static void Main(string[] args)
        {
            Persona person = new Persona();
            person.Nombre = "Alumno";
            person.Apellidos = "Azure";
            person.Edad = 25;
            Console.WriteLine(person.Nombre + ", " + person.Apellidos +
                ", " + person.Edad);
        }

        static void PedirMostrarNombres()
        {
            String name = "";
            List<String> nombres = new List<string>();
            Console.WriteLine("A continuación se le pedirá que escriba nombres");
            Console.WriteLine("Cuando no quiera escribir más nombres escriba N");
            while (name != "N")
            {
                Console.WriteLine("Escriba un nombre");
                name = Console.ReadLine();
                if (name != "N")
                {
                    nombres.Add(name);
                }
                
            }
            foreach (String n in nombres)
            {
                Console.WriteLine(n);
            }

        }

        static void EjemploColecciones()
        {
            List<int> numeros = new List<int>();
            numeros.Add(45);
            numeros.Add(78);
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            List<String> nombres = new List<string>();
            nombres.Add("Ana");
            nombres.Add("Adrian");
            nombres.Add("Lucia");
            nombres.Add("Ana");
            //elimina el primer elemento que encuentra, la primera coincidencia
            //nombres.Remove("Ana");
            //podemos eliminar por indice en la coleccion
            nombres.RemoveAt(3);
            foreach (String name in nombres)
            {
                Console.WriteLine(name);
            }
        }

        static void InvertirTextoStringBuilder(String datos)
        {
            Stopwatch krono = new Stopwatch();
            krono.Start();
            StringBuilder texto = new StringBuilder();
            texto.Append(datos);
            for (int i = 0; i < texto.Length; i++)
            {
                char letra = texto[texto.Length - 1];
                texto = texto.Remove(texto.Length - 1, 1);
                texto = texto.Insert(i, letra.ToString());
            }
            Console.WriteLine("\n");
            krono.Stop();
            Console.WriteLine(texto);
            Console.WriteLine("\n");
            Console.WriteLine("Milisegundos: " + krono.Elapsed.TotalMilliseconds);
        }

        static void InvertirTextoString(String texto)
        {
            Stopwatch krono = new Stopwatch();
            krono.Start();
            for (int i = 0; i < texto.Length; i++)
            {
                char letra = texto[texto.Length - 1];
                texto = texto.Remove(texto.Length - 1, 1);
                texto = texto.Insert(i, letra.ToString());
            }
            Console.WriteLine("\n");
            krono.Stop();
            Console.WriteLine(texto);
            Console.WriteLine("\n");
            Console.WriteLine("Milisegundos: " + krono.Elapsed.TotalMilliseconds);
        }
        
        static void SumarNumerosString()
        {
            Console.WriteLine("Introduzca un texto");
            string texto = Console.ReadLine();
            int suma = 0;
            for (var i = 0; i < texto.Length; i++)
            {
                char caracter = texto[i];
                //int num = (int)caracter;
                int num = int.Parse(caracter.ToString());
                suma += num;
            }
            Console.WriteLine(suma);
        }

        static void EjemploChar(TipoChar tipo)
        {
            for (int i = 0; i <= 255; i++)
            {
                char letra = (char)i;
                if (tipo == TipoChar.Simbolos)
                {
                    if (char.IsSymbol(letra))
                    {
                        Console.WriteLine(letra);
                    }
                }else if (tipo == TipoChar.Letras)
                {
                    if (char.IsLetter(letra))
                    {
                        Console.WriteLine(letra);
                    }
                }else if (tipo == TipoChar.Numeros)
                {
                    if (char.IsNumber(letra))
                    {
                        Console.WriteLine(letra);
                    }
                }
            }
        }

        static void SumarNumeros()
        {
            Console.WriteLine("Introduzca un número");
            String dato = Console.ReadLine();
            int numero = int.Parse(dato);
            int suma = numero;
            while (numero != 0)
            {
                Console.WriteLine("Suma " + suma);
                Console.WriteLine("Introduzca numero");
                dato = Console.ReadLine();
                numero = int.Parse(dato);
                suma += numero;
            }
            Console.WriteLine("Hasta luego");
        }

        static void NumerosPares()
        {
            Console.WriteLine("Introduzca un inicio: ");
            String dato = Console.ReadLine();
            int inicio = int.Parse(dato);
            Console.WriteLine("Introduzca un fin: ");
            dato = Console.ReadLine();
            int fin = int.Parse(dato);
            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void ConjeturaCollatz()
        {
            Console.WriteLine("Introduzca un número");
            String dato = Console.ReadLine();
            int numero = int.Parse(dato);
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    //PAR
                    numero = numero / 2;
                }
                else
                {
                    numero = numero * 3 + 1;
                }
                Console.WriteLine(numero);
            }
        }


        static void CalculoDiaNacimiento()
        {
            Console.WriteLine("A continuación escribe tu fecha de nacimiento\n");
            Console.WriteLine("Escribe el día que naciste");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el mes que naciste");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el año que naciste");
            int anyo = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 2)
            {
                mes += 12;
                anyo -= 1;
            }

            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;
            int op5 = ((mes * 2) + dia+ anyo + op1 + op2 - op3 + op4 + 2);
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);

            if (resultado == 0)
            {
                Console.WriteLine("Naciste un sábado");
            }else if (resultado == 1)
            {
                Console.WriteLine("Naciste un domingo");
            }else if (resultado == 2)
            {
                Console.WriteLine("Naciste un lunes");
            }else if (resultado == 3)
            {
                Console.WriteLine("Naciste un martes");
            }else if (resultado == 4)
            {
                Console.WriteLine("Naciste un miércoles");
            }else if (resultado == 5)
            {
                Console.WriteLine("Naciste un jueves");
            }else if (resultado == 6)
            {
                Console.WriteLine("Naciste un viernes");
            }
            else
            {
                Console.WriteLine("Error de computación");
            }
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
            //cambio
        }
    }
}
