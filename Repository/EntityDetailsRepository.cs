using AutoMapper;
using GetEntityDetailsApi.DbContexts;
using GetEntityDetailsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GetEntityDetailsApi.Repository
{
    public class EntityDetailsRepository : IEntityDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public EntityDetailsRepository(ApplicationDbContext db)
        {
            _db=db;
            
        }

        public async Task<EntityDetails> GetEntityDetails(int ACN)
        {
            EntityDetails entityDetails = await _db.EntityDetails.Where(x => x.ACN==ACN).FirstOrDefaultAsync();
            return entityDetails;
           
        }
        //Task<EntityDetails> IEntityDetailsRepository.GetEntityDetails(string ACN)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
