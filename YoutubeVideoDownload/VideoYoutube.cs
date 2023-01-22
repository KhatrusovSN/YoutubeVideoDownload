using YoutubeExplode;
using YoutubeExplode.Converter;

namespace YoutubeVideoDownload
{
    class VideoYoutube
    {
        public string Link { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        YoutubeClient client = new YoutubeClient();

        public async Task GetInfoAsync()
        {
            try
            {
                var video = await client.Videos.GetAsync(Link);
                Title = video.Title;
                Description = video.Description;

                Console.WriteLine($"Название:\n{Title}");
                Console.WriteLine($"Описание:\n{Description}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

        public async Task DownloadAsync()
        {
            try
            {
                Console.WriteLine("Выполняется загрузка...");
                await client.Videos.DownloadAsync(Link, $"{Title.Substring(0,10)}.mp4");
                Console.WriteLine("Загрузка завершена.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}