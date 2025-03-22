using UploadingVideos.Tools;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace UploadingVideos.Command
{
    /// <summary>
    /// Получение информации о видео
    /// </summary>
    class GetVideoInfoCommand : ICommand
    {
        private readonly string _videoUrl;
        private Video _videoInfo;

        public GetVideoInfoCommand(string videoUrl)
        {
            _videoUrl = videoUrl;
        }

        public async Task Execute()
        {
            try
            {
                var youtubeClient = new YoutubeClient();
                _videoInfo = await youtubeClient.Videos.GetAsync(_videoUrl);

                Formatting.StandartOutput(_videoInfo.Title, _videoInfo.Description);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении информации о видео: {ex.Message}");
            }
        }

        public string VideoUrl => _videoUrl;
        public Video VideoInfo => _videoInfo;
    }
}