using GetEntityDetailsApi.Models;
using GetEntityDetailsApi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace GetEntityDetailsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityDetailsController : Controller
    {
        private readonly IEntityDetailsRepository _entityDetailsRepository;
        //protected EntityDetails _entityDetails;

        public EntityDetailsController(IEntityDetailsRepository entityDetailsRepository)
        {
            _entityDetailsRepository = entityDetailsRepository;

        }


        [HttpGet("{ACN}")]
        public async Task<EntityDetails> GetEntity(int ACN)
        {
            //try
            //{
                
                var entityDetails = await _entityDetailsRepository.GetEntityDetails(ACN); 
                return entityDetails;


           // }
            //catch (Exception ex)
            //{
            //    return("");
            //}
           
        }

    }
}
