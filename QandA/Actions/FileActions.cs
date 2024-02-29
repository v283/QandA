using System;
namespace QandA.Actions
{
	public static class FileActions
	{
		public static void CopyFileTo(string pathFrom, string pathTo)
		{

            if (File.Exists(pathFrom))
            {
                try
                {
                    File.Copy(pathFrom, pathTo);
                    Console.WriteLine("Файл успішно скопійовано");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка");
                }
            }
            else
            {
                Console.WriteLine("Такого файлу не існує");
            }
        }
        public static void DeleteFile(string path)
        {

            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                    Console.WriteLine("Файл успішно видалений");
                }
                catch (Exception ex) { Console.WriteLine("Файл не можливо видалити"); }
            }
            else  {  Console.WriteLine("Такого файлу не існує");  }
        }
        public static void DeleteDirectory(string path)
        {

            if (Directory.Exists(path))
            {
                try
                {
                    Directory.Delete(path,true);
                    Console.WriteLine("Папка успішно видалена");
                }
                catch (Exception ex) { Console.WriteLine("Папку не можливо видалити"); }
            }
            else {  Console.WriteLine("Такої папки не існує"); }
        }

        public static void ReadFile(string path)
        {
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                Console.WriteLine(s);
            }

        }

        public static DateTime ChangeTime(this DateTime dateTime, int hours, int minutes, int seconds, int milliseconds)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                hours,
                minutes,
                seconds,
                milliseconds,
                dateTime.Kind);
        }
    }
}

