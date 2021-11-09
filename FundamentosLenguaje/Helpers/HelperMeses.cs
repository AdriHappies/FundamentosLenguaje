using FundamentosLenguaje.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosLenguaje.Helpers
{
    public class HelperMeses
    {
        public List<TemperaturaMes> Meses { get; set; }
        public HelperMeses()
        {
            //instanciamos la coleccion de meses
            this.Meses = new List<TemperaturaMes>();
            Random random = new Random();
            for (int i = 1; i <= 12; i++)
            {
                TemperaturaMes mes = new TemperaturaMes();
                mes.Maxima = random.Next(12, 45);
                mes.Minima = random.Next(-10, 11);
                mes.Mes = "Mes " + i;
                this.Meses.Add(mes);
            }
        }

        //metodo para obtener la maxima anual
        public int GetMaximaAnual()
        {
            int maxima = 0;
            foreach (TemperaturaMes mes in this.Meses)
            {
                maxima = Math.Max(maxima, mes.Maxima);
            }
            return maxima;
        }

        public int GetMinimaAnual()
        {
            int minima = 30;
            foreach (TemperaturaMes mes in this.Meses)
            {
                minima = Math.Min(minima, mes.Minima);
            }
            return minima;
        }

        public int GetMediaAnual()
        {
            int media = 0;
            foreach (TemperaturaMes mes in this.Meses)
            {
                media += mes.GetMedia();
            }
            return media/ this.Meses.Count;
        }
    }
}
