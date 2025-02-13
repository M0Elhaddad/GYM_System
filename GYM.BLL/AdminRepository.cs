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
    public class AdminRepository : GenericRepository<Admin>
    {
        public AdminRepository(GYMDbContext dbContext) :base(dbContext)
        {
            
        }
    }
}
