
using domain.Common;

namespace domain.Students
{
    public class IdNumbers : ValueObject
    {
        string Id { get; private set; } = string.Empty;

        IdNumbers(string idNumbers)
        {
            Id = idNumbers;
        }

    }
}
