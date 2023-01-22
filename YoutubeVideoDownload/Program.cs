namespace YoutubeVideoDownload
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите ссылку на видео: ");

                Addresser addresser = new Addresser();

                VideoYoutube videoYoutube = new VideoYoutube();

                videoYoutube.Link = Console.ReadLine();

                GetInfo getInfo = new GetInfo(videoYoutube);
                DownloadVideo downloadVideo = new DownloadVideo(videoYoutube);

                Console.WriteLine("1 - Вывести информацию о видео. 2 - Скачать видео.");
                bool IsCorrect = int.TryParse(Console.ReadLine(), out int num);

                if (IsCorrect)
                {
                    switch (num)
                    {
                        case 1:
                            addresser.SetCommand(getInfo);
                            await addresser.Run();
                            break;
                        case 2:
                            addresser.SetCommand(downloadVideo);
                            await addresser.Run();
                            break;
                        default:
                            Console.WriteLine("Неизвестная команда.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не корректное число.");
                }
            }
        }
    }
}