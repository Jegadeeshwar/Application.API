using Application.API.Data;
using Application.API.Models.Domain;
using Application.API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnquiriesController : ControllerBase
    {
        public readonly ApplicationDbContext _dbContext;
        public EnquiriesController(ApplicationDbContext dbContext) 
        {
            this._dbContext = dbContext;
        }
        [HttpPost]
        public async Task<IActionResult> CreateEnquiry(EnquiriesRequest enqReq)
        {
            var enquiryDomain = new Enquiry
            {
                CustomerName = enqReq.CustomerName,
                CustomerPhone = enqReq.CustomerPhone,
                CustomerEmail = enqReq.CustomerEmail,
                Service = enqReq.Service,
                Message = enqReq.Message,
                Address = enqReq.Address,
                Landmark = enqReq.Landmark,
                City = enqReq.City,
                State = enqReq.State,
                Pincode = enqReq.Pincode
            };

            await _dbContext.Enquiries.AddAsync(enquiryDomain);
            await _dbContext.SaveChangesAsync();
            var response = new
            {
                Status = "Success"
            };
            return Ok(response);
        }
    }
}
