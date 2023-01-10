using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.DinnerAggregate.ValueObjects
{
    public sealed class DinnerId : ValueObject
    {
        public Guid Value { get; }

        private DinnerId(Guid value)
        {
            Value = value;
        }

        public static DinnerId CreateUnique() => new(Guid.NewGuid());

        public static DinnerId Create(Guid value) => new(value);

        public override IEnumerable<object> GetEqualityComponnents()
        {
            yield return Value; 
        }
    }
}
