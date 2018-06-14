using System;
using System.Threading.Tasks;
using PopularGames.Core.Parameters;

namespace PopularGames.Core.ViewModels
{
    public class DetailsViewModel : ViewModelBase
    {

        string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        string _cover;
        public string Cover
        {
            get { return _cover; }
            set { _cover = value; OnPropertyChanged(); }
        }

        string _summary;
        public string Summary
        {
            get { return _summary; }
            set { _summary = value; OnPropertyChanged(); }
        }

        double _popularity;
        public double Popularity
        {
            get { return _popularity; }
            set { _popularity = value; OnPropertyChanged(); }
        }

        public DetailsViewModel() : base("")
        {

        }

        public override async Task InitializeAsync(object parameter)
        {
            var gameParameter = (parameter as GameParameter);

            Title = Name = gameParameter.Name;
            Cover = gameParameter.Cover;
            Popularity = gameParameter.Popularity;
            Summary = gameParameter.Summary;


            await base.InitializeAsync(parameter);
        }
    }
}
