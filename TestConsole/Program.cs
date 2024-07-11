using zkemkeeper;


CZKEMClass cZKEMClass = new CZKEMClass();

bool isConnected = cZKEMClass.Connect_Net("192.168.1.105", 4370);

int enrollId = 0, privilege = 0;
string name = "", password = "", CardNo = "";
bool enabled = false;




User user = new()
{
    Id = 1,
    Name = "MOK",
    CardNo = "0011284455"
};
bool isSaved = false;
bool isAdded = false;
for (int i = 0; i < 10; i++)
{
    
}
if (isConnected)
{
    //isAdded = cZKEMClass.SetUserInfo(1, user.Id, user.Name, "", 0, true);
    //isSaved = cZKEMClass.SetStrCardNumber(user.CardNo);
    bool cardAdded = cZKEMClass.SetStrCardNumber(user.CardNo);
    if (cardAdded)
    {
        cZKEMClass.SetUserInfo(1, user.Id, user.Name, "", 0, true);

    }
    cZKEMClass.RefreshData(1);
}
while (true)
{

    cZKEMClass.GetAllUserInfo(1, ref enrollId, ref name, ref password, ref privilege, ref enabled);
    cZKEMClass.GetStrCardNumber(out CardNo);
    Console.WriteLine($"Kullanıcı Id = {enrollId}, NameSurname ={name}, CardNo = {CardNo}, Enabled = {enabled.ToString()}");
    break;
}




class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string CardNo { get; set; }
}
