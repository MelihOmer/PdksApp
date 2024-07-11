using PdksApp.WinForm;
using System.Collections.Generic;

namespace PdksApp.Bussines
{
    public interface IGenericService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
    }
}
