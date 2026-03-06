using Application.API.Models.Domain;

namespace Application.API.Models.DTO
{
    public class EnquiriesRequest
    {
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
    }
}
