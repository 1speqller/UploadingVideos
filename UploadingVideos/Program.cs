/// <summary>
/// "Клиентский код"
/// </summary>

using UploadingVideos.Command;

string videoUrl;
string outputFilePath = "\\UploadingVideos\\UploadingVideos\\bin\\Debug\\net8.0";

Console.WriteLine("Введите ссылку на видео:");
videoUrl = Console.ReadLine();

CommandInvoker invoker = new CommandInvoker();

// Создание и выполнение команды для получения информации о видео
GetVideoInfoCommand getVideoInfoCommand = new GetVideoInfoCommand(videoUrl);
await invoker.ExecuteCommand(getVideoInfoCommand);

// Создание и выполнение команды для загрузки видео (даже если сейчас не работает)
DownloadVideoCommand downloadVideoCommand = new DownloadVideoCommand(videoUrl, outputFilePath);
await invoker.ExecuteCommand(downloadVideoCommand);