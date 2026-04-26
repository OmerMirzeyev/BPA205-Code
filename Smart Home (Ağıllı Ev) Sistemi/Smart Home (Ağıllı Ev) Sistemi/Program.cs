using Smart_Home__Ağıllı_Ev__Sistemi.Interface;
using Smart_Home__Ağıllı_Ev__Sistemi.Models;

namespace Smart_Home__Ağıllı_Ev__Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartLight smartLight = new SmartLight { DeviceName = "Lampa", Brightness = 40};
            SmartAC smartAC = new SmartAC { DeviceName = "Air condinater",Temperature= 70};
            SmartDoor smartDoor = new SmartDoor { DeviceName = "Door", IsLocked = "Locked" };
            List<IDevice> device = new List<IDevice>
            {
                smartLight,
                smartAC,
                smartDoor
            };
            foreach (var item in device)
            {
                item.TurnOff();
            }
            Console.WriteLine("=====================================================================");
            smartLight.TurnOff();
            smartAC.TurnOn();
            smartDoor.TurnOn();
            Console.WriteLine("=====================================================================");
            smartLight.ShowStatus();
            smartAC.ShowStatus();
            smartDoor.ShowStatus();
            Console.WriteLine("=====================================================================");
            smartLight.PerformAction();
            smartAC.PerformAction();
            smartDoor.PerformAction();
        }
    }
}
