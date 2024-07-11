using PdksApp.WinForm.DeviceHelper;
using PdksApp.WinForm.Dtos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using zkemkeeper;

namespace PdksApp.WinForm.Helper
{
    public class CustomReaderList
    {
        public List<CustomReaderList> CustomReaderLists { get; set; }
        public CustomReaderList()
        {

        }

        [DisplayName("Seç")]
        public bool Select { get; set; }
        [DisplayName("Cihaz Kodu")]
        public int Id { get; set; }
        [DisplayName("Cihaz Adı")]
        public string DeviceName { get; set; }
        [DisplayName("Ip Adresi")]
        public string IpAdress { get; set; }
        [DisplayName("Port")]
        public int Port { get; set; }
        [DisplayName("Bağlantı Durumu")]
        public bool ConnectionStatus { get; set; }
        [Browsable(false)]
        public CZKEMClass DeviceSdk { get; set; }


        public List<CustomReaderList> Mapping(List<DeviceInfo> infos)
        {
            CustomReaderLists = infos.Select(d => new CustomReaderList
            {
                Select = false,
                Id = d.Id,
                DeviceName = d.DeviceName,
                IpAdress = d.IpAdress,
                Port = d.Port,
                ConnectionStatus = false,
                DeviceSdk = new CZKEMClass()
            }).ToList();
            return CustomReaderLists;
        }

        public async Task<bool> ConnectDeviceAsync()
        {
            await Task.Run(() =>
            {
                ConnectionStatus = DeviceSdk.Connect_Net(IpAdress, Port);

            });
            return ConnectionStatus;
        }

        public async Task<bool> DisconnectDeviceAsync()
        {
            await Task.Run(() =>
            {
                DeviceSdk.Disconnect();
                ConnectionStatus = false;
            });
            return ConnectionStatus;
        }

        public async Task<bool> SendToUserForSelectedDevice(CustomUserList user, bool checkedPassword)
        {
            bool sendState = false;
            await Task.Run(() =>
             {
                 for (int i = 0; i < 30; i++)
                 {
                     bool setCard = DeviceSdk.SetStrCardNumber(user.CardNo);
                     if (setCard)
                     {
                         string passWord = "";
                         if (checkedPassword)
                         {
                             passWord = user.TckNo.Substring(0, 5);
                             sendState = DeviceSdk.SetUserInfo(1, user.Id, user.NameSurname, passWord, 0, user.Status);
                         }
                         else
                             sendState = DeviceSdk.SetUserInfo(1, user.Id, user.NameSurname, passWord, 0, user.Status);
                     }
                 }
             });

            return sendState;
        }
        //public async Task<bool> GetConnectionState()
        //{
        //    bool connState = false;
        //    await Task.Run(() =>
        //     {

        //         int errorCode = 0;
        //         DeviceSdk.GetConnectStatus(ref errorCode);
        //         if (errorCode != 0)
        //         {
        //             connState = true;
        //             //stateMessage = $"Cihaz Bağlantısında Sorun Var Hata Kodu = {errorCode}";
        //         }
        //         //$"Cihaz Bağlantı Kontrol Başarılı";

        //     });

        //    return connState;
        //}
        public bool CancelOperation()
        {
            return DeviceSdk.CancelOperation();
        }
        public List<UserListFromDevice> GetUsersFromDevice()
        {
            string enrollId = "";
            string nameSurname = "";
            string password = "";
            bool enabled = false;
            int privilege = 0, enroll = 0;
            string cardNo = "";
            List<UserListFromDevice> userList = new List<UserListFromDevice>();
            while (DeviceSdk.GetAllUserInfo(1, ref enroll, ref nameSurname, ref password, ref privilege, ref enabled))
            {
                DeviceSdk.GetStrCardNumber(out cardNo);
                userList.Add(new UserListFromDevice { Id = enroll, NameSurname = nameSurname, Password = password, Status = enabled, CardNo = cardNo, DeviceName = DeviceName });
            }
            return userList;


        }
    }

}
