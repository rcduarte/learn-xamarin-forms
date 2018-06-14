using PopularGames.Core.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PopularGames.Core
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            BuildDependencies();
            InitNavigation();
        }

        public void BuildDependencies()
        {
            ViewModelLocator.Instance.Build();
        }

        async void InitNavigation()
        {
            var navigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
            await navigationService.InitializeAsync();
        }
    }
}
