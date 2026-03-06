namespace Application.API.Models.Domain
{
    public enum EnquiryStatus
    {
        Open,
        Converted,
        Closed
    }

    public enum AppointmentStatus
    {
        Pending,
        Scheduled,
        Rescheduled,
        Completed,
        Cancelled
    }
}
