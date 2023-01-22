namespace YoutubeVideoDownload
{
    class GetInfo : ICommand
    {
        VideoYoutube videoYoutube;
        public GetInfo(VideoYoutube videoYoutube)
        {
            this.videoYoutube = videoYoutube;
        }

        public async Task ExecuteAsync()
        {
            await videoYoutube.GetInfoAsync();
        }
    }
}