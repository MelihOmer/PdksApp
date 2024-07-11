using PdksApp.WinForm.DeviceHelper;
using PdksApp.WinForm.UserHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using zkemkeeper;

namespace PdksApp.WinForm
{
    public partial class CardMenu : Form
    {
        List<DeviceInfo> _deviceList;
        UserManager _userManager;
        List<DeviceManager> _deviceManagers;
        DeviceInfo _deviceInfo;
        public CardMenu()
        {
            InitializeComponent();

            _deviceList = new List<DeviceInfo>();
            _userManager = new UserManager();
            _deviceInfo = new DeviceInfo();
            _deviceList = _deviceInfo.DeviceList();
            _deviceManagers = new List<DeviceManager>();
            
            foreach (var device in _deviceList)
            {
                _deviceManagers.Add(new DeviceManager(device, new CZKEMClass()));
            }
            RefreshDataGrid();

        }
        private void RefreshDataGrid()
        {
            dataGridView2.DataSource = _deviceList.ToList();
        }

        private void CardMenu_Load(object sender, EventArgs e)
        {
            FormHelper.Log(this);
            gridControl1.DataSource = _deviceList;
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns.Add(FormHelper.CheckBoxColumn());
            dataGridView1.DataSource = _userManager.GetUsers();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Select"].Index && e.RowIndex >= 0)
                dataGridView1.EndEdit();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name != "Select")
                e.Cancel = true;
        }



        private async void btnConnectAll_Click(object sender, EventArgs e)
        {
            await ConnectedAllDevices();
        }
        private async Task ConnectedAllDevices()
        {
            foreach (var deviceManager in _deviceManagers)
            {
                if (await deviceManager.Connect())
                {
                    Log($"{deviceManager.DeviceInfo.DeviceName} - Bağlantı Kuruldu.");
                }
                else
                    Log($"{deviceManager.DeviceInfo.DeviceName} - Bağlantı Kurulamadı.");
            }
            RefreshDataGrid();
        }
        private void Log(string log)
        {
            richTextBox1.Text += $"\nLogDate = {DateTime.Now} - {log}\n";
            // listBox1.Items.Add($"{DateTime.Now} - {log}");
        }
        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                DeviceInfo currentDevice = dataGridView2.CurrentRow.DataBoundItem as DeviceInfo;
                var selectedDevice = _deviceManagers.Find(d => d.DeviceInfo.IpAdress == currentDevice.IpAdress && d.DeviceInfo.Port == currentDevice.Port);
                if (selectedDevice!= null)
                {
                    Log($"{selectedDevice.DeviceInfo.DeviceName} - Bağlantı Kurulumu Başladı.");
                   if(await selectedDevice.Connect())
                        Log($"{selectedDevice.DeviceInfo.DeviceName} - Bağlantı Kuruldu.");
                   else
                        Log($"{selectedDevice.DeviceInfo.DeviceName} - Bağlantı Kurulamadı.");
                }
            }
            RefreshDataGrid();
        }

        private void btnSelectedUsersSendDevice_Click(object sender, EventArgs e)
        {
            List<User> selectedUser = new List<User>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Select"].Value);
                if (isSelected)
                {
                    User user = row.DataBoundItem as User;
                    selectedUser.Add(user);
                }
            }
            foreach (var item in _deviceManagers)
            {
                if (item.DeviceInfo.Status)
                {
                    foreach (var user in selectedUser)
                    {
                        Log($"{user.NameSurname} Kullanıcısı için {item.DeviceInfo.DeviceName} Cihazına gönderim başladı.");
                        if (item.SetUserFromDevice(user))
                            Log($"{user.NameSurname} Kullanıcısı için {item.DeviceInfo.DeviceName} Cihazına gönderim Başarılı.");
                        else
                            Log($"{user.NameSurname} Kullanıcısı için {item.DeviceInfo.DeviceName} Cihazına gönderim Başarısız.");
                    }
                }
                
            }
            dataGridView3.DataSource = selectedUser;
        }
    }
}
