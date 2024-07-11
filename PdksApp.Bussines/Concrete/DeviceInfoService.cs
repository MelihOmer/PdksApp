using PdksApp.Bussines.Abstract;
using PdksApp.DAL;
using PdksApp.WinForm;
using PdksApp.WinForm.DeviceHelper;
using System.Collections.Generic;
using System.Linq;

namespace PdksApp.Bussines.Concrete
{
    public class DeviceInfoService : IDeviceInfoService
    {
        readonly AppDbContext _dbContext;
        public DeviceInfoService(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }
        public void Add(DeviceInfo entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public List<DeviceInfo> GetAll()
        {
            return _dbContext.DeviceInfos.ToList();
        }

        public DeviceInfo GetById(int id)
        {
            return _dbContext.DeviceInfos.Where(d => d.Id == id).FirstOrDefault();
        }

        public void Remove(DeviceInfo entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update(DeviceInfo entity)
        {
            _dbContext.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
