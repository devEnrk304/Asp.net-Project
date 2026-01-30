using domain.Common;

namespace domain.Students
{
    public class Student : Entity
    {
        public string Names { get; private set; } = string.Empty;

        public string LastNames { get; private set; } = string.Empty;


    }
}
