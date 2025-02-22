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
    public class TraineeRepository : GenericRepository<Trainee>, ITraineeRepository
    {

        public TraineeRepository(GYMDbContext dbContext):base(dbContext)
        {
        }

        public IEnumerable<Trainee>? GetTraineeByName(string name)
        {
            return _dbContext.Set<Trainee>().Where(T => T.Name.ToLower().Contains(name.ToLower())).Include(T => T.TypeOfExercise).Include(T => T.TypeOfSubscription).ToList();
        }

        public override IEnumerable<Trainee> GetAll()
        {
            return _dbContext.Set<Trainee>().AsNoTracking().Include(T=>T.TypeOfExercise).Include(T=>T.TypeOfSubscription).ToList();
        }

        public IEnumerable<Trainee>? GetTraineeBySubscription(int Subscription)
        {
            return _dbContext.Set<Trainee>().Where(T => T.TypeOfSubscriptionId == Subscription).Include(T => T.TypeOfExercise).Include(T => T.TypeOfSubscription).ToList();


        }

        public IEnumerable<Trainee>? GetTraineeByExercise(int exercise)
        {
            return _dbContext.Set<Trainee>().Where(T => T.TypeOfExerciseId == exercise).Include(T => T.TypeOfExercise).Include(T => T.TypeOfSubscription).ToList();

        }
    }
}
