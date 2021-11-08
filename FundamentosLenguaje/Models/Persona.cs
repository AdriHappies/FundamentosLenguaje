using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    public class Persona
    {
        public String Nombre;
        public String Apellidos;
        private int _Edad;
        public int Edad
        {
            get {
                return _Edad;
            }
            set {
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    _Edad = value;
                }            
            }
        }
    }
}
