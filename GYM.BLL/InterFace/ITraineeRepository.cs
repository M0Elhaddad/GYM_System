using GYM_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_BLL.InterFace
{
    public interface ITraineeRepository : IGenericRepository<Trainee>
    {
        public IEnumerable<Trainee>? GetTraineeByName(string name);
        public IEnumerable<Trainee>? GetTraineeBySubscription(int subscription);
        public IEnumerable<Trainee>? GetTraineeByExercise(int exercise);

    }
}
