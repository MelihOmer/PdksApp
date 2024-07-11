using PdksApp.Bussines.Abstract;
using System;
using System.Windows.Forms;

namespace PdksApp.WinForm
{
    public partial class KullaniciTanimlari : UserControl
    {
        readonly IUserService _userService;
        public KullaniciTanimlari(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
            
        }

        private void KullaniciTanimlari_Load(object sender, EventArgs e)
        {
            PersonList();
        }
        public void PersonList()
        {
            userGridControl.DataSource = _userService.GetAll();
        }
    }
}
