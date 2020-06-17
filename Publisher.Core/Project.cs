using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.Core
{
    public class Project
    {
        public string Name { get; set; }
        public string RootFolder { get; set; }
        public string OutputFolderName { get; set; }

        public List<ProjectFolder> Folders { get; set; } = new List<ProjectFolder>();
        public List<ProjectFile> Files { get; set; } = new List<ProjectFile>();

        public void Run(PublisherScheme scheme)
        {
            var dirPath = Path.Combine(DefaultReplaces(scheme.OutputFolder), DefaultReplaces(OutputFolderName));
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            foreach (var folder in Folders)
            {
                var s = Path.Combine(RootFolder, folder.FolderPath);
                var d = Path.Combine(dirPath, folder.FolderPath);
                DirectoryCopy(s, d);
            }
            foreach (var file in Files)
            {
                var s = Path.Combine(RootFolder, file.FilePath);
                var d = Path.Combine(dirPath, file.FilePath);
                FileCopy(s, d);
            }
        }

        private string DefaultReplaces(string value)
        {
            return value
                .Replace("@data@", DateTime.Now.ToString("yyyyMMdd"))
                .Replace("@hora@", DateTime.Now.ToString("HHmm"));
        }

        private void FileCopy(string source, string dest)
        {
            var dirPath = Path.GetDirectoryName(dest);
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
            File.Copy(source, dest);
        }

        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs = true)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
    }
}
