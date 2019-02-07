using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IComputer
    {
        double CalculateCost();

        void updateCentralUnit(CentralUnit cpu);

        List<DeviceInput> AddInput(string fabricante, string modelo, double precio, string tipoConector, int[] puertosOk);
        List<DeviceInput> DelInput(string fabricante, string modelo, double precio);
        List<DeviceInput> AddDeviceInput(DeviceInput deviceInput);
        List<DeviceInput> DelDeviceInput(DeviceInput input);

        List<DeviceOutput> AddOutput(string fabricante, string modelo, double precio, string tipoRecarga, int[] puertosOk);
        List<DeviceOutput> DelOutput(string fabricante, string modelo, double precio);
        List<DeviceOutput> AddDeviceOutput(DeviceOutput deviceOutput);
        List<DeviceOutput> DelDeviceOutput(DeviceOutput deviceOutput);
    }
}
