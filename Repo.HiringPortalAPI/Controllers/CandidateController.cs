using Microsoft.AspNetCore.Mvc;
using HiringPortal.Core.Models;
using HiringPortal.Services.Interfaces;
using Repo.HiringPortalAPI.Extension;
using Microsoft.Extensions.Logging;
using Repo.HiringPortalAPI.Utility;

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
            try
            {
                var data = await _candiateService.GetAllCandidates();
                return Ok(data.ToResponse());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToErrorResponse());
            }

        }
        /// <summary>
        /// Get candidate by id
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCandidateById(int id)
        {
            try
            {
                var canDetails = await _candiateService.GetCandidateById(id);

                if (canDetails != null)
                {
                    return Ok(canDetails.ToResponse());
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToErrorResponse());
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
            try
            {
                var iscandiatetCreated = await _candiateService.CreateCandidate(canDetails);

                if (iscandiatetCreated)
                {
                    return Ok(iscandiatetCreated.ToResponse());
                }
                else
                {
                    return BadRequest();
                }
            }catch(Exception ex)
            {

                return BadRequest(ex.Message.ToErrorResponse());

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
            try
            {
                if (canDetails != null)
                {
                    var iscanUpdated = await _candiateService.UpdateCandidate(canDetails);
                    if (iscanUpdated)
                    {
                        return Ok(iscanUpdated.ToResponse());
                    }
                    return BadRequest();
                }
                else
                {
                    return BadRequest();
                }
            }catch(Exception ex)
            {

                return BadRequest(ex.Message.ToErrorResponse());
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
            try
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
            catch(Exception ex)
            {
                return BadRequest(ex.Message.ToErrorResponse());

            }
        }
    }
}
