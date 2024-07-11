using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace PdksApp.WinForm.Helper
{
    public class CustomUserList
    {
        public List<CustomUserList> CustomUserLists { get; set; }
        public CustomUserList()
        {

        }
        [DisplayName("Seç")]
        public bool Select { get; set; }
        [DisplayName("Personel Kodu")]
        public int Id { get; set; }
        [DisplayName("Tc Kimlik No")]
        public string TckNo { get; set; }
        [DisplayName("Ad Soyad")]
        public string NameSurname { get; set; }
        [DisplayName("Kart No")]
        public string CardNo { get; set; }
        [DisplayName("Aktif")]
        public bool Status { get; set; }

        public List<CustomUserList> Mapping(List<User> users)
        {
            CustomUserLists = users.Select(U => new CustomUserList
            {
                Select = false,
                Id = U.Id,
                TckNo = U.TcKimlikNo,
                CardNo = U.CardNo,
                NameSurname = U.NameSurname,
                Status = U.Status
            }).ToList();
            return CustomUserLists;
        }
    }
}
