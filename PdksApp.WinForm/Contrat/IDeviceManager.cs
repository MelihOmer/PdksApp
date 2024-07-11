using System.Threading.Tasks;

namespace PdksApp.WinForm.Contrat
{
    public interface IDeviceManager
    {
        Task<bool> Connect();
        bool Disconnect();
    }
}
