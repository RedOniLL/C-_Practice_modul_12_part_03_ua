using System;

namespace C__Practice_modul_12_part_03_ua
{
    public static class FileManager
    {
        public static bool CopyFile(string sourcePath, string destinationPath)
        {
            try
            {
                if (!File.Exists(sourcePath))
                {
                    Console.WriteLine("Error: File not found.");
                    return false;
                }

                File.Copy(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)), true);

                if (File.Exists(Path.Combine(destinationPath, Path.GetFileName(sourcePath))))
                {
                    Console.WriteLine("File copied successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Error: File not copied.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public static bool MoveFile(string sourcePath, string destinationPath)
        {
            try
            {
                if (!File.Exists(sourcePath))
                {
                    Console.WriteLine("Error: File not found.");
                    return false;
                }

                File.Move(sourcePath, Path.Combine(destinationPath, Path.GetFileName(sourcePath)));

                if (File.Exists(Path.Combine(destinationPath, Path.GetFileName(sourcePath))))
                {
                    Console.WriteLine("File moved successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Error: File not moved.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public static bool CopyFolder(string sourcePath, string destinationPath)
        {
            try
            {
                if (!Directory.Exists(sourcePath))
                {
                    Console.WriteLine("Error: Source folder not found.");
                    return false;
                }

                Directory.CreateDirectory(destinationPath);

                foreach (string file in Directory.GetFiles(sourcePath))
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(destinationPath, fileName);
                    File.Copy(file, destFile, true);
                }

                foreach (string subDir in Directory.GetDirectories(sourcePath))
                {
                    string dirName = new DirectoryInfo(subDir).Name;
                    string destDir = Path.Combine(destinationPath, dirName);
                    CopyFolder(subDir, destDir);
                }

                Console.WriteLine("Folder copied successfully.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public static bool MoveFolder(string sourcePath, string destinationPath)
        {
            try
            {
                if (!Directory.Exists(sourcePath))
                {
                    Console.WriteLine("Error: Source folder not found.");
                    return false;
                }

                if (!Directory.Exists(destinationPath))
                {
                    Directory.CreateDirectory(destinationPath);
                }

                foreach (string file in Directory.GetFiles(sourcePath))
                {
                    string fileName = Path.GetFileName(file);
                    string destFile = Path.Combine(destinationPath, fileName);
                    File.Move(file, destFile);
                }

                foreach (string subDir in Directory.GetDirectories(sourcePath))
                {
                    string dirName = new DirectoryInfo(subDir).Name;
                    string destDir = Path.Combine(destinationPath, dirName);
                    MoveFolder(subDir, destDir);
                }

                Directory.Delete(sourcePath);

                Console.WriteLine("Folder moved successfully.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
