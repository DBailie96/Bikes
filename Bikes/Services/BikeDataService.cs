using Entities;
using System.Net.Http.Json;

namespace Bikes.Services
{
    public class BikeDataService : IBikeDataService
    {
        private readonly HttpClient _client;

        public BikeDataService(HttpClient client)
        {
            _client = client;
        }

        public async Task<List<Bike>> GetBikes()
        {
            var bikes = await _client.GetFromJsonAsync<List<Bike>>("bikes.json");
            return bikes;
        }
        public Task<Bike> GetBike(int id)
        {
            throw new NotImplementedException();
        }
        public Task CreateBike(Bike newBike)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBike(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditBike(int id)
        {
            throw new NotImplementedException();
        }

    }
}
