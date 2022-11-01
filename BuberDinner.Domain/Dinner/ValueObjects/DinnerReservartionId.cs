using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects
{
    public sealed class DinnerReservartionId : ValueObject
    {
        public Guid Value { get; }

        private DinnerReservartionId(Guid value)
        {
            Value = value;
        }

        public static DinnerReservartionId CreateUnique() => new DinnerReservartionId(Guid.NewGuid());

        public override IEnumerable<object> GetEqualityComponnents()
        {
            yield return Value; 
        }
    }
}
