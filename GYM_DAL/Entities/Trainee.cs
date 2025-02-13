using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_DAL.Entities
{
    public class Trainee : BaseEntity
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public DateTime DateOfSubscription { get; set; }
        public DateTime DateOfExpire { get; set; }
        public int Phone { get; set; }
        public int TypeOfSubscriptionId { get; set; }
        public int TypeOfExerciseId { get; set; }
        public TypeOfSubscription TypeOfSubscription { get; set; }
        public TypeOfExercise TypeOfExercise { get; set; }


    }
}
