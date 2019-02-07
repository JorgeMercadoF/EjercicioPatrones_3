using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Program
    {
        public static void Main()
        {
            //Componentes
            int [] puertosTeclado = { 12, 52 };
            int [] puertosPantalla = { 12, 52 };
            DeviceInput tecladoBase = new DeviceInput("HP", "T190", 30, "PS2", puertosTeclado);
            DeviceOutput pantallaBase = new DeviceOutput("HP", "L190", 150, "toner", puertosPantalla);
            CentralUnit cpuBase = new CentralUnit("Intel", "I7 7700", 290);
            DeviceInput tecladoTop = new DeviceInput("HP", "T290", 60, "PS2", puertosTeclado);
            DeviceOutput pantallaTop = new DeviceOutput("HP", "L290", 250, "toner", puertosPantalla);
            CentralUnit cpuTop = new CentralUnit("Intel", "I8 7700", 490);
            List<DeviceInput> inputs = new List<DeviceInput>();
            List<DeviceOutput> outputs = new List<DeviceOutput>();

            //Montar Ordenador base
            inputs.Add(tecladoBase);
            outputs.Add(pantallaBase);
            Computer OrdenadorBase = new Computer(inputs, outputs, cpuBase);
            Console.WriteLine("Precio Base: " + OrdenadorBase.CalculateCost() + "\n");

            //Gestionar componentes
            OrdenadorBase.AddInput("HP", "T220", 50, "PS2", puertosTeclado);
            OrdenadorBase.AddOutput("HP", "L220", 190, "toner", puertosPantalla);
            Console.WriteLine("Precio tras añadir 2 componentes Extra: " + OrdenadorBase.CalculateCost() + "\n");

            OrdenadorBase.DelDeviceInput(tecladoBase);
            OrdenadorBase.DelDeviceOutput(pantallaBase);
            Console.WriteLine("Precio tras eliminar 2 componentes Base: " + OrdenadorBase.CalculateCost() + "\n");

            OrdenadorBase.AddDeviceInput(tecladoTop);
            OrdenadorBase.AddDeviceOutput(pantallaTop);
            OrdenadorBase.updateCentralUnit(cpuTop);
            Console.WriteLine("Precio tras añadirle la gama Top:" + OrdenadorBase.CalculateCost() + "\n" );

            OrdenadorBase.DelInput("HP", "T220", 50);
            OrdenadorBase.DelOutput("HP", "L220", 190);
            Console.WriteLine("Precio tras eliminar 2 componentes Extra: " + OrdenadorBase.CalculateCost() + "\n");

            Console.Read();

        }
    }
}
