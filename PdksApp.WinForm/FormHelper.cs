using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PdksApp.WinForm
{
    public static class FormHelper
    {
        public static DataGridViewCheckBoxColumn CheckBoxColumn()
        {
            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn
            {
                Name = "Select",
                HeaderText = "Seç",
                Width = 15,
                ReadOnly = false,
                TrueValue = true,
                FalseValue = false,
            };
            return column;
        }
        public static void Log(CardMenu cardMenu)
        {
            cardMenu.richTextBox1.Text += "Card Menu Form Yüklendi.";
        }
        public static void DataGridOptions(GridControl gridControl)
        {
            

        }
        public static RepositoryItemComboBox DeviceWorkType(RepositoryItemComboBox repositoryItemComboBox)
        {
            repositoryItemComboBox.Items.Add("Çalışma Yok");
            repositoryItemComboBox.Items.Add("Veri Aktarım");
            repositoryItemComboBox.Items.Add("Tüm Bilgileri Sil");
            repositoryItemComboBox.Items.Add("Kayıtları Getir");
            return repositoryItemComboBox;
        }
    }
}
