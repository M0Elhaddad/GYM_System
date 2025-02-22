using GYM_DAL;
using GYM_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_BLL
{
    public class TypeOfSubscriptionRepository : GenericRepository<TypeOfSubscription>
    {
        public TypeOfSubscriptionRepository(GYMDbContext dbContext) :base(dbContext)
        {
        }
    }
}
