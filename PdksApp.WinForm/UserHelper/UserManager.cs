

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PdksApp.WinForm.UserHelper
{
    public class UserManager
    {
        private static List<User> _userList;
        public List<User> UserList { get; set; }
        public UserManager()
        {
            UserList = _userList ?? GetUsers();
        }
        public  List<User> GetUsers()
        {
            //_userList = new List<User>()
            //{
            //    new User(1,"Melih Ömer Kamar","0013739355"),
            //    new User(2,"Kamar Melih","0011284455"),
            //    new User(3,"Melih Ömer","0013696347"),
            //    new User(4,"Ömer Melih","0013687104"),
            //    new User(5,"Melih Kamar","0013673455"),
            //    new User(6,"Ömer Kamar","94222257"),
            //    new User(7,"Kamar Ömer","0011079530")
            //};
            return _userList;
        }
        public void DeleteUser(User user,DialogResult dialogResult)
        {
            if (dialogResult == DialogResult.Yes)
            {
                if (_userList.Any(u=> u.Id == user.Id))
                {
                    _userList.Remove(user);
                }
            }         
        }
        public bool AddUser(User user)
        {
            if(user != null)
            {
                _userList.Add(user);
                return true;
            }
            return false;
        }
        public bool UpdateUser(User user)
        {
            if (user != null)
            {
                var oldUser = _userList.Find(u => u.Id == user.Id);
                oldUser.NameSurname = user.NameSurname;
                oldUser.CardNo = user.CardNo;
                return true;
            }
            return false;
        }
    }
}
