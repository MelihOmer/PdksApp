using Autofac;
using PdksApp.DAL;
using PdksApp.WinForm.DeviceHelper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using zkemkeeper;

namespace PdksApp.WinForm
{
    public partial class MainForm : Form
    {
        readonly AppDbContext _dbContext;
        List<DeviceInfo> _deviceList;
        List<DeviceManager> _deviceManagerList;
        readonly ILifetimeScope _scope;
        public  MainForm(AppDbContext appDbContext,ILifetimeScope scope)
        {
            _scope = scope;
            _dbContext = appDbContext;
            InitializeComponent();
            
            _deviceList = new List<DeviceInfo>();
            //_deviceList.Add(new DeviceInfo("192.168.1.105", 4370, "A - Yemekhane Cihazı"));
            _deviceList.Add(new DeviceInfo("10.212.96.16", 4370, "B - Giriş Cihazı"));
            //_deviceList.Add(new DeviceInfo("10.212.96.15", 4370, "A - Giriş Cihazı"));
            RefreshDataGrid();
            _deviceManagerList = new List<DeviceManager>();
            foreach (var device in _deviceList)
            {
                _deviceManagerList.Add(new DeviceManager(device, new CZKEMClass()));
            }
            

        }
        private void voidInitializeNotifyIcon()
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.Text = "PDKS App Server";
            notifyIcon1.Visible = false;
            notifyIcon1.DoubleClick += new EventHandler(NotifyIcon_DoubleClick);
        }
        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible=false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            await ConnectedAllDevices();
        }

        

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private async void btnConnectAll_Click(object sender, EventArgs e)
        {
           await ConnectedAllDevices();
        }
        private  void RefreshDataGrid()
        {   
                dataGridView1.DataSource = _deviceList.ToList();
        }
        private void Log(string log)
        {
            rtxtLog.Text += $"\nLogDate = {DateTime.Now} - {log}\n";
           // listBox1.Items.Add($"{DateTime.Now} - {log}");
        }
        private async Task ConnectedAllDevices()
        {
            foreach (var deviceManager in _deviceManagerList)
            {
                if (await deviceManager.Connect())
                {
                    Log($"{deviceManager.DeviceInfo.DeviceName} - Bağlantı Kuruldu.");
                    deviceManager.OnAttendance += Device_OnAttendance;
                    Log($"{deviceManager.DeviceInfo.DeviceName} - İzleme Başlatıldı.");
                    
                }
                else
                    Log($"{deviceManager.DeviceInfo.DeviceName} - Bağlantı Kurulamadı.");
            }
            RefreshDataGrid();
        }

        private void Device_OnAttendance(string enrollNumber, int isInValid, int attState, int verifyMethod, DateTime logTime, int workCode, string ipAddress)
        {
            Invoke((MethodInvoker)delegate
            {
                Log($"Cihaz IP :{ipAddress}\nKullanıcı ID: {enrollNumber} \nGeçerli mi: {isInValid} \nDurum: {attState}\nDoğrulama Yöntemi: {verifyMethod}\nZaman: {logTime}\nÇalışma Kodu: {workCode}");
            });
        }

        private void btnCartMenu_Click(object sender, EventArgs e)
        {
            using (var formScope = _scope.BeginLifetimeScope())
            {
                var cardOpForm = formScope.Resolve<CardOperations>();
                cardOpForm.ShowDialog();
            }
            //CardOperations cardOperations = new CardOperations(_dbContext);
            //cardOperations.Show();
            //CardMenu cardForm = new CardMenu();
            //cardForm.ShowDialog();
        }
    }
}
