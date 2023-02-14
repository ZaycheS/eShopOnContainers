using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;

namespace Ordering.API.Application.IntegrationEvents.Events
{
    public record class OrderCouponConfirmedIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; }

        public int Discount { get; }

        public OrderCouponConfirmedIntegrationEvent(int orderId, int discount)
        {
            OrderId = orderId;
            Discount = discount;
        }
    }
}