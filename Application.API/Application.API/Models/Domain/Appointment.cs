namespace Application.API.Models.Domain
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int? EnquiryId { get; set; }
        public string CustomerName { get; set; } = default!;
        public string CustomerPhone { get; set; } = default!;
        public string? CustomerEmail { get; set; }
        public string Service { get; set; } = default!;
        public string? Message { get; set; }
        public string Address { get; set; } = default!;
        public string? Landmark { get; set; }
        public string City { get; set; } = default!;
        public string State { get; set; } = default!;
        public string Pincode { get; set; } = default!;
        public AppointmentStatus AppointmentStatus { get; set; } = AppointmentStatus.Pending;
        public DateTimeOffset? ScheduledStartUtc { get; set; }
        public DateTimeOffset? ScheduledEndUtc { get; set; }
        public DateTimeOffset? AppointmentBookedDateTime { get; set; }

        // Audit
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset? AuditDateTime { get; set; }
    }

}
