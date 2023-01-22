namespace YoutubeVideoDownload
{
    class DownloadVideo : ICommand
    {
        VideoYoutube videoYoutube;
        public DownloadVideo(VideoYoutube videoYoutube)
        {
            this.videoYoutube = videoYoutube;
        }

        public async Task ExecuteAsync()
        {
            await videoYoutube.DownloadAsync();
        }
    }
}