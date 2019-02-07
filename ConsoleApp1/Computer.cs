using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Computer: IComputer
    {
        //Atributos
        List<DeviceInput> deviceInputs = new List<DeviceInput>();
        List<DeviceOutput> deviceOutputs = new List<DeviceOutput>();
        CentralUnit cpu;

        private double precioInputs = 0;
        private double precioOutputs = 0;
        private double precioCpu = 0;
        private double precio = 0;
        
        //Constructor
        public Computer(List<DeviceInput> deviceInputs, List<DeviceOutput> deviceOutputs, CentralUnit cpu)
        {
            this.deviceInputs = deviceInputs;
            this.deviceOutputs = deviceOutputs;
            this.cpu = cpu;
        }

        //Metodos
        public int GetNumInputs()
        {
            return deviceInputs.Count();
        }

        public int GetNumOutputs()
        {
            return deviceOutputs.Count();
        }

        //Metodos Interfaz
        public double CalculateCost()
        {
            precioInputs = 0;
            precioOutputs = 0;
            precioCpu = 0;
            foreach (var input in deviceInputs)
            {
                precioInputs += input.GetPrecio();
            }
            foreach(var outPut in deviceOutputs)
            {
                precioOutputs += outPut.GetPrecio();
            }
            precio = precioInputs + precioOutputs + cpu.GetPrecio();
            return precio;
        }


        #region Input
        public List<DeviceInput> AddInput(string fabricante, string modelo, double precio, string tipoConector, int[] puertosOk)
        {
            deviceInputs.Add(new DeviceInput(fabricante, modelo, precio, tipoConector, puertosOk));
            return deviceInputs;
        }

        public List<DeviceInput> DelInput(string fabricante, string modelo, double precio)
        {
            if (deviceInputs.Count() == 1)
            {
                throw new Exception("Un Ordenador debe lleva un minimo de 1 Dispositivo Input");
            }
            else
            {
                foreach(var i in deviceInputs)
                {
                    if((i.GetModelo() == modelo) && (i.GetFabricante() == fabricante) && (i.GetPrecio() == precio))
                    {
                        deviceInputs.Remove(i);
                        return deviceInputs;
                    }
                }
            }

            throw new Exception("Un Ordenador debe lleva un minimo de 1 Dispositivo Input");
        }

        public List<DeviceInput> AddDeviceInput(DeviceInput deviceInput)
        {
            deviceInputs.Add(deviceInput);
            return deviceInputs;
        }

        public List<DeviceInput> DelDeviceInput(DeviceInput input)
        {
            if (deviceInputs.Count() == 1)
            {
                throw new Exception("Un Ordenador debe lleva un minimo de 1 Dispositivo Input");
            }
            else
            {
                deviceInputs.Remove(input);
                return deviceInputs;
            }
        }
        #endregion

        #region Output
        public List<DeviceOutput> AddOutput(string fabricante, string modelo, double precio, string tipoRecarga, int[] puertosOk)
        {
            deviceOutputs.Add(new DeviceOutput(fabricante, modelo, precio, tipoRecarga, puertosOk));
            return deviceOutputs;
        }

        public List<DeviceOutput> DelOutput(string fabricante, string modelo, double precio)
        {
            if (deviceOutputs.Count() == 1)
            {
                throw new Exception("Un Ordenador debe lleva un minimo de 1 Dispositivo Output");
            }
            else
            {
                foreach (var i in deviceOutputs)
                {
                    if ((i.GetModelo() == modelo) && (i.GetFabricante() == fabricante) && (i.GetPrecio() == precio))
                    {
                        deviceOutputs.Remove(i);
                        return deviceOutputs;
                    }
                }
            }

            throw new Exception("Un Ordenador debe lleva un minimo de 1 Dispositivo Output");
        }

        public List<DeviceOutput> AddDeviceOutput(DeviceOutput deviceOutput)
        {
            deviceOutputs.Add(deviceOutput);
            return deviceOutputs;
        }

        public List<DeviceOutput> DelDeviceOutput(DeviceOutput output)
        {
            if (deviceOutputs.Count() == 1)
            {
                throw new Exception("Un Ordenador debe lleva un minimo de 1 Dispositivo Output");
            }
            else
            {
                deviceOutputs.Remove(output);
                return deviceOutputs;
            }
        }
        #endregion

        public void updateCentralUnit(CentralUnit cpu)
        {
            this.cpu = cpu;
        }
    }
}
