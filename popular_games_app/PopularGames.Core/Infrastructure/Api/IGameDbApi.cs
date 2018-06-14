using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using PopularGames.Core.Models;
using Refit;

namespace PopularGames.Core.Infrastructure
{
    [Headers("Content-Type: application/json")]
    public interface IGameDbApi
    {
        [Get("/games/?fields=id,name,summary,popularity,cover,esrb,websites&order=popularity:desc")]
        Task<IEnumerable<Game>> GetGamesAsync([Header("user-key")] string authorization);
    }
}