using GYM_BLL.InterFace;
using GYM_DAL;
using GYM_DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_BLL
{
    public class AdminRepository : GenericRepository<Admin>,IAdminRepository
    {
        public AdminRepository(GYMDbContext dbContext) :base(dbContext)
        {
            
        }

        public Admin? GetAdminByEmail(string email,string password)
        {
            return _dbContext.Admins.FirstOrDefault(A=>A.Email == email && A.Password == password);
        }
    }
}
