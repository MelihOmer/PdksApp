using DevExpress.XtraEditors;
using PdksApp.Bussines.Abstract;
namespace PdksApp.WinForm
{
    public partial class OkuyucuTanimlari : XtraUserControl
    {
        readonly IDeviceInfoService _deviceInfoService;
        public OkuyucuTanimlari(IDeviceInfoService deviceInfoService)
        {
            _deviceInfoService = deviceInfoService;
            InitializeComponent();
        }

        private void OkuyucuTanimlari_Load(object sender, System.EventArgs e)
        {
            DeviceListForDataGrid();
        }
        public void DeviceListForDataGrid()
        {
            deviceGridControl.DataSource = _deviceInfoService.GetAll();
        }
    }
}
