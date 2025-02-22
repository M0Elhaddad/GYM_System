using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_DAL.Entities
{
    public class TypeOfExercise :BaseEntity
    {
        public string Type { get; set; }
        public decimal Price { get; set; }
        public ICollection<Trainee> Trainees { get; set; } = new HashSet<Trainee>();
        public override string ToString()
        {
            return $"{Type}";
        }
    }
}
