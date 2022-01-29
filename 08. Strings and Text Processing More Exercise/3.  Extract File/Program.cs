using System;

namespace _3.__Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');

            string fileWithExtension = input[input.Length - 1];

            string[] file = fileWithExtension.Split(".");

            string extension = file[file.Length - 1];
            string fileName = fileWithExtension.Replace($".{extension}", "");


            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}

