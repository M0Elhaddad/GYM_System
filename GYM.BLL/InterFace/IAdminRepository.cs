using GYM_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_BLL.InterFace
{
    internal interface IAdminRepository:IGenericRepository<Admin>
    {
        public Admin? GetAdminByEmail(string email,string password);
    }
}
