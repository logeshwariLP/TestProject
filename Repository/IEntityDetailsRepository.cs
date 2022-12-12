using GetEntityDetailsApi.Models;

namespace GetEntityDetailsApi.Repository
{
    public interface IEntityDetailsRepository
    {
       
        Task<EntityDetails> GetEntityDetails(int ACN);
    }
}
