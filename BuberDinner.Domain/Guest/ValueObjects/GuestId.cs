using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects
{
    public sealed class GuestId : ValueObject
    {
        public Guid Value { get; }

        private GuestId(Guid value)
        {
            Value = value;
        }

        public static GuestId CreateUnique() => new GuestId(Guid.NewGuid());

        public override IEnumerable<object> GetEqualityComponnents()
        {
            yield return Value; 
        }
    }
}
