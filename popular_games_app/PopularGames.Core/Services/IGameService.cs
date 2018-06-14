using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using PopularGames.Core.Models;

namespace PopularGames.Core.Services
{
    public interface IGameService
    {
        Task<IEnumerable<Game>> GetGamesAsync();
    }
}