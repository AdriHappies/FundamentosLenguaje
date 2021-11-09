using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    //hereda de persona
    public class Empleado: Persona
    {
        public Empleado()
        {
            this.SalarioMinimo = 900;
            this.Salario = this.SalarioMinimo;
            Console.WriteLine("Constructor empleado SIN PARAMETROS");
        }

        public Empleado(int salario)
        {
            this.SalarioMinimo = 900;
            Console.WriteLine("Constructor empleado CON PARAMETROS");
        }

        public virtual int GetDiasVacaciones()
        {
            return 30;
        }
        public override string ToString()
        {
            return this.Apellidos + " " + this.Nombre + ", Salario minimo: " + this.SalarioMinimo;
        }
        public override String  GetNombreCompleto()
        {
            Console.WriteLine("GetNombreCompleto Empleado");
            return this.Nombre + " " + this.Apellidos + ", Salario: " + this.Salario;
        }
    
        public int Salario { get; set; }
        //debe tener un salario minimo
        protected int SalarioMinimo { get; set; }
    }
}
