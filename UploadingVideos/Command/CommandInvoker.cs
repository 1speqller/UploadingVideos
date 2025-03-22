namespace UploadingVideos.Command
{
    /// <summary>
    /// Invoker отвечает за вызов команд
    /// </summary>
    class CommandInvoker
    {
        public async Task ExecuteCommand(ICommand command)
        {
            await command.Execute();
        }
    }
}
