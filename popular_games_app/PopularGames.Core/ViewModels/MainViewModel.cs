using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using PopularGames.Core.Models;
using PopularGames.Core.Parameters;
using PopularGames.Core.Services;
using Xamarin.Forms;

namespace PopularGames.Core.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        readonly IGameService _gameService;

        public ICommand ItemClickCommand { get; }

        public ObservableCollection<Game> Items { get; }

        public MainViewModel(IGameService gameService) : base("Video Games!")
        {
            _gameService = gameService;

            ItemClickCommand = new Command<Game>(async (item) => await ItemClickCommandExecuteAsync(item));
            Items = new ObservableCollection<Game>();
        }

        public override async Task InitializeAsync(object navigationData)
        {
            await base.InitializeAsync(navigationData);

            var result = await GetItemsAsync();
            Items.Clear();
            AddItems(result);
        }

        async Task ItemClickCommandExecuteAsync(Game model)
        {
            await NavigationService.NavigateToAsync<DetailsViewModel>(new GameParameter
            {
                Id = model.Id,
                Cover = model.Cover.ScreenshotBig,
                Name = model.Name,
                Popularity = model.Popularity,
                Summary = model.Summary,
            });
        }

        async Task<IEnumerable<Game>> GetItemsAsync()
            => await _gameService.GetGamesAsync();

        void AddItems(IEnumerable<Game> items)
            => items?.ToList()?.ForEach(item => Items.Add(item));
    }
}
