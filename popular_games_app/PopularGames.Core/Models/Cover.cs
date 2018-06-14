using Newtonsoft.Json;

namespace PopularGames.Core.Models
{

    /// <summary>
    /// See https://igdb.github.io/api/references/images/
    /// </summary>
    public class Cover
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("cloudinary_id")]
        public string CloudinaryId { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        public string Thumb
        {
            get { return $"{AppSettings.ApiImageBaseUrl}t_thumb/{CloudinaryId}.jpg"; }
        }

        public string ScreenshotMed
        {
            get { return $"{AppSettings.ApiImageBaseUrl}t_screenshot_med/{CloudinaryId}.jpg"; }
        }

        public string LogoMed
        {
            get { return $"{AppSettings.ApiImageBaseUrl}t_logo_med/{CloudinaryId}.jpg"; }
        }

        public string ScreenshotBig
        {
            get { return $"{AppSettings.ApiImageBaseUrl}t_screenshot_big/{CloudinaryId}.jpg"; }
        }

    }
}
