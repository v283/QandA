using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Security;
using QandA;
namespace QandA.Actions
{
    public class InputCommand
    {
        public InputCommand()
        {
        }
        public static void Copy()
        {
            Console.WriteLine("Введіть: [шлях до файлу] to [новий шлях до файлу].");
            string inputText = Console.ReadLine().ToString().Replace("[", "").Replace("]", "");
            string[] paths = inputText.Split(" to ");

            FileActions.CopyFileTo(paths[0], paths[1]);


        }
        //6. ERA - видалити файл, або файли з диску;
        public static void Era()
        {
            Console.WriteLine("Що потрібно видалити: 1) Файл; 2) Папку.");
            string type = Console.ReadLine().ToString();
            Console.WriteLine("Введіть: [шлях]");
            string path = Console.ReadLine().ToString().Replace("[", "").Replace("]", "");
            if (type == "1")
            {
                FileActions.DeleteFile(path);
            }
            else if (type == "2")
            {
                FileActions.DeleteDirectory(path);
            }
            else { Console.WriteLine("Команда введена не правильно"); }
        }

        //10.TIME - встановити поточну дату;
        public static void Time()
        {

            
        }
        //11.TYPE - вивести вміст файлу на екран.
        public static void Type()
        {
            Console.WriteLine("Введіть: [шлях]");
            string path = Console.ReadLine().ToString().Replace("[", "").Replace("]", "");
            Console.WriteLine();
            FileActions.ReadFile(path);
            Console.WriteLine();
        }

        public static void Help()
        {
            try
            {
                var members = typeof(InputCommand).GetMembers(BindingFlags.Static | BindingFlags.Public);
                int i = 1;
                Console.WriteLine("Список усіх доступних команд: ");
                foreach (var item in members)
                {
                    Console.WriteLine("{0}) {1};", i, item.Name);
                }
            }
            catch (SecurityException e)
            {
                Console.WriteLine("SecurityException : " + e.Message);
            }
        }
    }
}

