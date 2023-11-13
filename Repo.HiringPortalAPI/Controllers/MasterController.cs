using HiringPortal.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Repo.HiringPortalAPI.Extension;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Repo.HiringPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {

        private readonly IMasterDataSerivice _masterService;
        public MasterController(IMasterDataSerivice masterService)
        {
            // Inject Unit Of Work to the contructor of the product controller
            _masterService = masterService;

        }


        [HttpGet]
        [Route("HiringManger")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var data = await _masterService.GetAllHiringMangerAsync();
                return Ok(data.ToResponse());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToErrorResponse());
            }

        }


        [HttpGet]
        [Route("InterviewPanel")]
        public async Task<IActionResult> GetInterviewPanel()
        {
            try
            {
                var data = await _masterService.GetAllInterviewpanelAsync();
                return Ok(data.ToResponse());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToErrorResponse());
            }

        }

        //// GET api/<MasterController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<MasterController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<MasterController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<MasterController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
