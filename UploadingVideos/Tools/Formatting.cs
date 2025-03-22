using AngleSharp.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UploadingVideos.Tools
{
    /// <summary>
    /// Класс для форматирования вывода
    /// </summary>
    class Formatting
    {
        public static void StandartOutput(Object title, Object description)
        {
            Console.WriteLine("\n-----------------------------------\n");
            Console.WriteLine($"Название видео: {title}\n");
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine($"Описание видео: {description}\n");
            Console.WriteLine("-----------------------------------\n");
        }
    }
}
