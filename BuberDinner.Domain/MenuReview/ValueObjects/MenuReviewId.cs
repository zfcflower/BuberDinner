using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Menu.ValueObjects
{
    public sealed class MenuReviewId : ValueObject
    {
        public Guid Value { get; }

        private MenuReviewId(Guid value)
        {
            Value = value;
        }

        public static MenuReviewId CreateUnique() => new MenuReviewId(Guid.NewGuid());

        public override IEnumerable<object> GetEqualityComponnents()
        {
            yield return Value; 
        }
    }
}
