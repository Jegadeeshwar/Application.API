using System.ComponentModel.DataAnnotations;

namespace Application.API.Models.Domain
{
    public class Enquiry
    {
        [Key] 
        public int EnquiryId { get; set; }

        // Customer
        public string CustomerName { get; set; } = default!;
        public string CustomerPhone { get; set; } = default!;
        public string? CustomerEmail { get; set; }

        // Requested service
        public string Service { get; set; } = default!;
        public string? Message { get; set; }

        // Address
        public string Address { get; set; } = default!;
        public string? Landmark { get; set; }
        public string City { get; set; } = default!;
        public string State { get; set; } = default!;
        public string Pincode { get; set; } = default!;

        // Status
        public EnquiryStatus EnquiryStatus { get; set; } = EnquiryStatus.Open;

        // Audit
        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset? AuditDateTime { get; set; } = DateTimeOffset.Now;
    }
}
