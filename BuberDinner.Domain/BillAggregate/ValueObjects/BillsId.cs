using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.BillAggregate.ValueObjects
{
    public sealed class BillsId : ValueObject
    {
        public Guid Value { get; }

        private BillsId(Guid value)
        {
            Value = value;
        }

        public static BillsId CreateUnique() => new BillsId(Guid.NewGuid());

        public override IEnumerable<object> GetEqualityComponnents()
        {
            yield return Value;
        }
    }
}
