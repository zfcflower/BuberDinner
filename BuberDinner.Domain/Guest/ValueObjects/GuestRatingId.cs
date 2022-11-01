using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects
{
    public sealed class GuestRatingId : ValueObject
    {
        public Guid Value { get; }

        private GuestRatingId(Guid value)
        {
            Value = value;
        }

        public static GuestRatingId CreateUnique() => new GuestRatingId(Guid.NewGuid());

        public override IEnumerable<object> GetEqualityComponnents()
        {
            yield return Value; 
        }
    }
}
