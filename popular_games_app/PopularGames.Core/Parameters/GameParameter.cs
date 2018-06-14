using System;
namespace PopularGames.Core.Parameters
{
    public class GameParameter
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Cover { get; set; }
        public string Summary { get; set; }
        public double Popularity { get; set; }
    }
}
