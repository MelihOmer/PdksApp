using System.Collections.Generic;
namespace PdksApp.WinForm.DeviceHelper
{
    public class DeviceInfo
    {
        List<DeviceInfo> _devices;
        public DeviceInfo()
        {
            
        }
        public DeviceInfo(string ipAdress,int port,string deviceName)
        {
            IpAdress = ipAdress;
            Port = port;
            DeviceName = deviceName;
        }
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string IpAdress { get; set; }
        public int Port { get; set; }
        public bool Status { get; set; } = true;
        public override string ToString()
        {
            return DeviceName;
        }
        public  List<DeviceInfo> DeviceList()
        {
            _devices = new List<DeviceInfo>();
            _devices.Add(new DeviceInfo("192.168.1.105", 4370, "A - Giriş Cihazı"));
            _devices.Add(new DeviceInfo("10.212.96.18", 4370, "B - Giriş Cihazı"));
            return _devices;
        }
    }
}
