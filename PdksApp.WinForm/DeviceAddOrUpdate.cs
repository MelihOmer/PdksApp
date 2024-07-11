using DevExpress.XtraEditors;
using PdksApp.Bussines.Abstract;
using PdksApp.WinForm.DeviceHelper;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace PdksApp.WinForm
{
    public partial class DeviceAddOrUpdate : Form
    {
        readonly IDeviceInfoService _deviceInfoService;
        DeviceInfo _deviceInfo;
        OkuyucuTanimlari _okuyucuTanimlari;
        public DeviceAddOrUpdate(IDeviceInfoService deviceInfoService,OkuyucuTanimlari okuyucuTanimlari,DeviceInfo deviceInfo=null)
        {
            _deviceInfoService = deviceInfoService;
            _deviceInfo = deviceInfo;
            _okuyucuTanimlari = okuyucuTanimlari;
            InitializeComponent();
        }
        private void DeviceAddOrUpdate_Load(object sender, System.EventArgs e)
        {
            if (_deviceInfo != null)
            {
                txtDeviceId.Text = _deviceInfo.Id.ToString();
                txtDeviceName.Text = _deviceInfo.DeviceName;
                txtDeviceIpAdress.Text = _deviceInfo.IpAdress;
                txtPortNo.Text = _deviceInfo.Port.ToString();
                lblTitle.Text = "Okuyucu Bilgi Düzenle";
                checkStatus.Checked = _deviceInfo.Status;
            }
        }
        private void btnDeviceSaveCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void btnDeviceSave_Click(object sender, System.EventArgs e)
        {
            if (_deviceInfo == null)
                DeviceAdd();

            else if (_deviceInfo != null)
                DeviceUpdate();
        }



        private void DeviceAdd()
        {
            DeviceInfo deviceInfo = new DeviceInfo(txtDeviceIpAdress.Text,int.Parse(txtPortNo.Text),txtDeviceName.Text);
            _deviceInfoService.Add(deviceInfo);
            XtraMessageBox.Show($"{deviceInfo.DeviceName} Okuyucu Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _okuyucuTanimlari.DeviceListForDataGrid();
            this.Close();
        }
        private void DeviceUpdate()
        {
            _deviceInfo.Id = int.Parse(txtDeviceId.Text);
            _deviceInfo.DeviceName = txtDeviceName.Text;
            _deviceInfo.IpAdress = txtDeviceIpAdress.Text;
            _deviceInfo.Port = int.Parse(txtPortNo.Text);
            _deviceInfo.Status = checkStatus.Checked;
            _deviceInfoService.Update(_deviceInfo);
            
            XtraMessageBox.Show($"{_deviceInfo.DeviceName} Okuyucu Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _okuyucuTanimlari.DeviceListForDataGrid();
            this.Close();

        }
    }
}
