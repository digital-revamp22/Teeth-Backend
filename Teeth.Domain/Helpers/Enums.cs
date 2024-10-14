namespace Teeth.Domain.Helpers;

public static class Enums
{
    public enum GenderEnum
    {
        Male = 1,
        Female = 2
    }

    public enum AppointmentStatusEnum
    {
        Pending = 1,
        Scheduled = 2,
        Completed = 3,
        Cancelled = 4
    }
    public enum PaymentDueStatusEnum
    {
        Pending = 1,
        Paid = 2
    }
    public enum DeliveryStatusEnum
    {
        Assigned = 1,
        InTransit = 2,
        Delivered = 3
    }
    public enum ProductTypeEnum
    {
        DentistSupply = 1,
        ClientSupply = 2
    }
    public enum OrderStatusEnum
    {
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
    public enum PaymentTypeEnum
    {
        Deposit = 1,
        OrderPayment = 2
    }
}
