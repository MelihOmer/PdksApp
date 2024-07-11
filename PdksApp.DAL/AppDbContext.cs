


using Microsoft.EntityFrameworkCore;
using PdksApp.WinForm;
using PdksApp.WinForm.DeviceHelper;

namespace PdksApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<DeviceInfo> DeviceInfos{ get; set; }
        public DbSet<User> Users{ get; set; }

    }
}
