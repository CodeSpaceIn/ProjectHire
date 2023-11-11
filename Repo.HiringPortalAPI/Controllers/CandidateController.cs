using Microsoft.AspNetCore.Mvc;
using HiringPortal.Core.Models;
using HiringPortal.Services.Interfaces;
using HiringPortal.Core.Interfaces;


namespace HiringPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService _candiateService;
        public CandidateController(ICandidateService candidateService)
        {
            // Inject Unit Of Work to the contructor of the product controller
            _candiateService = candidateService;
          
        }

        /// <summary>
        /// This endpoint returns all candidates from the repository
        /// </summary>
        /// <returns>List of canidate  objects</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _candiateService.GetAllCandidates();
               return Ok(data);
        }
        /// <summary>
        /// Get candidate by id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCandidateById(int id)
        {
            var canDetails = await _candiateService.GetCandidateById(id);

            if (canDetails != null)
            {
                return Ok(canDetails);
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Add a new candidate
        /// </summary>
        /// <param name="canDetails"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateCandiate(Candidate canDetails)
        {
            var iscandiatetCreated = await _candiateService.CreateCandidate(canDetails);

            if (iscandiatetCreated)
            {
                return Ok(iscandiatetCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        ///// <summary>
        ///// Update the product
        ///// </summary>
        ///// <param name="canDetails"></param>
        ///// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateCandidtate(Candidate canDetails)
        {
            if (canDetails != null)
            {
                var iscanUpdated = await _candiateService.UpdateCandidate(canDetails);
                if (iscanUpdated)
                {
                    return Ok(iscanUpdated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        ///// <summary>
        ///// Delete product by id
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCandidate(int id)
        {
            var isCandeleted = await _candiateService.DeleteCandidate(id);

            if (isCandeleted)
            {
                return Ok(isCandeleted);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
