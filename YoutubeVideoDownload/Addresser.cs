namespace YoutubeVideoDownload
{
    class Addresser
    {
        ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public async Task Run()
        {
            await command.ExecuteAsync();
        }
    }
}