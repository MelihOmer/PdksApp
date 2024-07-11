namespace PdksApp.WinForm
{
    public class User
    {
        public User(string nameSurname,string cardNo,string tckNo)
        {
            NameSurname = nameSurname;
            CardNo = cardNo;
            TcKimlikNo = tckNo;
        }
        public User()
        {

        }
        public int Id { get; set; }
        public string TcKimlikNo { get; set; }
        public string NameSurname { get; set; }
        public string CardNo { get; set; }
        public bool Status { get; set; } = true;
        public override string ToString()
        {
            return Id.ToString() + NameSurname + CardNo;
        }
    }
}
