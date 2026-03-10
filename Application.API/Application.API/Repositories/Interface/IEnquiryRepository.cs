using Application.API.Models.Domain;

namespace Application.API.Repositories.Interface
{
    public interface IEnquiryRepository
    {
        Task<Enquiry> AddEnquiryAsync(Enquiry enquiry);
        Task<IEnumerable<Enquiry>> GetAllEnquiriesAsync();
    }
}
