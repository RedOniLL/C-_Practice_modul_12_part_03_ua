namespace C__Practice_modul_12_part_03_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the path to the original file:");
                    string sourcePath1 = Console.ReadLine();

                    Console.WriteLine("Enter the path where the file should be copied:");
                    string destinationPath1 = Console.ReadLine();

                    FileManager.CopyFile(sourcePath1, destinationPath1);
                    break;
                case 2:
                    Console.WriteLine("Enter the path to the original file:");
                    string sourcePath2 = Console.ReadLine();

                    Console.WriteLine("Enter the path where the file should be moved:");
                    string destinationPath2 = Console.ReadLine();

                    FileManager.MoveFile(sourcePath2, destinationPath2);
                    break;
                case 3:
                    Console.WriteLine("Enter the path to the source folder:");
                    string sourcePath3 = Console.ReadLine();

                    Console.WriteLine("Enter the path where the folder should be copied:");
                    string destinationPath3 = Console.ReadLine();

                    FileManager.CopyFolder(sourcePath3, destinationPath3);
                    break;
                case 5:
                    Console.WriteLine("Enter the path to the source folder:");
                    string sourcePath5 = Console.ReadLine();

                    Console.WriteLine("Enter the path where the folder should be moved:");
                    string destinationPath5 = Console.ReadLine();

                    FileManager.MoveFolder(sourcePath5, destinationPath5);
                    break;
            }
        }
    }
}
