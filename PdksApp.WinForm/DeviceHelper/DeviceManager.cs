using PdksApp.WinForm.Contrat;
using System;
using System.Threading.Tasks;
using zkemkeeper;

namespace PdksApp.WinForm.DeviceHelper
{
    public class DeviceManager : IDeviceManager
    {
        private int machineNumber = 1;
        CZKEMClass _deviceSdk;
        public DeviceInfo DeviceInfo { get; set; }
        public event Action<string, int, int, int, DateTime, int, string> OnAttendance;

        public DeviceManager(DeviceInfo deviceInfo, CZKEMClass deviceSdk)
        {
            DeviceInfo = deviceInfo;
            _deviceSdk = deviceSdk;
        }

        public async Task<bool> Connect()
        {
            await Task.Run(() =>
            {
                bool isConnected = _deviceSdk.Connect_Net(DeviceInfo.IpAdress, DeviceInfo.Port);
                DeviceInfo.Status = isConnected;
                OnAttTransaction();
            });
            return DeviceInfo.Status;
        }
        public void OnAttTransaction()
        {
            _deviceSdk.OnAttTransactionEx += OnAttTransactionEx;
            _deviceSdk.EnableDevice(1, false);
            _deviceSdk.RegEvent(1, 65535);
            _deviceSdk.EnableDevice(1, true);
        }

        public bool Disconnect()
        {
            try
            {
                _deviceSdk.Disconnect();
                return true;
            }
            catch (System.Exception)
            {
                return false;
                throw;
            }
        }
        private void OnAttTransactionEx(string enrollNumber, int isInValid, int attState, int verifyMethod, int year, int month, int day, int hour, int minute, int second, int workCode)
        {
            DateTime logTime = new DateTime(year, month, day, hour, minute, second);
            OnAttendance?.Invoke(enrollNumber, isInValid, attState, verifyMethod, logTime, workCode, DeviceInfo.IpAdress);
        }
        public bool SetUserFromDevice(User user)
        {
            bool State = false;
            for (int i = 0; i < 10; i++)
            {
                bool setCard = _deviceSdk.SetStrCardNumber(user.CardNo);
                if (setCard)
                {
                   State =  _deviceSdk.SetUserInfo(1, user.Id, user.NameSurname, "", 0, user.Status);
                }
                _deviceSdk.RefreshData(1);
            }

            return State;

            //bool isSaved = _deviceSdk.SetUserInfo(1, user.Id, user.NameSurname, "", 0, user.Status);
            //if (isSaved)
            //{
            //    isSetCard = _deviceSdk.SetStrCardNumber(user.CardNo);
            //}

        }
    }
}
