using Refit;
using SeptaMap.Infrastructure.External.Models;

namespace SeptaMap.Infrastructure.External.Interfaces
{
    public interface ISeptaApi
    {
        [Get("/TrainView/index.php")]
        Task<List<TrainViewDTO>> GetTrainViewAsync();
    }
}
