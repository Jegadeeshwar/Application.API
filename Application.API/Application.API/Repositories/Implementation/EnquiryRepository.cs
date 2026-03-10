using Application.API.Data;
using Application.API.Models.Domain;
using Application.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Application.API.Repositories.Implementation
{
    public class EnquiryRepository : IEnquiryRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public EnquiryRepository(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Enquiry> AddEnquiryAsync(Enquiry enquiry)
        {
            await _dbContext.Enquiries.AddAsync(enquiry);
            await _dbContext.SaveChangesAsync();

            return enquiry;
        }

        public async Task<IEnumerable<Enquiry>> GetAllEnquiriesAsync()
        {
            return await _dbContext.Enquiries.ToListAsync();
        }
    }
}
