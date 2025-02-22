using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_DAL.Entities
{
    public class TypeOfSubscription : BaseEntity
    {
        public string Type { get; set; }
        public ICollection<Trainee> Trainees { get; set; } = new HashSet<Trainee>();
        public override string ToString()
        {
            return $"{Type}";
        }
    }
}
