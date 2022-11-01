using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menu.ValueObjects;

namespace BuberDinner.Domain.Menu.Entities
{
    public sealed class GuestRating : Entity<GuestRatingId>
    {
        public HostId HostId { get; set; }
        public DinnerId DinnerId { get; set; }
        public Rating Rating { get; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        private GuestRating(GuestRatingId guestRatingId, HostId hostId, DinnerId dinnerId, Rating rating,
            DateTime createdDateTime, DateTime updatedDateTime) 
            : base(guestRatingId)
        {
            HostId = hostId;
            DinnerId = dinnerId;
            Rating = rating;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updatedDateTime;
        }

        public static GuestRating Create(HostId hostId, DinnerId dinnerId, Rating rating) 
            => new(GuestRatingId.CreateUnique(), hostId, dinnerId, rating,DateTime.UtcNow,DateTime.UtcNow);
    }
}
