using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using PopularGames.Core.Infrastructure;
using PopularGames.Core.Models;

namespace PopularGames.Core.Services
{
    public class GameService : IGameService
    {
        readonly IGameDbApi _api;

        public GameService(IGameDbApi api)
        {
            _api = api;
        }

        public Task<IEnumerable<Game>> GetGamesAsync()
        {
            return _api.GetGamesAsync(AppSettings.ApiKey);
        }
    }
}
