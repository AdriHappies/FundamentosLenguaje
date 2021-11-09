using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    public class Director: Empleado
    {
        public override int GetDiasVacaciones()
        {
            return base.GetDiasVacaciones() + 20;
        }
        public Director()
        {
            this.SalarioMinimo = 1400;
            Console.WriteLine("Constructor Director SIN PARAMETROS");
        }

        public Director(int salario):base(12)
        {
            Console.WriteLine("Constructor director CON PARAMETROS");
        }
    }
}
