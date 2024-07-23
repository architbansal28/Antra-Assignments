using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Services;
using MovieShop.Infrastructure.Repositories;

namespace MovieShop.Infrastructure.Services;

public class CastService : ICastService
{
    private readonly CastRepository _castRepository;

    public CastService(CastRepository castRepository)
    {
        _castRepository = castRepository;
    }

    public Cast GetCastDetails(int id)
    {
        return _castRepository.GetById(id);
    }
}