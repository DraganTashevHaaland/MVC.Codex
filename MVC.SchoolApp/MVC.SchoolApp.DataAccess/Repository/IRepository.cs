using System;
using System.Collections.Generic;
using System.Text;

namespace MVC.SchoolApp.DataAccess.Repository
{
    public interface IRepository<T>
    {
        T GeById(int id);
        List<T> GetAll();
        int Insert(T entity);
        void Update(T entity);
        void DeleteById(int id);
    }
}
