using BuberDinner.Domain.Bills.ValueObjects;
using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Menu.ValueObjects;

namespace BuberDinner.Domain.Bills
{
    public sealed class Bills : AggregateRoot<BillsId>
    {
        public DinnerId DinnerId { get; }
        public GuestId GuestId { get; }
        public HostId HostId { get; }
        public Price Price { get; }
        public DateTime CreatedDateTime { get; }
        public DateTime UpdatedDateTime { get; }

        private Bills(BillsId billsId,DinnerId dinnerId,GuestId guestId,HostId hostId,
            Price price,DateTime createdDateTime,DateTime updateDateTime) 
            : base(billsId)
        {
            DinnerId = dinnerId;
            GuestId = guestId;
            HostId = hostId;
            Price = price;
            CreatedDateTime = createdDateTime;
            UpdatedDateTime = updateDateTime;
        }

        public static Bills Create(DinnerId dinnerId, GuestId guestId, HostId hostId,Price price) 
            => new(BillsId.CreateUnique(), dinnerId, guestId, hostId, price, DateTime.UtcNow, DateTime.UtcNow);
    }
}
