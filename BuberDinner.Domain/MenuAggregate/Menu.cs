using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Common.ValueObjects;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate.Entities;
using BuberDinner.Domain.MenuAggregate.ValueObjects;
using BuberDinner.Domain.MenuReviewAggregate.ValueObjects;

using static System.Collections.Specialized.BitVector32;

namespace BuberDinner.Domain.MenuAggregate
{
    public sealed class Menu : AggregateRoot<MenuId>
    {
        private readonly List<MenuSection>? _sections = new();
        private readonly List<DinnerId> _dinnerIds = new();
        private readonly List<MenuReviewId> _menuReviewIds = new();
        public string Name { get; }
        public string Description { get; }
        public AverageRating AverageRating { get; }
        public HostId HostId { get; }
        public IReadOnlyList<MenuSection> Sections => _sections.AsReadOnly();
        public IReadOnlyList<DinnerId> Dinners => _dinnerIds.AsReadOnly();
        public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }
        private Menu(MenuId menuId, string name, string description,AverageRating averageRating, HostId hostId,
            List<MenuSection>? sections, DateTime createdDateTime, DateTime updateDateTime)
            : base(menuId)
        {
            Name = name;
            Description = description;
            AverageRating = averageRating;
            HostId = hostId;
            _sections = sections;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updateDateTime;
        }

        public static Menu Create(string name, string description, HostId hostId,List<MenuSection>? sections) 
            => new(MenuId.CreateUnique(), name, description, AverageRating.CreateNew(), hostId,
                sections ?? new(),DateTime.UtcNow, DateTime.UtcNow);
    }
}
