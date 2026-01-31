using domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entities.Teacher
{
    public class Teacher : Entity
    {
        public string Name { get; private set; } = string.Empty;
        public string LastName { get; private set; } = string.Empty;
        public float Salary { get; private set; }

        public Teacher(Guid id, string name, string lastName, float salary) : base(id)
        {
            Name = name;
            LastName = lastName;
            Salary = salary;
        }
    }
}
