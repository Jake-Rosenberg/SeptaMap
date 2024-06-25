using SeptaMap.Infrastructure.External.Interfaces;
using SeptaMap.Infrastructure.External.Models;

namespace SeptaMap.Infrastructure.External.Services
{
    public class TrainViewService(ISeptaApi septaApi)
    {
        private readonly ISeptaApi _septaApi = septaApi;

        public async Task<List<TrainViewDTO>> GetTrainViewAsync()
        {
            return await _septaApi.GetTrainViewAsync();
        }
    }
}
