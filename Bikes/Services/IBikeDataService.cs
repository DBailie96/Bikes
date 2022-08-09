using Entities;
using Microsoft.AspNetCore.Components;

namespace Bikes.Services
{
    public interface IBikeDataService
    {
        Task<List<Bike>> GetBikes();

        Task<Bike> GetBike(int id);

        Task CreateBike(Bike newBike);

        Task EditBike(int id);

        Task DeleteBike(int id);
    }
}
