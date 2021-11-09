using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    public enum Paises { España, Francia, Alemania, Inglaterra}
    public class Persona
    {
        //constructor
        public Persona()
        {
            this.Edad = 30;
            this.Nacionalidad = Paises.España;
        }
        //sobrecarga
        public Persona(String nombre, String apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }

        //metodo para poner en mayusculas
        public void ConvertirDescripciones()
        {
            for (int i = 0; i < this._Descripciones.Length; i++)
            {
                this._Descripciones[i] = this._Descripciones[i].ToUpper();
            }
        }

        //metodo que devuelve un valor
        public virtual String GetNombreCompleto()
        {
            Console.WriteLine("GetNombreCompleto Persona");
            return this.Nombre + " " + this.Apellidos;
        } 

        //polimorfismo de getnombre
        public String GetNombreCompleto(bool orden)
        {
            if (orden)
            {
                return this.Apellidos + " " + this.Nombre;
            }
            else
            {
                return this.GetNombreCompleto();
            }
        }



        //array
        private string[] _Descripciones = new string[3];
        //propiedad indizada
        public String this[int indice]
        {
            get {
                return this._Descripciones[indice];
            }
            set {
                this._Descripciones[indice] = value;
            }
        }
        public Paises Nacionalidad { get; set; }
        //modo de declarar propiedades si no vamos a contrlar nada
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        //modo de declarar propiedades en las que controlamos algo
        private int _Edad;
        public int Edad
        {
            get {
                return this._Edad;
            }
            set {
                if (value < 0)
                {
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }            
            }
        }
    }
}
