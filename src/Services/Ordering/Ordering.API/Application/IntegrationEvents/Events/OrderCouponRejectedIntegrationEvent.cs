using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;

namespace Ordering.API.Application.IntegrationEvents.Events
{
    public record class OrderCouponRejectedIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; }

        public string Code { get; }

        public OrderCouponRejectedIntegrationEvent(int orderId, string code)
        {
            OrderId = orderId;
            Code = code;
        }
    }
}