using System;
using System.Collections.Generic;

namespace GradeSystem.Models
{
    public partial class Students
    {
        public Students()
        {
            Grades = new HashSet<Grades>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Grades> Grades { get; set; }
    }
}
