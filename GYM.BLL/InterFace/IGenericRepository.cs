using GYM_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_BLL.InterFace
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll(int id);
        T GetById(int id);
        int Update(T entity);
        int Delete(T entity);
        int Add(T entity);



    }
}
