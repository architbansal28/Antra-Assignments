using MovieShop.Core.Entities;

namespace MovieShop.Core.Interfaces.Services;

public interface ICastService
{
    Cast GetCastDetails(int id);
}