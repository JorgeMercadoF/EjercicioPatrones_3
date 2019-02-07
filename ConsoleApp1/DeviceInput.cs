using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DeviceInput : IComponent
    {
        private string Fabricante { get; set; }
        private string Modelo { get; set; }
        private double Precio { get; set; }
        private string TipoConector { get; set; }
        private int[] PuertosOk;

        public DeviceInput(string fabricante, string modelo, double precio, string tipoConector, int[] puertosOk)
        {
            this.Fabricante = fabricante;
            this.Modelo = modelo;
            this.Precio = precio;
            this.TipoConector = tipoConector;
            this.PuertosOk = puertosOk;
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
