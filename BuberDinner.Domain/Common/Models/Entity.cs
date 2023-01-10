namespace BuberDinner.Domain.Common.Models
{
    public abstract class Entity<TId> : IEquatable<Entity<TId>>
        where TId : notnull 
    {
        public TId Id { get; protected set; }

        public Entity(TId id)
        {
            Id = id;
        }

        public override bool Equals(object? obj) => obj is Entity<TId> entity && Id.Equals(entity.Id);

#pragma warning disable SA1201
        public static bool operator ==(Entity<TId> left, Entity<TId> right) => Equals(left, right);
#pragma warning restore SA1201

        public static bool operator !=(Entity<TId> left, Entity<TId> right) => !Equals(left, right);

        public override int GetHashCode() => Id.GetHashCode();

        public bool Equals(Entity<TId>? other) => Equals((object?)other);

#pragma warning disable CS8618
        protected Entity()
        {
        }
#pragma warning restore CS8618
    }
}
