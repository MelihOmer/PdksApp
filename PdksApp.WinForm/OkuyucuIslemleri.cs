using PdksApp.Bussines.Abstract;
using PdksApp.WinForm.Dtos;
using PdksApp.WinForm.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdksApp.WinForm
{
    public partial class OkuyucuIslemleri : UserControl
    {

        readonly IDeviceInfoService _deviceInfoService;
        readonly IUserService _userService;
        public List<CustomReaderList> _connectedDevices = new List<CustomReaderList>();
        bool workCancelled = false;
        public OkuyucuIslemleri(IDeviceInfoService deviceInfoService, IUserService userService)
        {
            _deviceInfoService = deviceInfoService;
            _userService = userService;
            InitializeComponent();
        }

        private void OkuyucuIslemleri_Load(object sender, EventArgs e)
        {
            DeviceListForDataGrid();
            UserListForDataGrid();
        }
        public void DeviceListForDataGrid()
        {
            CustomReaderList readerList = new CustomReaderList();
            var list = readerList.Mapping(_deviceInfoService.GetAll());
            gridControlDevice.DataSource = list;
        }

        public void UserListForDataGrid()
        {
            CustomUserList userList = new CustomUserList();
            var list = userList.Mapping(_userService.GetAll());
            userGridControl.DataSource = list;
        }
        public List<CustomReaderList> SelectedDevicesForGrid()
        {
            gridViewDevice.PostEditor();
            tabEvents.Show();
            var deviceList = gridViewDevice.DataSource as List<CustomReaderList>;
            var handleSelectedDevice = deviceList.Where(d => d.Select);
            return handleSelectedDevice.ToList();
        }
        public List<CustomUserList> SelectedUsersForGrid()
        {
            userGrid.PostEditor();
            tabEvents.Show();
            var userList = userGrid.DataSource as List<CustomUserList>;
            var handleSelectedUsers = userList.Where(u => u.Select);
            return handleSelectedUsers.ToList();
        }

        public void EventLog(string log)
        {
            txtEventLog.Text += $"\n {DateTime.Now} =>  {log}";
        }
        public async Task ConnectSelectedDevices()
        {

            var handleSelectedDevice = SelectedDevicesForGrid();
            _connectedDevices.Clear();
            foreach (var device in handleSelectedDevice)
            {
                await Task.Delay(150);
                EventLog($"{device.DeviceName} Cihaza Bağlanılıyor...");
                bool connectedState = await device.ConnectDeviceAsync();
                if (connectedState)
                {
                    if (!_connectedDevices.Any(d => d.Id == device.Id))
                    {
                        _connectedDevices.Add(device);
                    }                    
                }
                gridViewDevice.RefreshData();
                EventLog($"{device.DeviceName} Bağlantı Durumu = {connectedState}");
            }
        }

        public async Task DisconnectSelectedDevices()
        {
            var handleSelectedDevices = SelectedDevicesForGrid();
            foreach (var device in handleSelectedDevices)
            {
                await Task.Delay(150);
                EventLog($"{device.DeviceName} Cihaza Bağlantısı Kesiliyor...");
                bool connectedState = await device.DisconnectDeviceAsync();
                if (connectedState)
                {
                    _connectedDevices.Remove(device);
                }
                gridViewDevice.RefreshData();
                EventLog($"{device.DeviceName} Bağlantı Durumu = {connectedState}");
            }
        }
        public async Task SendToUsersForDevice(bool checkedPassword)
        {
            var userList = SelectedUsersForGrid();
            if (userList.Count <= 0 || _connectedDevices.Count <= 0)
            {
                EventLog("Seçili Cihaz veya Kullanıcı Yok.");
            }
            else
            {
                foreach (var device in _connectedDevices)
                {
                    EventLog($"\n {device.DeviceName} - Cihaz Bağlatısı Kontrol Ediliyor.");
                    if (!workCancelled)
                    {
                        int index = 0;
                        foreach (var user in userList)
                        {
                            index++;
                            EventLog($"{user.Id} - {user.NameSurname} Personel {user.CardNo} Kart No İle -  {device.DeviceName} Cihaza Gönderiliyor... {index}/{userList.Count}");
                            await device.SendToUserForSelectedDevice(user,checkedPassword);
                            EventLog($"{user.Id} - {user.NameSurname} - {device.DeviceName} Gönderim Başarılı... {index}/{userList.Count}  \n");
                        }
                    }
                }
            }
        }

        public void CancelOperation()
        {
           workCancelled = true;
        }

        public void GetUsersFromDevice()
        {
            List<UserListFromDevice> users = new List<UserListFromDevice>();
            if (_connectedDevices.Count < 0)
            {
                EventLog($"Bağlantı Kurulan Cihaz Yok");
            }
            else
            {
                EventLog($"Cihaz Etkinleştirildi İşlem Yapılıyor...");

                foreach (var device in _connectedDevices)
                {
                  users = device.GetUsersFromDevice();
                }
                tabReaderEvents.Show();
                gridControlDevicePerson.DataSource = users;
            }
        }
    }
}
