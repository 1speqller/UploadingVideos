namespace UploadingVideos.Command
{
    /// <summary>
    /// Основной интерфейс, определяет общий контракт для всех команд
    /// </summary>
    interface ICommand
    {
        Task Execute();
    }
}
