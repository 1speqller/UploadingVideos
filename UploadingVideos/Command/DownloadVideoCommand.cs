using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace UploadingVideos.Command
{
    /// <summary>
    /// Загрузка видео (В данный момент не работает, невозможно скачивать видео)
    /// </summary>
    class DownloadVideoCommand : ICommand
    {
        private readonly string _videoUrl;
        private readonly string _outputFilePath;

        public DownloadVideoCommand(string videoUrl = "https://www.youtube.com/watch?v=dQw4w9WgXcQ", string outputFilePath = "\\bin\\Debug\\net8.0")
        {
            _videoUrl = videoUrl;
            _outputFilePath = outputFilePath;
        }

        public async Task Execute()
        {
            try
            {
                var youtubeClient = new YoutubeClient();
                var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(_videoUrl);

                var streamInfo = streamManifest.GetVideoOnlyStreams()
                    .Where(s => s.Container == Container.Mp4)
                    .GetWithHighestVideoQuality();

                // Загрузка видео
                if (streamInfo != null)
                {
                    await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, _outputFilePath);
                    Console.WriteLine($"Видео успешно загружено в: {_outputFilePath}");
                }
                else
                {
                    Console.WriteLine("Не удалось найти подходящий стрим для загрузки.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке видео: {ex.Message}");
            }
        }
    }
}
