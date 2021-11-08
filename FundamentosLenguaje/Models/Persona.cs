using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    public enum Paises { España, Francia, Alemania, Inglaterra}
    public class Persona
    {
        public Paises Nacionalidad { get; set; }
        //modo de declarar propiedades si no vamos a contrlar nada
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        //modo de declarar propiedades en las que controlamos algo
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
