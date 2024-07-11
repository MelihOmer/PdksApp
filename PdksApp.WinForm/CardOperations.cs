using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using PdksApp.Bussines.Abstract;
using PdksApp.DAL;
using PdksApp.WinForm.DeviceHelper;
using System;
using System.Windows.Forms;

namespace PdksApp.WinForm
{
    public partial class CardOperations : RibbonForm
    {
        KullaniciTanimlari _kullaniciTanimlari;
        OkuyucuTanimlari _okuyucuTanimlari;
        OkuyucuIslemleri _okuyucuIslemleri;
        AppDbContext _appDbContext;
        IUserService _userService;
        IDeviceInfoService _deviceInfoService;
        string workType = "";


        public CardOperations(AppDbContext appDbContext, IUserService userService, IDeviceInfoService deviceInfoService)
        {

            _appDbContext = appDbContext;
            _userService = userService;
            _deviceInfoService = deviceInfoService;
            _kullaniciTanimlari = new KullaniciTanimlari(_userService);
            _okuyucuTanimlari = new OkuyucuTanimlari(_deviceInfoService);
            _okuyucuIslemleri = new OkuyucuIslemleri(_deviceInfoService,_userService);
            InitializeComponent();

        }



        private void CardOperations_Load(object sender, EventArgs e)
        {

            ShowUserControl(_okuyucuIslemleri);
            repositoryItemComboBox1 = FormHelper.DeviceWorkType(repositoryItemComboBox1);
        }
        private void ShowUserControl(UserControl userControl)
        {

            panelControl1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(userControl);
        }

        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {

            var selectedPage = ribbonControl1.SelectedPage;
            if (selectedPage == PageReader)
            {
                ShowUserControl(_okuyucuIslemleri);
                _okuyucuIslemleri.DeviceListForDataGrid();
                _okuyucuIslemleri.UserListForDataGrid();
            }
                
            else if (selectedPage == PageReaderManager)
                ShowUserControl(_okuyucuTanimlari);
            else if (selectedPage == PageUserManager)
                ShowUserControl(_kullaniciTanimlari);

        }

        #region UserOperations
        private void btnPersonList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _kullaniciTanimlari.PersonList();
        }

        private void btnPersonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedUser = _kullaniciTanimlari.userGrid.GetFocusedRow() as User;
            var result = XtraMessageBox.Show($"({selectedUser.NameSurname})  Kalıcı Olarak Silinecek Eminmisiniz ?", "Kullancı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _userService.Remove(selectedUser);
            }
            _kullaniciTanimlari.PersonList();
        }

        private void btnPersonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonAddOrUpdate personAddOrUpdate = new PersonAddOrUpdate(_userService, _kullaniciTanimlari);
            personAddOrUpdate.ShowDialog();

        }

        private void btnPersonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedUser = _kullaniciTanimlari.userGrid.GetFocusedRow() as User;
            PersonAddOrUpdate personAddOrUpdate = new PersonAddOrUpdate(_userService, _kullaniciTanimlari, selectedUser);
            personAddOrUpdate.ShowDialog();
        }
        #endregion

        private void barBtnDeviceList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _okuyucuIslemleri.DeviceListForDataGrid();
        }

        private void barBtnDeviceAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeviceAddOrUpdate deviceAddOrUpdate = new DeviceAddOrUpdate(_deviceInfoService, _okuyucuTanimlari);
            deviceAddOrUpdate.ShowDialog();
        }

        private void barBtnDeviceEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedDevice = _okuyucuTanimlari.deviceGrid.GetFocusedRow() as DeviceInfo;
            DeviceAddOrUpdate deviceAddOrUpdate = new DeviceAddOrUpdate(_deviceInfoService, _okuyucuTanimlari, selectedDevice);
            deviceAddOrUpdate.ShowDialog();
        }

        private void barBtnDeviceDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //as DeviceInfo
            var selectedDevice = (DeviceInfo)_okuyucuTanimlari.deviceGrid.GetFocusedRow();
            var result = XtraMessageBox.Show($"({selectedDevice.DeviceName})  Kalıcı Olarak Silinecek Eminmisiniz ?", "Okuyucu Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                _deviceInfoService.Remove(selectedDevice);
            _okuyucuTanimlari.DeviceListForDataGrid();
        }

        private void btnGetDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _okuyucuIslemleri.DeviceListForDataGrid();
        }

        private async void btnConnectedDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await _okuyucuIslemleri.ConnectSelectedDevices();
        }

        private async void btnDisconnectedDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await _okuyucuIslemleri.DisconnectSelectedDevices();
        }

        private async void btnCardWorkStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (workType == "Veri Aktarım")
            {
                
               await _okuyucuIslemleri.SendToUsersForDevice(checkPassword.Checked);
            }
            else if(workType == "Kayıtları Getir")
            {
                _okuyucuIslemleri.GetUsersFromDevice();
            }
        }

        private void repositoryItemComboBox1_EditValueChanged(object sender, EventArgs e)
        {

            var edit = sender as ComboBoxEdit;
            if (edit != null)
            {
                workType= edit.EditValue.ToString();
                
            }
        }

        private void btnDeviceWorkStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _okuyucuIslemleri.CancelOperation();
        }
    }
}