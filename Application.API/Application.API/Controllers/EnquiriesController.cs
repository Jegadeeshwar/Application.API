using Application.API.Data;
using Application.API.Models.Domain;
using Application.API.Models.DTO;
using Application.API.Repositories.Implementation;
using Application.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.API.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class EnquiriesController : ControllerBase
    {
        private readonly IEnquiryRepository _enquiriesRepository;
        public EnquiriesController(IEnquiryRepository enquiriesRepository) 
        {
            this._enquiriesRepository = enquiriesRepository;
        }
        [HttpPost("AddEnquiry")]
        public async Task<IActionResult> CreateEnquiry(EnquiriesDto enqReq)
        {
            var enquiryDomain = new Enquiry
            {
                CustomerName = enqReq.CustomerName,
                CustomerPhone = enqReq.CustomerPhone,
                CustomerEmail = enqReq.CustomerEmail,
                Service = enqReq.Service,
                Message = enqReq.Message,
                //Address = enqReq.Address,
                //Landmark = enqReq.Landmark,
                //City = enqReq.City,
                //State = enqReq.State,
                //Pincode = enqReq.Pincode
            };

            await _enquiriesRepository.AddEnquiryAsync(enquiryDomain);

            return Ok(new { status = "success" });
        }

        [HttpGet("GetEnquiries")]
        public async Task<IActionResult> GetAllEnquiries()
        {
            var response = new List<EnquiriesDto>();
            var enquiriesList = await _enquiriesRepository.GetAllEnquiriesAsync();
            foreach(var enquiries in enquiriesList)
            {
                response.Add(new EnquiriesDto
                {
                    CustomerName = enquiries.CustomerName,
                    CustomerPhone = enquiries.CustomerPhone,
                    CustomerEmail = enquiries.CustomerEmail,
                    Service = enquiries.Service,
                    Message = enquiries.Message,
                    //Address = enquiries.Address,
                    //Landmark =enquiries.Landmark,
                    //City =enquiries.City,
                    //State =enquiries.State,
                    //Pincode =enquiries.Pincode
                });
            }
            return Ok(response);
        }
    }
}
