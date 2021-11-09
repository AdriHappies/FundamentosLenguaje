using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Models
{
    public class Coche
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public int VelocidadActual { get; set; }
        public int VelocidadMaxima { get; set; }
        public String Direccion { get; set; }
        public bool Arrancado { get; set; }

        public void Arrancar()
        {
            this.Arrancado = true;
            Console.WriteLine("Coche arrancado");
        }
        public void Acelerar()
        {
            if (this.Arrancado)
            {
                this.VelocidadActual += 20;
                if (this.VelocidadActual > this.VelocidadMaxima)
                {
                    this.VelocidadActual = this.VelocidadMaxima;
                }
            }
            else
            {
                throw new Exception("No puedes acelerar si no has arrancado el coche");
            }
            
        }
        public void Acelerar(int incremento)
        {
            if (this.Arrancado)
            {
                this.VelocidadActual += incremento;
                if (this.VelocidadActual > this.VelocidadMaxima)
                {
                    this.VelocidadActual = this.VelocidadMaxima;
                }
            }
            else
            {
                throw new Exception("No puedes acelerar si no has arrancado el coche");
            }
            
        }
        public void Frenar()
        {
            this.VelocidadActual -= 20;
            if (this.VelocidadActual < 0)
            {
                this.VelocidadActual = 0;
            }
            
        }
        public void Girar()
        {
            if (this.Direccion == "Norte")
            {
                this.Direccion = "Este";
            }
            else if (this.Direccion == "Este")
            {
                this.Direccion = "Sur";
            }
            else if (this.Direccion == "Sur")
            {
                this.Direccion = "Oeste";
            }
            else if (this.Direccion == "Oeste")
            {
                this.Direccion = "Norte";
            }
            
        }

        public override string ToString()
        {
            return (this.Marca + " " + this.Modelo + ", Velocidad actual: " + 
                this.VelocidadActual + ", Velocidad maxima: " + this.VelocidadMaxima + 
                ", Dirección: " + this.Direccion);
        }
    }
    
}
