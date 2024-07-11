using DevExpress.XtraEditors;
using PdksApp.Bussines.Abstract;
using System.Windows.Forms;

namespace PdksApp.WinForm
{
    public partial class PersonAddOrUpdate : Form
    {
        KullaniciTanimlari _kullaniciTanimlari;
        User _user;
        IUserService _userService;
        public PersonAddOrUpdate(IUserService userService,KullaniciTanimlari kullaniciTanimlari ,User user = null)
        {
            _userService = userService;
            _user = user;
            _kullaniciTanimlari = kullaniciTanimlari;
            InitializeComponent();


        }

        private void btnPersonSaveCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnPersonSave_Click(object sender, System.EventArgs e)
        {
            if (_user == null)
            {
                if (!string.IsNullOrEmpty(txtNameSurname.Text) &&!string.IsNullOrWhiteSpace(txtNameSurname.Text))
                {
                    User user = new User(txtNameSurname.Text, txtCardNo.Text,txtTckNo.Text);
                    _userService.Add(user);
                    XtraMessageBox.Show($"{user.NameSurname} Personeli Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _kullaniciTanimlari.PersonList();
                    this.Close();
                };
            }
            else if (_user != null)
            {
                _user.NameSurname = txtNameSurname.Text;
                _user.CardNo = txtCardNo.Text;
                _user.TcKimlikNo = txtTckNo.Text;
                _userService.Update(_user);
                XtraMessageBox.Show($"{_user.NameSurname} Personeli Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _kullaniciTanimlari.PersonList();
                this.Close();
            }

        }

        private void PersonAddOrUpdate_Load(object sender, System.EventArgs e)
        {

            if (_user != null)
            {
                txtPersonId.Text = _user.Id.ToString();
                txtNameSurname.Text = _user.NameSurname;
                txtCardNo.Text = _user.CardNo;
                txtTckNo.Text = _user.TcKimlikNo;
                lblTitle.Text = "Personel Bilgi Güncelle";
            }

        }
    }
}
