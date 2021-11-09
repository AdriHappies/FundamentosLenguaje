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
        }
        public int Salario { get; set; }
        //debe tener un salario minimo
        protected int SalarioMinimo { get; set; }
    }
}
