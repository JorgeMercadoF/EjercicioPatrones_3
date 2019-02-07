using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CentralUnit : IComponent
    {
        private string Fabricante { get; set; }
        private string Modelo { get; set; }
        private double Precio { get; set; }

        public CentralUnit(string fabricante, string modelo, double precio)
        {
            this.Fabricante = fabricante;
            this.Modelo = modelo;
            this.Precio = precio;
        }

        public string GetFabricante()
        {
            return this.Fabricante;
        }

        public string GetModelo()
        {
            return this.Modelo;
        }

        public double GetPrecio()
        {
            return this.Precio;
        }
    }
}
